using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Sklep
{
   
    public partial class OpisProduktu : Form
    {

        long produkt_id;
        long klient_id;
        public OpisProduktu(long wybrany_produkt, long obsługiwany_klient)
        {
            InitializeComponent();
            produkt_id = wybrany_produkt;
            klient_id = obsługiwany_klient;
        }

        private void OpisProduktu_Load(object sender, EventArgs e)
        {
            WyswietlProdukt();
        }

        void WyswietlProdukt()
        {
            DaneSklepuEntities dane = new DaneSklepuEntities();
            var produkt = from p in dane.Produkty
                          join kategoria in dane.Kategorie
                          on p.Id_kategorii equals kategoria.Id_kategorii
                          join vat in dane.Vat
                          on p.Id_vatu equals vat.Id_vatu
                          where p.Id_produktu == produkt_id
                          select new
                          {
                              p.Nazwa,
                              p.Opis,
                              p.Ilość,
                              cena_netto = p.Cena_netto * 100 / 100,
                              cena_brutto = (p.Cena_netto * vat.Wysokosc_vatu / 100 + p.Cena_netto),
                              p.Photo
                          };

            nazwaProduktuLabel.Text = produkt.First().Nazwa;
            opisProduktuLabel.Text = produkt.First().Opis;
            iloscSztukLabel.Text = produkt.First().Ilość.ToString();
            cenaNettoLabel.Text = produkt.First().cena_netto.ToString() + " zł";
            cenaBruttoLabel.Text = produkt.First().cena_brutto.ToString() + " zł";
            if (produkt.First().Photo != null)
            {
                byte[] arr = produkt.First().Photo;
                MemoryStream ms = new MemoryStream(arr);
                photoPictureBox.Image = Image.FromStream(ms);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {   
            this.Close();
        }

        private void buyItButton_Click(object sender, EventArgs e)
        {
            Zamówienie order = new Zamówienie(produkt_id, klient_id );
            order.ShowDialog();
        }

   

        private void refreshDataButton_Click(object sender, EventArgs e)
        {
            WyswietlProdukt();
        }
    }
}
