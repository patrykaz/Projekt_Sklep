using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.IO;

namespace Projekt_Sklep
{
    public partial class PanelAdmina : Form
    {
        long admin_id;
        Produkty produkt = new Produkty();
        public PanelAdmina(long admin)
        {
            InitializeComponent();
            admin_id = admin;
        }

        private void PanelAdmina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daneSklepuDataSet.Vat' table. You can move, or remove it, as needed.
            this.vatTableAdapter.Fill(this.daneSklepuDataSet.Vat);
            // TODO: This line of code loads data into the 'daneSklepuDataSet.Kategorie' table. You can move, or remove it, as needed.
            this.kategorieTableAdapter.Fill(this.daneSklepuDataSet.Kategorie);
            Clear();
            PokazListeProduktow();
        }

        private void PanelAdmina_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            nazwaTowaruTextBox.Text = "";
            kategoriaComboBox.Text = "";
            opisTextBox.Text = "";
            iloscTextBox.Text = "";
            cenaNettoTextBox.Text = "";
            vatComboBox.Text = "";
            zdjeciePictureBox.Image = null;

            filtrKategoriaComboBox.Text = "";

            saveButton.Text = "Zapisz";
            deleteButton.Enabled = false;
            produkt.Id_produktu = 0;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int ilosc_produktu;
            double cenna_netto_produktu;
            if(int.TryParse(iloscTextBox.Text.Trim(), out ilosc_produktu)) { }
            else
            {
                MessageBox.Show("Ilość produktu powinna być typu całkowitego.");
                iloscTextBox.Text = "";
                iloscTextBox.Focus();
                return;
            }
            if(double.TryParse(cenaNettoTextBox.Text.Trim(), out cenna_netto_produktu)) { }
            else
            {
                MessageBox.Show("Cenna netto produktu powinna być typu zmienno przecinkowego.");
                cenaNettoTextBox.Text = "";
                cenaNettoTextBox.Focus();
                return;
            }
            if(nazwaTowaruTextBox.Text.Count() < 3)
            {
                MessageBox.Show("Podana nazwa produktu jest na krótka. Produkt powienien mieć przynajmniej 3 znaki.");
                nazwaTowaruTextBox.Text = "";
                nazwaTowaruTextBox.Focus();
                return;
            }
            if(opisTextBox.Text.Count() < 10)
            {
                MessageBox.Show("Opis produktu jest za krótki. Produkt powienien mieć przynajmniej 10 znaków.");
                opisTextBox.Text = "";
                opisTextBox.Focus();
                return;
            }
            produkt.Nazwa = nazwaTowaruTextBox.Text.Trim();
            produkt.Id_kategorii = int.Parse(kategoriaComboBox.SelectedValue.ToString());
            produkt.Opis = opisTextBox.Text;
            produkt.Ilość = ilosc_produktu;
            produkt.Cena_netto = cenna_netto_produktu;
            produkt.Id_vatu = int.Parse(vatComboBox.SelectedValue.ToString());
            if(zdjeciePictureBox.Image != null)
            {
                MemoryStream ms = new MemoryStream();
                zdjeciePictureBox.Image.Save(ms, zdjeciePictureBox.Image.RawFormat);
                produkt.Photo = ms.ToArray();

            }


            using (DaneSklepuEntities dane = new DaneSklepuEntities())
            {
                if (produkt.Id_produktu == 0)
                {
                    try
                    {
                        dane.Produkty.Add(produkt);
                        dane.SaveChanges();
                        MessageBox.Show("Produkt został dodany do bazy!");
                    }
                    catch
                    {
                        MessageBox.Show("Wprowadzone dane nie są poprawne lub nie które wymagane pola nie zostały uzupełnione, popraw je.");
                        return;
                    }
                }
                else
                {
                    try
                    {
                        dane.Entry(produkt).State = EntityState.Modified;
                        dane.SaveChanges();
                        MessageBox.Show("Produkt został zaktualizowany");
                    }
                    catch
                    {
                        MessageBox.Show("Wprowadzone dane nie są poprawne lub nie które wymagane pola nie zostały uzupełnione, popraw je.");
                        return;
                    }

                }



            }
            Clear();
            PokazListeProduktow();
           
        }

        void PokazListeProduktow()
        {
            produktyDataGridView.AutoGenerateColumns = false;
            using (DaneSklepuEntities dane = new DaneSklepuEntities())
            {
                var listaProduktow = from produkt in dane.Produkty
                                     join kategoria in dane.Kategorie
                                     on produkt.Id_kategorii equals kategoria.Id_kategorii
                                     join vat in dane.Vat
                                     on produkt.Id_vatu equals vat.Id_vatu
                                     select new
                                     {
                                         produkt.Id_produktu,
                                         produkt.Nazwa,
                                         kategoria_produktu = kategoria.Nazwa_kategorii,
                                         produkt.Ilość,
                                         cena_brutto = (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto),
                                         produkt.Photo,
                                         edytuj = "edytuj"
                                     };

                produktyDataGridView.DataSource = listaProduktow.ToList();
            }
        }

        private void produktyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            if (e.ColumnIndex == 6)
            {
                if (e.RowIndex != -1)
                {

                    produkt.Id_produktu = Convert.ToInt32(produktyDataGridView.CurrentRow.Cells["id_produktu"].Value);
                    

                    using (DaneSklepuEntities dane = new DaneSklepuEntities())
                    {
                        produkt = dane.Produkty.Where(x => x.Id_produktu == produkt.Id_produktu).FirstOrDefault();

                        var wybrany_produkt = from p in dane.Produkty
                                       join kategoria in dane.Kategorie
                                       on p.Id_kategorii equals kategoria.Id_kategorii
                                       join vat in dane.Vat
                                       on p.Id_vatu equals vat.Id_vatu
                                       where p.Id_produktu == produkt.Id_produktu
                                      select new
                                      {
                                          p.Nazwa,
                                          kategoria_produktu = kategoria.Nazwa_kategorii,
                                          p.Opis,
                                          p.Ilość,
                                          cena_netto = p.Cena_netto * 100 / 100,
                                          wysokosc_vatu = vat.Wysokosc_vatu,
                                          //cena_brutto = (p.Cena_netto * vat.Wysokosc_vatu / 100 + p.Cena_netto),
                                          p.Photo
                                      };

                        nazwaTowaruTextBox.Text = wybrany_produkt.First().Nazwa;
                        kategoriaComboBox.Text = wybrany_produkt.First().kategoria_produktu;
                        opisTextBox.Text = wybrany_produkt.First().Opis;
                        iloscTextBox.Text = wybrany_produkt.First().Ilość.ToString();
                        cenaNettoTextBox.Text = wybrany_produkt.First().cena_netto.ToString();
                        vatComboBox.Text = wybrany_produkt.First().wysokosc_vatu.ToString();

                        
                        if (wybrany_produkt.First().Photo != null)
                        {
                            byte[] arr = wybrany_produkt.First().Photo;
                            MemoryStream ms = new MemoryStream(arr);
                            zdjeciePictureBox.Image = Image.FromStream(ms);
                        }
                            

                    }
                    saveButton.Text = "Aktualizuj";
                    deleteButton.Enabled = true;
                }

            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Czy na pewno chcesz usunąć ten produkty z bazy?", "Próba usunięcia produktu z bazy.", MessageBoxButtons.YesNo) == DialogResult.Yes)
                using (DaneSklepuEntities dane = new DaneSklepuEntities())
                {
                    
                    var entry = dane.Entry(produkt);
                    if (entry.State == EntityState.Detached)
                        dane.Produkty.Attach(produkt);
                    dane.Produkty.Remove(produkt);
                    dane.SaveChanges();
                    PokazListeProduktow();
                    Clear();
                    MessageBox.Show("Usunięcie produktu powiodło się.");
                }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            produktyDataGridView.AutoGenerateColumns = false;
            using (DaneSklepuEntities dane = new DaneSklepuEntities())
            {
                var filtr1 = filtrNazwaTextBox.Text;
                int filtr3 = 0;
                int filtr4 = 1000000000;
               
                if (filtrCenaOdTextBox.Text != "")
                {
                    if (int.TryParse(filtrCenaOdTextBox.Text, out filtr3)) { }
                    else
                    {
                        MessageBox.Show("Cena \"Od\" powinna być typu całkowitego.");
                        filtrCenaOdTextBox.Text = "";
                        filtrCenaOdTextBox.Focus();
                        return;
                    }
                }
                if (filtrCenaDoTextBox.Text != "")
                {
                    if (int.TryParse(filtrCenaDoTextBox.Text, out filtr4)) { }
                    else
                    {
                        MessageBox.Show("Cena \"Do\" powinna być typu całkowitego.");
                        filtrCenaDoTextBox.Text = "";
                        filtrCenaDoTextBox.Focus();
                        return;
                    }
                }

                if (filtrKategoriaComboBox.Text == "")
                {
                    var listaProduktow = from produkt in dane.Produkty
                                         join kategoria in dane.Kategorie
                                         on produkt.Id_kategorii equals kategoria.Id_kategorii
                                         join vat in dane.Vat
                                         on produkt.Id_vatu equals vat.Id_vatu
                                         where produkt.Nazwa.Contains(filtr1)
                                         where (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto) >= filtr3
                                         where (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto) <= filtr4

                                         select new
                                         {
                                             produkt.Id_produktu,
                                             produkt.Nazwa,
                                             kategoria_produktu = kategoria.Nazwa_kategorii,
                                             produkt.Ilość,
                                             cena_brutto = (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto),
                                             produkt.Photo,
                                             edytuj = "edytuj"
                                         };


                    produktyDataGridView.DataSource = listaProduktow.ToList();
                }
                else
                {
                    int filtr2 = int.Parse(filtrKategoriaComboBox.SelectedValue.ToString());
                    var listaProduktow = from produkt in dane.Produkty
                                         join kategoria in dane.Kategorie
                                         on produkt.Id_kategorii equals kategoria.Id_kategorii
                                         join vat in dane.Vat
                                         on produkt.Id_vatu equals vat.Id_vatu
                                         where produkt.Nazwa.Contains(filtr1)
                                         where produkt.Id_kategorii == filtr2
                                         where (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto) >= filtr3
                                         where (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto) <= filtr4

                                         select new
                                         {
                                             produkt.Id_produktu,
                                             produkt.Nazwa,
                                             kategoria_produktu = kategoria.Nazwa_kategorii,
                                             produkt.Ilość,
                                             cena_brutto = (produkt.Cena_netto * vat.Wysokosc_vatu / 100 + produkt.Cena_netto),
                                             produkt.Photo,
                                             edytuj = "edytuj"

                                         };
                    produktyDataGridView.DataSource = listaProduktow.ToList();
                }
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            filtrNazwaTextBox.Text = "";
            filtrKategoriaComboBox.Text = "";
            filtrCenaOdTextBox.Text = "";
            filtrCenaDoTextBox.Text = "";
            PokazListeProduktow();
        }

        private void filtrKategoriaComboBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void filtrNazwaTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void filtrCenaOdTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void filtrCenaDoTextBox_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void loadPictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Plik graficzny (PNG,BMP,JPG)|*.png;*.bmp;*.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
                zdjeciePictureBox.Image = Image.FromFile(dialog.FileName);
            else
                return;
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
        }

        private void zakupyKlientowButton_Click(object sender, EventArgs e)
        {
            ListaKlientow_Zakupy klienti = new ListaKlientow_Zakupy();
            klienti.ShowDialog();
        }
    }
}
