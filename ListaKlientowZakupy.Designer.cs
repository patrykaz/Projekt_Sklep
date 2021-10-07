namespace Projekt_Sklep
{
    partial class ListaKlientow_Zakupy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaKlientow_Zakupy));
            this.klienciDataGridView = new System.Windows.Forms.DataGridView();
            this.Id_klienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie_nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.E_mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zakupyKlientadataGridView = new System.Windows.Forms.DataGridView();
            this.Klient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imie_nazwisko_klienta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_sztuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_zakupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zakupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewImageColumn();
            this.showAllBoughtProductsButton = new System.Windows.Forms.Button();
            this.sumaSprzedanegoTowaruLabel = new System.Windows.Forms.Label();
            this.ilosc_rekordow = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.liczbaKlientówLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupyKlientadataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // klienciDataGridView
            // 
            this.klienciDataGridView.AllowUserToAddRows = false;
            this.klienciDataGridView.AllowUserToDeleteRows = false;
            this.klienciDataGridView.AllowUserToResizeColumns = false;
            this.klienciDataGridView.AllowUserToResizeRows = false;
            this.klienciDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.klienciDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.klienciDataGridView.ColumnHeadersHeight = 30;
            this.klienciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.klienciDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_klienta,
            this.Imie_nazwisko,
            this.E_mail,
            this.Telefon});
            this.klienciDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.klienciDataGridView.Location = new System.Drawing.Point(12, 12);
            this.klienciDataGridView.Name = "klienciDataGridView";
            this.klienciDataGridView.ReadOnly = true;
            this.klienciDataGridView.RowHeadersVisible = false;
            this.klienciDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klienciDataGridView.Size = new System.Drawing.Size(588, 171);
            this.klienciDataGridView.TabIndex = 0;
            this.klienciDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.klienciDataGridView_CellClick);
            // 
            // Id_klienta
            // 
            this.Id_klienta.DataPropertyName = "Id_użytkownika";
            this.Id_klienta.HeaderText = "Id klienta";
            this.Id_klienta.Name = "Id_klienta";
            this.Id_klienta.ReadOnly = true;
            this.Id_klienta.Visible = false;
            // 
            // Imie_nazwisko
            // 
            this.Imie_nazwisko.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Imie_nazwisko.DataPropertyName = "imie_nazwisko";
            this.Imie_nazwisko.HeaderText = "Imię i nazwisko";
            this.Imie_nazwisko.Name = "Imie_nazwisko";
            this.Imie_nazwisko.ReadOnly = true;
            // 
            // E_mail
            // 
            this.E_mail.DataPropertyName = "E_mail";
            this.E_mail.HeaderText = "E-mail";
            this.E_mail.Name = "E_mail";
            this.E_mail.ReadOnly = true;
            this.E_mail.Width = 200;
            // 
            // Telefon
            // 
            this.Telefon.DataPropertyName = "Telefon";
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            // 
            // zakupyKlientadataGridView
            // 
            this.zakupyKlientadataGridView.AllowUserToAddRows = false;
            this.zakupyKlientadataGridView.AllowUserToDeleteRows = false;
            this.zakupyKlientadataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.zakupyKlientadataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.zakupyKlientadataGridView.ColumnHeadersHeight = 30;
            this.zakupyKlientadataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.zakupyKlientadataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Klient_id,
            this.imie_nazwisko_klienta,
            this.nazwa_produktu,
            this.ilosc_sztuk,
            this.cena_zakupu,
            this.vat,
            this.data_zakupu,
            this.Photo});
            this.zakupyKlientadataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.zakupyKlientadataGridView.Location = new System.Drawing.Point(12, 222);
            this.zakupyKlientadataGridView.Name = "zakupyKlientadataGridView";
            this.zakupyKlientadataGridView.ReadOnly = true;
            this.zakupyKlientadataGridView.RowHeadersVisible = false;
            this.zakupyKlientadataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.zakupyKlientadataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakupyKlientadataGridView.RowTemplate.Height = 100;
            this.zakupyKlientadataGridView.Size = new System.Drawing.Size(889, 450);
            this.zakupyKlientadataGridView.TabIndex = 5;
            // 
            // Klient_id
            // 
            this.Klient_id.DataPropertyName = "Id_klienta";
            this.Klient_id.HeaderText = "Id klienta";
            this.Klient_id.Name = "Klient_id";
            this.Klient_id.ReadOnly = true;
            this.Klient_id.Visible = false;
            // 
            // imie_nazwisko_klienta
            // 
            this.imie_nazwisko_klienta.DataPropertyName = "Imie_i_nazwisko_klienta";
            this.imie_nazwisko_klienta.FillWeight = 120F;
            this.imie_nazwisko_klienta.HeaderText = "Imię i nazwisko";
            this.imie_nazwisko_klienta.Name = "imie_nazwisko_klienta";
            this.imie_nazwisko_klienta.ReadOnly = true;
            this.imie_nazwisko_klienta.Width = 120;
            // 
            // nazwa_produktu
            // 
            this.nazwa_produktu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwa_produktu.DataPropertyName = "Nazwa_produktu";
            this.nazwa_produktu.HeaderText = "Nazwa produktu";
            this.nazwa_produktu.Name = "nazwa_produktu";
            this.nazwa_produktu.ReadOnly = true;
            // 
            // ilosc_sztuk
            // 
            this.ilosc_sztuk.DataPropertyName = "Ilosc_sztuk";
            this.ilosc_sztuk.HeaderText = "Ilość sztuk";
            this.ilosc_sztuk.Name = "ilosc_sztuk";
            this.ilosc_sztuk.ReadOnly = true;
            // 
            // cena_zakupu
            // 
            this.cena_zakupu.DataPropertyName = "Cena_zakupu";
            this.cena_zakupu.HeaderText = "Cena zakupu";
            this.cena_zakupu.Name = "cena_zakupu";
            this.cena_zakupu.ReadOnly = true;
            // 
            // vat
            // 
            this.vat.DataPropertyName = "Vat";
            this.vat.HeaderText = "Vat";
            this.vat.Name = "vat";
            this.vat.ReadOnly = true;
            // 
            // data_zakupu
            // 
            this.data_zakupu.DataPropertyName = "Data_zakupu";
            this.data_zakupu.HeaderText = "Data zakupu";
            this.data_zakupu.Name = "data_zakupu";
            this.data_zakupu.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.FillWeight = 150F;
            this.Photo.HeaderText = "Zdjęcie";
            this.Photo.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            this.Photo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Photo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Photo.Width = 150;
            // 
            // showAllBoughtProductsButton
            // 
            this.showAllBoughtProductsButton.BackColor = System.Drawing.Color.Moccasin;
            this.showAllBoughtProductsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllBoughtProductsButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.showAllBoughtProductsButton.FlatAppearance.BorderSize = 3;
            this.showAllBoughtProductsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllBoughtProductsButton.Location = new System.Drawing.Point(406, 188);
            this.showAllBoughtProductsButton.Name = "showAllBoughtProductsButton";
            this.showAllBoughtProductsButton.Size = new System.Drawing.Size(194, 28);
            this.showAllBoughtProductsButton.TabIndex = 2;
            this.showAllBoughtProductsButton.Text = "Pokaż wszystkie kupione produkty";
            this.showAllBoughtProductsButton.UseVisualStyleBackColor = false;
            this.showAllBoughtProductsButton.Click += new System.EventHandler(this.showAllBoughtProductsButton_Click);
            // 
            // sumaSprzedanegoTowaruLabel
            // 
            this.sumaSprzedanegoTowaruLabel.AutoSize = true;
            this.sumaSprzedanegoTowaruLabel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumaSprzedanegoTowaruLabel.Location = new System.Drawing.Point(7, 675);
            this.sumaSprzedanegoTowaruLabel.Name = "sumaSprzedanegoTowaruLabel";
            this.sumaSprzedanegoTowaruLabel.Size = new System.Drawing.Size(368, 30);
            this.sumaSprzedanegoTowaruLabel.TabIndex = 3;
            this.sumaSprzedanegoTowaruLabel.Text = "Suma sprzedanych produktów:";
            // 
            // ilosc_rekordow
            // 
            this.ilosc_rekordow.AutoSize = true;
            this.ilosc_rekordow.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ilosc_rekordow.Location = new System.Drawing.Point(634, 675);
            this.ilosc_rekordow.Name = "ilosc_rekordow";
            this.ilosc_rekordow.Size = new System.Drawing.Size(221, 30);
            this.ilosc_rekordow.TabIndex = 4;
            this.ilosc_rekordow.Text = "Liczba zamówień:";
            // 
            // liczbaKlientówLabel
            // 
            this.liczbaKlientówLabel.AutoSize = true;
            this.liczbaKlientówLabel.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczbaKlientówLabel.Location = new System.Drawing.Point(12, 192);
            this.liczbaKlientówLabel.Name = "liczbaKlientówLabel";
            this.liczbaKlientówLabel.Size = new System.Drawing.Size(223, 20);
            this.liczbaKlientówLabel.TabIndex = 1;
            this.liczbaKlientówLabel.Text = "Liczba aktywnych klientów: ";
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Moccasin;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.cancelButton.FlatAppearance.BorderSize = 3;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(778, 189);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(123, 27);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Wyjdź";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ListaKlientow_Zakupy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(913, 714);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.liczbaKlientówLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ilosc_rekordow);
            this.Controls.Add(this.sumaSprzedanegoTowaruLabel);
            this.Controls.Add(this.showAllBoughtProductsButton);
            this.Controls.Add(this.zakupyKlientadataGridView);
            this.Controls.Add(this.klienciDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListaKlientow_Zakupy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista klientów i ich zakupy";
            this.Load += new System.EventHandler(this.ListaKlientow_Zakupy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.klienciDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zakupyKlientadataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView klienciDataGridView;
        private System.Windows.Forms.Button showAllBoughtProductsButton;
        private System.Windows.Forms.Label sumaSprzedanegoTowaruLabel;
        private System.Windows.Forms.DataGridView zakupyKlientadataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Klient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn imie_nazwisko_klienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_sztuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_zakupu;
        private System.Windows.Forms.DataGridViewTextBoxColumn vat;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_zakupu;
        private System.Windows.Forms.DataGridViewImageColumn Photo;
        private System.Windows.Forms.Label ilosc_rekordow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label liczbaKlientówLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_klienta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie_nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn E_mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.Button cancelButton;
    }
}