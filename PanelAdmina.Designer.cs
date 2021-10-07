namespace Projekt_Sklep
{
    partial class PanelAdmina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PanelAdmina));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nazwaTowaruTextBox = new System.Windows.Forms.TextBox();
            this.iloscTextBox = new System.Windows.Forms.TextBox();
            this.cenaNettoTextBox = new System.Windows.Forms.TextBox();
            this.kategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.kategorieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.daneSklepuDataSet = new Projekt_Sklep.DaneSklepuDataSet();
            this.vatComboBox = new System.Windows.Forms.ComboBox();
            this.vatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zdjeciePictureBox = new System.Windows.Forms.PictureBox();
            this.produktyDataGridView = new System.Windows.Forms.DataGridView();
            this.id_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kategorii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ilość = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_brutto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdjecie_produktu = new System.Windows.Forms.DataGridViewImageColumn();
            this.edytuj = new System.Windows.Forms.DataGridViewButtonColumn();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.dodajNowyProductButton = new System.Windows.Forms.Button();
            this.kategorieTableAdapter = new Projekt_Sklep.DaneSklepuDataSetTableAdapters.KategorieTableAdapter();
            this.vatTableAdapter = new Projekt_Sklep.DaneSklepuDataSetTableAdapters.VatTableAdapter();
            this.opisTextBox = new System.Windows.Forms.TextBox();
            this.filtrKategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.filtrCenaDoTextBox = new System.Windows.Forms.TextBox();
            this.filtrCenaOdTextBox = new System.Windows.Forms.TextBox();
            this.filtrNazwaTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.loadPictureButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.oknoObrazuPanel = new System.Windows.Forms.Panel();
            this.zakupyKlientowButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneSklepuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyDataGridView)).BeginInit();
            this.oknoObrazuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "nazwa towaru:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "kategoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(69, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(66, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "ilość:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(32, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "cena netto:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(76, 494);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "vat:";
            // 
            // nazwaTowaruTextBox
            // 
            this.nazwaTowaruTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaTowaruTextBox.Location = new System.Drawing.Point(112, 279);
            this.nazwaTowaruTextBox.Name = "nazwaTowaruTextBox";
            this.nazwaTowaruTextBox.Size = new System.Drawing.Size(248, 22);
            this.nazwaTowaruTextBox.TabIndex = 3;
            // 
            // iloscTextBox
            // 
            this.iloscTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscTextBox.Location = new System.Drawing.Point(112, 439);
            this.iloscTextBox.Name = "iloscTextBox";
            this.iloscTextBox.Size = new System.Drawing.Size(121, 22);
            this.iloscTextBox.TabIndex = 9;
            // 
            // cenaNettoTextBox
            // 
            this.cenaNettoTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaNettoTextBox.Location = new System.Drawing.Point(112, 465);
            this.cenaNettoTextBox.Name = "cenaNettoTextBox";
            this.cenaNettoTextBox.Size = new System.Drawing.Size(121, 22);
            this.cenaNettoTextBox.TabIndex = 11;
            // 
            // kategoriaComboBox
            // 
            this.kategoriaComboBox.DataSource = this.kategorieBindingSource;
            this.kategoriaComboBox.DisplayMember = "Nazwa_kategorii";
            this.kategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriaComboBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kategoriaComboBox.FormattingEnabled = true;
            this.kategoriaComboBox.Location = new System.Drawing.Point(112, 305);
            this.kategoriaComboBox.Name = "kategoriaComboBox";
            this.kategoriaComboBox.Size = new System.Drawing.Size(121, 24);
            this.kategoriaComboBox.TabIndex = 5;
            this.kategoriaComboBox.ValueMember = "Id_kategorii";
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
            // vatComboBox
            // 
            this.vatComboBox.DataSource = this.vatBindingSource;
            this.vatComboBox.DisplayMember = "Wysokosc_vatu";
            this.vatComboBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vatComboBox.FormattingEnabled = true;
            this.vatComboBox.Location = new System.Drawing.Point(112, 492);
            this.vatComboBox.Name = "vatComboBox";
            this.vatComboBox.Size = new System.Drawing.Size(121, 24);
            this.vatComboBox.TabIndex = 13;
            this.vatComboBox.ValueMember = "Id_vatu";
            // 
            // vatBindingSource
            // 
            this.vatBindingSource.DataMember = "Vat";
            this.vatBindingSource.DataSource = this.daneSklepuDataSet;
            // 
            // zdjeciePictureBox
            // 
            this.zdjeciePictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.zdjeciePictureBox.Location = new System.Drawing.Point(-1, -1);
            this.zdjeciePictureBox.Name = "zdjeciePictureBox";
            this.zdjeciePictureBox.Size = new System.Drawing.Size(248, 219);
            this.zdjeciePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.zdjeciePictureBox.TabIndex = 16;
            this.zdjeciePictureBox.TabStop = false;
            // 
            // produktyDataGridView
            // 
            this.produktyDataGridView.AllowUserToAddRows = false;
            this.produktyDataGridView.AllowUserToDeleteRows = false;
            this.produktyDataGridView.AllowUserToResizeColumns = false;
            this.produktyDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.produktyDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.produktyDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.produktyDataGridView.ColumnHeadersHeight = 30;
            this.produktyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.produktyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_produktu,
            this.nazwa_produktu,
            this.id_kategorii,
            this.Ilość,
            this.cena_brutto,
            this.zdjecie_produktu,
            this.edytuj});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produktyDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.produktyDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.produktyDataGridView.Location = new System.Drawing.Point(380, 48);
            this.produktyDataGridView.Name = "produktyDataGridView";
            this.produktyDataGridView.ReadOnly = true;
            this.produktyDataGridView.RowHeadersVisible = false;
            this.produktyDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.produktyDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.produktyDataGridView.RowTemplate.Height = 100;
            this.produktyDataGridView.Size = new System.Drawing.Size(790, 506);
            this.produktyDataGridView.TabIndex = 19;
            this.produktyDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produktyDataGridView_CellClick);
            // 
            // id_produktu
            // 
            this.id_produktu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_produktu.DataPropertyName = "Id_produktu";
            this.id_produktu.HeaderText = "Id produktu";
            this.id_produktu.Name = "id_produktu";
            this.id_produktu.ReadOnly = true;
            this.id_produktu.Visible = false;
            // 
            // nazwa_produktu
            // 
            this.nazwa_produktu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nazwa_produktu.DataPropertyName = "Nazwa";
            this.nazwa_produktu.HeaderText = "Nazwa produktu";
            this.nazwa_produktu.Name = "nazwa_produktu";
            this.nazwa_produktu.ReadOnly = true;
            // 
            // id_kategorii
            // 
            this.id_kategorii.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.id_kategorii.DataPropertyName = "kategoria_produktu";
            this.id_kategorii.FillWeight = 50F;
            this.id_kategorii.HeaderText = "Kategoria";
            this.id_kategorii.Name = "id_kategorii";
            this.id_kategorii.ReadOnly = true;
            // 
            // Ilość
            // 
            this.Ilość.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Ilość.DataPropertyName = "Ilość";
            this.Ilość.HeaderText = "Ilość";
            this.Ilość.Name = "Ilość";
            this.Ilość.ReadOnly = true;
            // 
            // cena_brutto
            // 
            this.cena_brutto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cena_brutto.DataPropertyName = "cena_brutto";
            this.cena_brutto.HeaderText = "Cena brutto";
            this.cena_brutto.Name = "cena_brutto";
            this.cena_brutto.ReadOnly = true;
            this.cena_brutto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            // edytuj
            // 
            this.edytuj.DataPropertyName = "edytuj";
            this.edytuj.HeaderText = "Edytuj";
            this.edytuj.Name = "edytuj";
            this.edytuj.ReadOnly = true;
            this.edytuj.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edytuj.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Moccasin;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.saveButton.FlatAppearance.BorderSize = 3;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(72, 531);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(82, 32);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Moccasin;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.deleteButton.FlatAppearance.BorderSize = 3;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(160, 531);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(82, 32);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Usuń";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // dodajNowyProductButton
            // 
            this.dodajNowyProductButton.BackColor = System.Drawing.Color.Moccasin;
            this.dodajNowyProductButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dodajNowyProductButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.dodajNowyProductButton.FlatAppearance.BorderSize = 3;
            this.dodajNowyProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajNowyProductButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajNowyProductButton.Location = new System.Drawing.Point(248, 531);
            this.dodajNowyProductButton.Name = "dodajNowyProductButton";
            this.dodajNowyProductButton.Size = new System.Drawing.Size(82, 32);
            this.dodajNowyProductButton.TabIndex = 16;
            this.dodajNowyProductButton.Text = "Nowy";
            this.dodajNowyProductButton.UseVisualStyleBackColor = false;
            this.dodajNowyProductButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // kategorieTableAdapter
            // 
            this.kategorieTableAdapter.ClearBeforeFill = true;
            // 
            // vatTableAdapter
            // 
            this.vatTableAdapter.ClearBeforeFill = true;
            // 
            // opisTextBox
            // 
            this.opisTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisTextBox.Location = new System.Drawing.Point(112, 333);
            this.opisTextBox.Multiline = true;
            this.opisTextBox.Name = "opisTextBox";
            this.opisTextBox.Size = new System.Drawing.Size(248, 100);
            this.opisTextBox.TabIndex = 7;
            // 
            // filtrKategoriaComboBox
            // 
            this.filtrKategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kategorieBindingSource, "Id_kategorii", true));
            this.filtrKategoriaComboBox.DataSource = this.kategorieBindingSource;
            this.filtrKategoriaComboBox.DisplayMember = "Nazwa_kategorii";
            this.filtrKategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrKategoriaComboBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrKategoriaComboBox.FormattingEnabled = true;
            this.filtrKategoriaComboBox.Location = new System.Drawing.Point(743, 558);
            this.filtrKategoriaComboBox.Name = "filtrKategoriaComboBox";
            this.filtrKategoriaComboBox.Size = new System.Drawing.Size(121, 24);
            this.filtrKategoriaComboBox.TabIndex = 23;
            this.filtrKategoriaComboBox.ValueMember = "Id_kategorii";
            this.filtrKategoriaComboBox.Click += new System.EventHandler(this.filtrKategoriaComboBox_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.BackColor = System.Drawing.Color.Moccasin;
            this.showAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showAllButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.showAllButton.FlatAppearance.BorderSize = 3;
            this.showAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.showAllButton.Location = new System.Drawing.Point(779, 588);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(124, 34);
            this.showAllButton.TabIndex = 30;
            this.showAllButton.Text = "Pokaż wszystko";
            this.showAllButton.UseVisualStyleBackColor = false;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Moccasin;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.searchButton.FlatAppearance.BorderSize = 3;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(649, 588);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(124, 34);
            this.searchButton.TabIndex = 29;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // filtrCenaDoTextBox
            // 
            this.filtrCenaDoTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrCenaDoTextBox.Location = new System.Drawing.Point(1099, 560);
            this.filtrCenaDoTextBox.Name = "filtrCenaDoTextBox";
            this.filtrCenaDoTextBox.Size = new System.Drawing.Size(71, 22);
            this.filtrCenaDoTextBox.TabIndex = 27;
            this.filtrCenaDoTextBox.Click += new System.EventHandler(this.filtrCenaDoTextBox_Click);
            // 
            // filtrCenaOdTextBox
            // 
            this.filtrCenaOdTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrCenaOdTextBox.Location = new System.Drawing.Point(953, 560);
            this.filtrCenaOdTextBox.Name = "filtrCenaOdTextBox";
            this.filtrCenaOdTextBox.Size = new System.Drawing.Size(71, 22);
            this.filtrCenaOdTextBox.TabIndex = 25;
            this.filtrCenaOdTextBox.Click += new System.EventHandler(this.filtrCenaOdTextBox_Click);
            // 
            // filtrNazwaTextBox
            // 
            this.filtrNazwaTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.filtrNazwaTextBox.Location = new System.Drawing.Point(493, 560);
            this.filtrNazwaTextBox.Name = "filtrNazwaTextBox";
            this.filtrNazwaTextBox.Size = new System.Drawing.Size(150, 22);
            this.filtrNazwaTextBox.TabIndex = 21;
            this.filtrNazwaTextBox.Click += new System.EventHandler(this.filtrNazwaTextBox_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(1031, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 26;
            this.label8.Text = "Cena do:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(885, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 24;
            this.label9.Text = "Cena od:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(667, 560);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "Kategoria:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(377, 562);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 18);
            this.label11.TabIndex = 20;
            this.label11.Text = "Nazwa produktu:";
            // 
            // loadPictureButton
            // 
            this.loadPictureButton.BackColor = System.Drawing.Color.Moccasin;
            this.loadPictureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loadPictureButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.loadPictureButton.FlatAppearance.BorderSize = 3;
            this.loadPictureButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadPictureButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loadPictureButton.Location = new System.Drawing.Point(141, 237);
            this.loadPictureButton.Name = "loadPictureButton";
            this.loadPictureButton.Size = new System.Drawing.Size(125, 34);
            this.loadPictureButton.TabIndex = 1;
            this.loadPictureButton.Text = "Wczytaj zdjęcie";
            this.loadPictureButton.UseVisualStyleBackColor = false;
            this.loadPictureButton.Click += new System.EventHandler(this.loadPictureButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Moccasin;
            this.logOutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOutButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.logOutButton.FlatAppearance.BorderSize = 3;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logOutButton.Location = new System.Drawing.Point(1088, 12);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(82, 30);
            this.logOutButton.TabIndex = 18;
            this.logOutButton.Text = "Wyloguj";
            this.logOutButton.UseVisualStyleBackColor = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // oknoObrazuPanel
            // 
            this.oknoObrazuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oknoObrazuPanel.Controls.Add(this.zdjeciePictureBox);
            this.oknoObrazuPanel.Location = new System.Drawing.Point(72, 12);
            this.oknoObrazuPanel.Name = "oknoObrazuPanel";
            this.oknoObrazuPanel.Size = new System.Drawing.Size(248, 219);
            this.oknoObrazuPanel.TabIndex = 0;
            // 
            // zakupyKlientowButton
            // 
            this.zakupyKlientowButton.BackColor = System.Drawing.Color.Moccasin;
            this.zakupyKlientowButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.zakupyKlientowButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.zakupyKlientowButton.FlatAppearance.BorderSize = 3;
            this.zakupyKlientowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zakupyKlientowButton.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zakupyKlientowButton.Location = new System.Drawing.Point(380, 12);
            this.zakupyKlientowButton.Name = "zakupyKlientowButton";
            this.zakupyKlientowButton.Size = new System.Drawing.Size(180, 30);
            this.zakupyKlientowButton.TabIndex = 17;
            this.zakupyKlientowButton.Text = "Lista klientow i ich zakupy";
            this.zakupyKlientowButton.UseVisualStyleBackColor = false;
            this.zakupyKlientowButton.Click += new System.EventHandler(this.zakupyKlientowButton_Click);
            // 
            // PanelAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1186, 629);
            this.Controls.Add(this.zakupyKlientowButton);
            this.Controls.Add(this.oknoObrazuPanel);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.loadPictureButton);
            this.Controls.Add(this.filtrKategoriaComboBox);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.filtrCenaDoTextBox);
            this.Controls.Add(this.filtrCenaOdTextBox);
            this.Controls.Add(this.filtrNazwaTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.opisTextBox);
            this.Controls.Add(this.dodajNowyProductButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.produktyDataGridView);
            this.Controls.Add(this.vatComboBox);
            this.Controls.Add(this.kategoriaComboBox);
            this.Controls.Add(this.cenaNettoTextBox);
            this.Controls.Add(this.iloscTextBox);
            this.Controls.Add(this.nazwaTowaruTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PanelAdmina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel admina";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PanelAdmina_FormClosed);
            this.Load += new System.EventHandler(this.PanelAdmina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategorieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daneSklepuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zdjeciePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produktyDataGridView)).EndInit();
            this.oknoObrazuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nazwaTowaruTextBox;
        private System.Windows.Forms.TextBox iloscTextBox;
        private System.Windows.Forms.TextBox cenaNettoTextBox;
        private System.Windows.Forms.ComboBox kategoriaComboBox;
        private System.Windows.Forms.ComboBox vatComboBox;
        private System.Windows.Forms.PictureBox zdjeciePictureBox;
        private System.Windows.Forms.DataGridView produktyDataGridView;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button dodajNowyProductButton;
        private DaneSklepuDataSet daneSklepuDataSet;
        private System.Windows.Forms.BindingSource kategorieBindingSource;
        private DaneSklepuDataSetTableAdapters.KategorieTableAdapter kategorieTableAdapter;
        private System.Windows.Forms.BindingSource vatBindingSource;
        private DaneSklepuDataSetTableAdapters.VatTableAdapter vatTableAdapter;
        private System.Windows.Forms.TextBox opisTextBox;
        private System.Windows.Forms.ComboBox filtrKategoriaComboBox;
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox filtrCenaDoTextBox;
        private System.Windows.Forms.TextBox filtrCenaOdTextBox;
        private System.Windows.Forms.TextBox filtrNazwaTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button loadPictureButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kategorii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ilość;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_brutto;
        private System.Windows.Forms.DataGridViewImageColumn zdjecie_produktu;
        private System.Windows.Forms.DataGridViewButtonColumn edytuj;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel oknoObrazuPanel;
        private System.Windows.Forms.Button zakupyKlientowButton;
    }
}