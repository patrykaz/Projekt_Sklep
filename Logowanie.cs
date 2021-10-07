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
    public partial class Logowanie : Form
    {
        public Logowanie()
        {
            InitializeComponent();
        }

        private void createNewAccountLabel_Click(object sender, EventArgs e)
        {
            new NoweKonto().ShowDialog();
        }

        private void createNewAccountLabel_MouseEnter(object sender, EventArgs e)
        {
            createNewAccountLabel.Font = new Font(createNewAccountLabel.Font.Name, createNewAccountLabel.Font.SizeInPoints, FontStyle.Underline);
        }

        private void createNewAccountLabel_MouseLeave(object sender, EventArgs e)
        {
            createNewAccountLabel.Font = new Font(createNewAccountLabel.Font.Name, createNewAccountLabel.Font.SizeInPoints, FontStyle.Regular);
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            Zaloguj();
        }

        public void Zaloguj()
        {
            using (DaneSklepuEntities bazadanych = new DaneSklepuEntities())
            {
                var uzytkownik = from u in bazadanych.Użytkownicy
                                 where u.Login == loginTextBox.Text &&
                                       u.Hasło == hasloTextBox.Text
                                 select new { u.Id_użytkownika, u.Login, u.Hasło, u.E_mail };


                var admin = from a in bazadanych.Administracja
                            where a.Login == loginTextBox.Text &&
                                  a.Haslo == hasloTextBox.Text
                            select new { a.Id_administartora, a.Login, a.Haslo };

                if (admin.Any())
                {
                    PanelAdmina main = new PanelAdmina((long)admin.First().Id_administartora);
                    this.Hide();
                    main.ShowDialog();
                    loginTextBox.Text = "";
                    hasloTextBox.Text = "";
                }
                else if (uzytkownik.Any())
                {
                    StronaGłówna main = new StronaGłówna((long)uzytkownik.First().Id_użytkownika);
                    this.Hide();
                    main.ShowDialog();
                    loginTextBox.Text = "";
                    hasloTextBox.Text = "";
                }
                else
                {
                    hasloTextBox.Text = "";
                    MessageBox.Show("Błedny login lub hasło!");
                    hasloTextBox.Focus();
                }
            }  
        }

        private void Logowanie_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
