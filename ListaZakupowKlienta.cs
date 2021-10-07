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
    public partial class Lista_Zakupow_Klienta : Form
    {
        long klient_id;
        double suma_zakupow = 0;
        public Lista_Zakupow_Klienta(long zalogowany_klient)
        {
            InitializeComponent();
            klient_id = zalogowany_klient;
        }

        private void Lista_Zakupow_Klienta_Load(object sender, EventArgs e)
        {
            Wczytaj_liste_kupionych_produktów();
        }

        void Wczytaj_liste_kupionych_produktów()
        {
            viewYourOrderDataGridView.AutoGenerateColumns = false;
            DaneSklepuEntities dane = new DaneSklepuEntities();
            var kupione = from k in dane.Archiwum_kupionego_towaru
                          where k.Id_klienta == klient_id
                          select new
                          {
                              k.Id_kupionego_produktu,
                              k.Nazwa_produktu,
                              k.Ilosc_sztuk,
                              k.Cena_zakupu,
                              k.Data_zakupu,
                              k.Photo,
                          };
                                
                         

            viewYourOrderDataGridView.DataSource = kupione.ToList();

            foreach (var k in kupione)
            {
                suma_zakupow += k.Cena_zakupu;
            }

            moneySpentLabel.Text = "Suma zakupionych produktów: " + suma_zakupow + " zł";



        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
