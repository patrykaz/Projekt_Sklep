using Projekt_Sklep.DaneSklepuDataSetTableAdapters;
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
    public partial class Zamówienie : Form
    {
        Archiwum_kupionego_towaru zapisz_zamowienie = new Archiwum_kupionego_towaru();
        Sprzedaż sprzedane = new Sprzedaż();
        long produkt_id;
        long klient_id;
        int ilosc_sztuk;
        double suma_do_zaplaty;
      
        public Zamówienie(long wybrany_produkt, long zalogowany_klient)
        {
            InitializeComponent();
            produkt_id = wybrany_produkt;
            klient_id = zalogowany_klient;
        }

        private void Zamówienie_Load(object sender, EventArgs e)
        {
            wczytaj_produkt();
        }

        void wczytaj_produkt()
        {
            DaneSklepuEntities dane = new DaneSklepuEntities();
            var produkt = from p in dane.Produkty
                          where p.Id_produktu == produkt_id
                          join vat in dane.Vat
                          on p.Id_vatu equals vat.Id_vatu
                          select new
                          {
                              p.Nazwa,
                              p.Ilość,
                              cena_netto = p.Cena_netto * 100 / 100,
                              cena_brutto = (p.Cena_netto * vat.Wysokosc_vatu / 100 + p.Cena_netto),
                              p.Photo
                          };

            nazwaProduktuLabel.Text = produkt.First().Nazwa;
            if (produkt.First().Photo != null)
            {
                if (produkt.First().Photo != null)
                {
                    byte[] arr = produkt.First().Photo;
                    MemoryStream ms = new MemoryStream(arr);
                    photoPictureBox.Image = Image.FromStream(ms);
                }
            }

            ilosc_sztuk = (int)iloscSztukBox.Value;
            suma_do_zaplaty = (double)(produkt.First().cena_brutto * ilosc_sztuk);
            sumaDoZaplatyLabel.Text = (produkt.First().cena_brutto * ilosc_sztuk).ToString() + " zł";
        }

        private void iloscSztukBox_ValueChanged(object sender, EventArgs e)
        {
            DaneSklepuEntities dane = new DaneSklepuEntities();
            var produkt = from p in dane.Produkty
                          where p.Id_produktu == produkt_id
                          join vat in dane.Vat
                          on p.Id_vatu equals vat.Id_vatu
                          select new
                          {
                              p.Ilość,
                              cena_netto = p.Cena_netto * 100 / 100,
                              cena_brutto = (p.Cena_netto * vat.Wysokosc_vatu / 100 + p.Cena_netto),
                          };

            ilosc_sztuk = (int)iloscSztukBox.Value;
            suma_do_zaplaty = (double)(produkt.First().cena_brutto * ilosc_sztuk);
            sumaDoZaplatyLabel.Text = (produkt.First().cena_brutto * ilosc_sztuk).ToString() + " zł";
            if (ilosc_sztuk > produkt.First().Ilość)
            {
                iloscSztukBox.Value = produkt.First().Ilość;
                MessageBox.Show("Przepraszamy w magazynie znajduje się tylko: " + produkt.First().Ilość + (" sztuk. Jeśli chcesz kupić więcej, skontaktuj się z nami telefonicznie a my domówimy towar którego potrzebujesz. Życzymy miłego dnia :)"));
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            sprzedane.Id_klienta = klient_id;
            sprzedane.id_produktu = produkt_id;
            sprzedane.Ilość_sztuk = ilosc_sztuk;
            sprzedane.Cena_zakupu = suma_do_zaplaty;
            sprzedane.Data_zakupu = DateTime.Now;

            DaneSklepuEntities dane = new DaneSklepuEntities();
            var produkt = from p in dane.Produkty
                          where p.Id_produktu == produkt_id
                          select p;

            produkt.First().Ilość -= ilosc_sztuk;

            dane.Sprzedaż.Add(sprzedane);
            dane.SaveChanges();

            using (DaneSklepuEntities pobrane_dane = new DaneSklepuEntities())
            {
                var pobierz_kupiony_produkt = from kupione in dane.Sprzedaż
                                              join klient in dane.Użytkownicy
                                              on kupione.Id_klienta equals klient.Id_użytkownika
                                              join kupiony_produkt in dane.Produkty
                                              on kupione.id_produktu equals kupiony_produkt.Id_produktu
                                              join kategoria_produktu in dane.Kategorie
                                              on kupiony_produkt.Id_kategorii equals kategoria_produktu.Id_kategorii
                                              join vat_produktu in dane.Vat
                                              on kupiony_produkt.Id_vatu equals vat_produktu.Id_vatu
                                              select new
                                              {
                                                  id_klienta_pobierz = klient.Id_użytkownika,
                                                  imie_nazwisko_klienta_pobierz = klient.Imię + " " + klient.Nazwisko,
                                                  nazwa_produktu_pobierz = kupiony_produkt.Nazwa,
                                                  Opis_produktu_pobierz = kupiony_produkt.Opis,
                                                  Kategoria_pobierz = kategoria_produktu.Nazwa_kategorii,
                                                  ilosc_sztuk_pobierz = kupione.Ilość_sztuk,
                                                  suma_do_zaplaty_pobierz = kupione.Cena_zakupu,
                                                  wysokosc_vatu_pobierz = vat_produktu.Wysokosc_vatu,
                                                  data_zakupu_pobierz = kupione.Data_zakupu,
                                                  zdjecie_produktu_pobierz = kupiony_produkt.Photo
                                              };

                zapisz_zamowienie.Id_klienta = pobierz_kupiony_produkt.First().id_klienta_pobierz;
                zapisz_zamowienie.Imie_i_nazwisko_klienta = pobierz_kupiony_produkt.First().imie_nazwisko_klienta_pobierz;
                zapisz_zamowienie.Nazwa_produktu = pobierz_kupiony_produkt.First().nazwa_produktu_pobierz;
                zapisz_zamowienie.Opis_produktu = pobierz_kupiony_produkt.First().Opis_produktu_pobierz;
                zapisz_zamowienie.Kategoria = pobierz_kupiony_produkt.First().Kategoria_pobierz;
                zapisz_zamowienie.Ilosc_sztuk = pobierz_kupiony_produkt.First().ilosc_sztuk_pobierz;
                zapisz_zamowienie.Cena_zakupu = pobierz_kupiony_produkt.First().suma_do_zaplaty_pobierz;
                zapisz_zamowienie.Vat = pobierz_kupiony_produkt.First().wysokosc_vatu_pobierz;
                zapisz_zamowienie.Data_zakupu = pobierz_kupiony_produkt.First().data_zakupu_pobierz;
                zapisz_zamowienie.Photo = pobierz_kupiony_produkt.First().zdjecie_produktu_pobierz;


                pobrane_dane.Archiwum_kupionego_towaru.Add(zapisz_zamowienie);
                pobrane_dane.SaveChanges();
                dane.Sprzedaż.Remove(sprzedane);
                dane.SaveChanges();
            }

            MessageBox.Show("Dziękujemy za zakupy!");
            this.Close();
        }

        private void cancelButoon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    
}
