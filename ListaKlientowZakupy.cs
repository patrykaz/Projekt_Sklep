using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Sklep
{
    public partial class ListaKlientow_Zakupy : Form
    {
        double suma_zakupow = 0;
        public ListaKlientow_Zakupy()
        {
            InitializeComponent();
        }

        private void ListaKlientow_Zakupy_Load(object sender, EventArgs e)
        {
            Wczytaj_Klientów();
            WszystkieZakupy();
        }

        void Wczytaj_Klientów()
        {
            DaneSklepuEntities dane = new DaneSklepuEntities();

            var klienci = from klient in dane.Użytkownicy
                          select new
                          {
                              klient.Id_użytkownika,
                              imie_nazwisko = klient.Imię + " " + klient.Nazwisko,
                              klient.E_mail,
                              klient.Telefon
                          };

            klienciDataGridView.DataSource = klienci.ToList();
            liczbaKlientówLabel.Text = "Liczba aktywnych klientów: " + klienci.Count();
        }

        private void klienciDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                using (DaneSklepuEntities dane = new DaneSklepuEntities())
                {
                    long klient_id = (long)klienciDataGridView.Rows[e.RowIndex].Cells[0].Value;

                    var zakupy_klienta = from zakupy in dane.Archiwum_kupionego_towaru
                                         where zakupy.Id_klienta == klient_id
                                         select new
                                         {
                                             zakupy.Id_klienta,
                                             zakupy.Imie_i_nazwisko_klienta,
                                             zakupy.Nazwa_produktu,
                                             zakupy.Ilosc_sztuk,
                                             zakupy.Cena_zakupu,
                                             zakupy.Vat,
                                             zakupy.Data_zakupu,
                                             zakupy.Photo
                                         };

                    zakupyKlientadataGridView.DataSource = zakupy_klienta.ToList();

                    foreach (var k in zakupy_klienta)
                    {
                        suma_zakupow += k.Cena_zakupu;
                    }

                    ilosc_rekordow.Text = "Liczba zamówień: " + zakupy_klienta.Count();
                    sumaSprzedanegoTowaruLabel.Text = "Suma sprzedanego towaru: " + suma_zakupow + " zł";
                    suma_zakupow = 0;
                }
            }

            
        }

        private void showAllBoughtProductsButton_Click(object sender, EventArgs e)
        {
            WszystkieZakupy();
        }

        void WszystkieZakupy()
        {
            using (DaneSklepuEntities dane = new DaneSklepuEntities())
            {

                var zakupy_klienta = from zakupy in dane.Archiwum_kupionego_towaru
                                     select new
                                     {
                                         zakupy.Id_klienta,
                                         zakupy.Imie_i_nazwisko_klienta,
                                         zakupy.Nazwa_produktu,
                                         zakupy.Ilosc_sztuk,
                                         zakupy.Cena_zakupu,
                                         zakupy.Vat,
                                         zakupy.Data_zakupu,
                                         zakupy.Photo
                                     };

                zakupyKlientadataGridView.DataSource = zakupy_klienta.ToList();

                foreach (var k in zakupy_klienta)
                {
                    suma_zakupow += k.Cena_zakupu;
                }

                ilosc_rekordow.Text = "Liczba zamówień: " + zakupy_klienta.Count();
                sumaSprzedanegoTowaruLabel.Text = "Suma sprzedanego towaru: " + suma_zakupow + " zł";
                suma_zakupow = 0;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
