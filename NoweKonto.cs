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
    public partial class NoweKonto : Form
    {
        Użytkownicy użytkownik = new Użytkownicy();
        public NoweKonto()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createNewAccountButton_Click(object sender, EventArgs e)
        {
            DaneSklepuEntities dane_użytkownika = new DaneSklepuEntities();
            var sprawdz_login_użytkownika = from u in dane_użytkownika.Użytkownicy
                                where u.Login == loginTextBox.Text.Trim()
                                select new { u.Login };

            var sprawdz_login_admina = from a in dane_użytkownika.Administracja
                                       where a.Login == loginTextBox.Text.Trim()
                                       select new { a.Login };

            if (sprawdz_login_użytkownika.Any() || sprawdz_login_admina.Any())
            {
                MessageBox.Show("Użytkownik o podanym loginie już isnienje, znajdz inne.");
                loginTextBox.Text = "";
                hasloTextBox.Text = "";
                powtorzHasłoTextBox.Text = "";
                loginTextBox.Focus();
            }
            else
            {   
                int nr_telefonu;
                if(imieTextBox.Text.Count() < 3)
                {
                    MessageBox.Show("Imię powinno mieć przynajmniej 3 znaki.");
                    imieTextBox.Text = "";
                    imieTextBox.Focus();
                    return;
                }
                if(nazwiskoTextBox.Text.Count() < 3)
                {
                    MessageBox.Show("Nazwisko powinno mieć przynajmniej 3 znaki.");
                    nazwiskoTextBox.Text = "";
                    nazwiskoTextBox.Focus();
                    return;
                }
                if(plecComboBox.Text == "")
                {
                    MessageBox.Show("Płeć nie została wybrana.");
                    plecComboBox.Focus();
                    return;
                }
                if(emailTextBox.Text.Count() < 8)
                {
                    MessageBox.Show("E-mail powinien mieć przynajmniej 8 znaków.");
                    emailTextBox.Text = "";
                    emailTextBox.Focus();
                    return;
                }
                if(telefonTextBox.Text != "")
                {
                    if (telefonTextBox.Text.Count() != 9)
                    {
                        MessageBox.Show("Nr telefonu powinien składać się z 9 znaków.");
                        telefonTextBox.Text = "";
                        telefonTextBox.Focus();
                        return;
                    }
                }
                if(loginTextBox.Text.Count() < 3)
                {
                    MessageBox.Show("Login powinien mieć przynajmniej 3 znaki.");
                    loginTextBox.Text = "";
                    loginTextBox.Focus();
                    return;
                }
                if(hasloTextBox.Text.Count() < 3)
                {
                    MessageBox.Show("Hasło powinien mieć przynajmniej 3 znaki.");
                    hasloTextBox.Text = "";
                    hasloTextBox.Focus();
                    return;
                }
                if (int.TryParse(telefonTextBox.Text.Trim(), out nr_telefonu))
                {
                    if (hasloTextBox.Text.Trim() == powtorzHasłoTextBox.Text.Trim())
                    {
                        użytkownik.Imię = imieTextBox.Text.Trim();
                        użytkownik.Nazwisko = nazwiskoTextBox.Text.Trim();
                        użytkownik.Płeć = plecComboBox.Text;
                        użytkownik.E_mail = emailTextBox.Text.Trim();
                        użytkownik.Telefon = nr_telefonu;
                        użytkownik.Login = loginTextBox.Text.Trim();
                        użytkownik.Hasło = hasloTextBox.Text.Trim();
                        using (DaneSklepuEntities dane = new DaneSklepuEntities())
                        {
                            try
                            {
                                dane.Użytkownicy.Add(użytkownik);
                                dane.SaveChanges();
                                MessageBox.Show("Konto zostało utwożone!");
                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Wprowadzone dane nie są poprawne lub nie które wymagane pola nie zostały uzupełnione, popraw je.");
                                return;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Podane hasło nie jest identyczne.");
                        hasloTextBox.Text = "";
                        powtorzHasłoTextBox.Text = "";
                        hasloTextBox.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Powyższy numer telefonu został podany nie prawidłowo!");
                    telefonTextBox.Text = "";
                    telefonTextBox.Focus();
                }  
            }
        }
    }
}
