using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Sklep
{
    public partial class StronaGłówna : Form
    {
       
        long zalagowany_id;
        public StronaGłówna(long zalogowany)
        {
            InitializeComponent();
            zalagowany_id = zalogowany;
        }

      

        private void StronaGłówna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'daneSklepuDataSet.Kategorie' table. You can move, or remove it, as needed.
            this.kategorieTableAdapter.Fill(this.daneSklepuDataSet.Kategorie);
            WyswietlZalogowanego();
            ProduktyDataGridView();
            filtrKategoriaComboBox.Text = "";
       
        }

        public void WyswietlZalogowanego()
        {
            DaneSklepuEntities dane = new DaneSklepuEntities();
            var zalogowany = from z in dane.Użytkownicy
                             where z.Id_użytkownika == zalagowany_id
                             select new { z.Imię, z.Nazwisko };
            zalagowanyLabel.Text = "Witaj: " + zalogowany.First().Imię + " " + zalogowany.First().Nazwisko;
        }

        void ProduktyDataGridView()
        {
            pokazProduktyDataGridView.AutoGenerateColumns = false;
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
                                         sprawdz = "Sprawdź"

                                     };
 

                pokazProduktyDataGridView.DataSource = listaProduktow.ToList();
            }
        }

        private void pokazProduktyDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {   
                if(e.RowIndex != -1)
                {
                    OpisProduktu main = new OpisProduktu((long)pokazProduktyDataGridView.Rows[e.RowIndex].Cells[0].Value, zalagowany_id);
                    main.ShowDialog();
                }
                   
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            pokazProduktyDataGridView.AutoGenerateColumns = false;
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
                if(filtrCenaDoTextBox.Text != "")
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
                                             sprawdz = "Sprawdź"
                                         };


                    pokazProduktyDataGridView.DataSource = listaProduktow.ToList();
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
                                             sprawdz = "Sprawdź"
                                         };


                    pokazProduktyDataGridView.DataSource = listaProduktow.ToList();
                }      
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            filtrNazwaTextBox.Text = "";
            filtrKategoriaComboBox.Text = "";
            filtrCenaOdTextBox.Text = "";
            filtrCenaDoTextBox.Text = "";
            ProduktyDataGridView();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Logowanie logowanie = new Logowanie();
            logowanie.Show();
            this.Hide();
        }

        private void myListOfOrderButton_Click(object sender, EventArgs e)
        {
            Lista_Zakupow_Klienta lista_zakupow = new Lista_Zakupow_Klienta((long)zalagowany_id);
            lista_zakupow.ShowDialog();
        }

        private void StronaGłówna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            filtrNazwaTextBox.Text = "";
            filtrKategoriaComboBox.Text = "";
            filtrCenaOdTextBox.Text = "";
            filtrCenaDoTextBox.Text = "";
            ProduktyDataGridView();
        }

    }
}
