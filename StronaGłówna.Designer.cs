namespace Projekt_Sklep
{
    partial class StronaGłówna
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StronaGłówna));
            this.zalagowanyLabel = new System.Windows.Forms.Label();
            this.pokazProduktyDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cena_Brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdjecie_produktu = new System.Windows.Forms.DataGridViewImageColumn();
            this.sprawdz = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.filtrNazwaTextBox = new System.Windows.Forms.TextBox();
            this.filtrCenaOdTextBox = new System.Windows.Forms.TextBox();
            this.filtrCenaDoTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.filtrKategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daneSklepuDataSet = new Projekt_Sklep.DaneSklepuDataSet();
            this.kategorieTableAdapter = new Projekt_Sklep.DaneSklepuDataSetTableAdapters.KategorieTableAdapter();
            this.logOutButton = new System.Windows.Forms.Button();
            this.myListOfOrderButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pokazProduktyDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneSklepuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // zalagowanyLabel
            // 
            this.zalagowanyLabel.AutoSize = true;
            this.zalagowanyLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zalagowanyLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.zalagowanyLabel.Location = new System.Drawing.Point(12, 9);
            this.zalagowanyLabel.Name = "zalagowanyLabel";
            this.zalagowanyLabel.Size = new System.Drawing.Size(76, 26);
            this.zalagowanyLabel.TabIndex = 0;
            this.zalagowanyLabel.Text = "Witaj: ";
            // 
            // pokazProduktyDataGridView
            // 
            this.pokazProduktyDataGridView.AllowUserToAddRows = false;
            this.pokazProduktyDataGridView.AllowUserToDeleteRows = false;
            this.pokazProduktyDataGridView.AllowUserToResizeColumns = false;
            this.pokazProduktyDataGridView.AllowUserToResizeRows = false;
            this.pokazProduktyDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.pokazProduktyDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.pokazProduktyDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.pokazProduktyDataGridView.ColumnHeadersHeight = 30;
            this.pokazProduktyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.pokazProduktyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nazwa_produktu,
            this.Kategoria,
            this.Ilość,
            this.Cena_Brutto,
            this.zdjecie_produktu,
            this.sprawdz});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.pokazProduktyDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.pokazProduktyDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.pokazProduktyDataGridView.Location = new System.Drawing.Point(12, 222);
            this.pokazProduktyDataGridView.Name = "pokazProduktyDataGridView";
            this.pokazProduktyDataGridView.ReadOnly = true;
            this.pokazProduktyDataGridView.RowHeadersVisible = false;
            this.pokazProduktyDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.pokazProduktyDataGridView.RowTemplate.Height = 100;
            this.pokazProduktyDataGridView.Size = new System.Drawing.Size(970, 484);
            this.pokazProduktyDataGridView.TabIndex = 11;
            this.pokazProduktyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pokazProduktyDataGridView_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id_produktu";
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // nazwa_produktu
            // 
            this.nazwa_produktu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwa_produktu.DataPropertyName = "Nazwa";
            this.nazwa_produktu.HeaderText = "Nazwa produktu";
            this.nazwa_produktu.Name = "nazwa_produktu";
            this.nazwa_produktu.ReadOnly = true;
            // 
            // Kategoria
            // 
            this.Kategoria.DataPropertyName = "kategoria_produktu";
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            this.Kategoria.ReadOnly = true;
            // 
            // Ilość
            // 
            this.Ilość.DataPropertyName = "Ilość";
            this.Ilość.HeaderText = "Ilość";
            this.Ilość.Name = "Ilość";
            this.Ilość.ReadOnly = true;
            // 
            // Cena_Brutto
            // 
            this.Cena_Brutto.DataPropertyName = "cena_brutto";
            this.Cena_Brutto.HeaderText = "Cena brutto";
            this.Cena_Brutto.MaxInputLength = 6;
            this.Cena_Brutto.Name = "Cena_Brutto";
            this.Cena_Brutto.ReadOnly = true;
            // 
            // zdjecie_produktu
            // 
            this.zdjecie_produktu.DataPropertyName = "Photo";
            this.zdjecie_produktu.FillWeight = 150F;
            this.zdjecie_produktu.HeaderText = "Zdjęcie";
            this.zdjecie_produktu.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.zdjecie_produktu.Name = "zdjecie_produktu";
            this.zdjecie_produktu.ReadOnly = true;
            this.zdjecie_produktu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.zdjecie_produktu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.zdjecie_produktu.Width = 150;
            // 
            // sprawdz
            // 
            this.sprawdz.DataPropertyName = "sprawdz";
            this.sprawdz.HeaderText = "Pełen opis";
            this.sprawdz.Name = "sprawdz";
            this.sprawdz.ReadOnly = true;
            this.sprawdz.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sprawdz.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sprawdz.Text = "Opis";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nazwa produktu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(59, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(67, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cena od:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(67, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cena do:";
            // 
            // filtrNazwaTextBox
            // 
            this.filtrNazwaTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrNazwaTextBox.Location = new System.Drawing.Point(135, 58);
            this.filtrNazwaTextBox.Name = "filtrNazwaTextBox";
            this.filtrNazwaTextBox.Size = new System.Drawing.Size(121, 22);
            this.filtrNazwaTextBox.TabIndex = 2;
            // 
            // filtrCenaOdTextBox
            // 
            this.filtrCenaOdTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrCenaOdTextBox.Location = new System.Drawing.Point(135, 116);
            this.filtrCenaOdTextBox.Name = "filtrCenaOdTextBox";
            this.filtrCenaOdTextBox.Size = new System.Drawing.Size(121, 22);
            this.filtrCenaOdTextBox.TabIndex = 6;
            // 
            // filtrCenaDoTextBox
            // 
            this.filtrCenaDoTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrCenaDoTextBox.Location = new System.Drawing.Point(135, 144);
            this.filtrCenaDoTextBox.Name = "filtrCenaDoTextBox";
            this.filtrCenaDoTextBox.Size = new System.Drawing.Size(121, 22);
            this.filtrCenaDoTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Moccasin;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.searchButton.FlatAppearance.BorderSize = 3;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.ForeColor = System.Drawing.Color.Black;
            this.searchButton.Location = new System.Drawing.Point(70, 174);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(93, 32);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.Color.Moccasin;
            this.showAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.showAllButton.FlatAppearance.BorderSize = 3;
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showAllButton.ForeColor = System.Drawing.Color.Black;
            this.showAllButton.Location = new System.Drawing.Point(169, 174);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(172, 32);
            this.showAllButton.TabIndex = 10;
            this.showAllButton.Text = "Pokaż wszystkie produkty";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // filtrKategoriaComboBox
            // 
            this.filtrKategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategorieBindingSource, "Id_kategorii", true));
            this.filtrKategoriaComboBox.DataSource = this.kategorieBindingSource;
            this.filtrKategoriaComboBox.DisplayMember = "Nazwa_kategorii";
            this.filtrKategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrKategoriaComboBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrKategoriaComboBox.FormattingEnabled = true;
            this.filtrKategoriaComboBox.Location = new System.Drawing.Point(135, 86);
            this.filtrKategoriaComboBox.Name = "filtrKategoriaComboBox";
            this.filtrKategoriaComboBox.Size = new System.Drawing.Size(121, 24);
            this.filtrKategoriaComboBox.TabIndex = 4;
            this.filtrKategoriaComboBox.ValueMember = "Id_kategorii";
            // 
            // kategorieBindingSource
            // 
            this.kategorieBindingSource.DataMember = "Kategorie";
            this.kategorieBindingSource.DataSource = this.daneSklepuDataSet;
            // 
            // daneSklepuDataSet
            // 
            this.daneSklepuDataSet.DataSetName = "DaneSklepuDataSet";
            this.daneSklepuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kategorieTableAdapter
            // 
            this.kategorieTableAdapter.ClearBeforeFill = true;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Moccasin;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.logOutButton.FlatAppearance.BorderSize = 3;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.ForeColor = System.Drawing.Color.Black;
            this.logOutButton.Location = new System.Drawing.Point(844, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(138, 31);
            this.logOutButton.TabIndex = 14;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // myListOfOrderButton
            // 
            this.myListOfOrderButton.BackColor = System.Drawing.Color.Moccasin;
            this.myListOfOrderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.myListOfOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.myListOfOrderButton.FlatAppearance.BorderSize = 3;
            this.myListOfOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myListOfOrderButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.myListOfOrderButton.ForeColor = System.Drawing.Color.Black;
            this.myListOfOrderButton.Location = new System.Drawing.Point(700, 12);
            this.myListOfOrderButton.Name = "myListOfOrderButton";
            this.myListOfOrderButton.Size = new System.Drawing.Size(138, 31);
            this.myListOfOrderButton.TabIndex = 13;
            this.myListOfOrderButton.Text = "Moja lista zakupów";
            this.myListOfOrderButton.UseVisualStyleBackColor = false;
            this.myListOfOrderButton.Click += new System.EventHandler(this.myListOfOrderButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Moccasin;
            this.refreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refreshButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.refreshButton.FlatAppearance.BorderSize = 3;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshButton.ForeColor = System.Drawing.Color.Black;
            this.refreshButton.Location = new System.Drawing.Point(556, 12);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(138, 31);
            this.refreshButton.TabIndex = 12;
            this.refreshButton.Text = "Odświerz";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // StronaGłówna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(994, 718);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.myListOfOrderButton);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.filtrKategoriaComboBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filtrCenaDoTextBox);
            this.Controls.Add(this.filtrCenaOdTextBox);
            this.Controls.Add(this.filtrNazwaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pokazProduktyDataGridView);
            this.Controls.Add(this.zalagowanyLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StronaGłówna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strona główna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StronaGłówna_FormClosed);
            this.Load += new System.EventHandler(this.StronaGłówna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pokazProduktyDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneSklepuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label zalagowanyLabel;
        private System.Windows.Forms.DataGridView pokazProduktyDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox filtrNazwaTextBox;
        private System.Windows.Forms.TextBox filtrCenaOdTextBox;
        private System.Windows.Forms.TextBox filtrCenaDoTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.ComboBox filtrKategoriaComboBox;
        private DaneSklepuDataSet daneSklepuDataSet;
        private DaneSklepuDataSetTableAdapters.KategorieTableAdapter kategorieTableAdapter;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button myListOfOrderButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilość;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cena_Brutto;
        private System.Windows.Forms.DataGridViewImageColumn zdjecie_produktu;
        private System.Windows.Forms.DataGridViewButtonColumn sprawdz;
    }
}