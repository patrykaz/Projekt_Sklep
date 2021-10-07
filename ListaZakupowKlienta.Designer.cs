namespace Projekt_Sklep
{
    partial class Lista_Zakupow_Klienta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_Zakupow_Klienta));
            this.cancelButton = new System.Windows.Forms.Button();
            this.moneySpentLabel = new System.Windows.Forms.Label();
            this.viewYourOrderDataGridView = new System.Windows.Forms.DataGridView();
            this.Id_zakupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazwa_produktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ilosc_sztuk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena_zakupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data_zakupu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zdjecie = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.viewYourOrderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Moccasin;
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.cancelButton.FlatAppearance.BorderSize = 3;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButton.Location = new System.Drawing.Point(888, 484);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(86, 29);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Wyjdz";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // moneySpentLabel
            // 
            this.moneySpentLabel.AutoSize = true;
            this.moneySpentLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.moneySpentLabel.Location = new System.Drawing.Point(12, 487);
            this.moneySpentLabel.Name = "moneySpentLabel";
            this.moneySpentLabel.Size = new System.Drawing.Size(320, 26);
            this.moneySpentLabel.TabIndex = 1;
            this.moneySpentLabel.Text = "Suma zakupionych produktów:";
            // 
            // viewYourOrderDataGridView
            // 
            this.viewYourOrderDataGridView.AllowUserToAddRows = false;
            this.viewYourOrderDataGridView.AllowUserToDeleteRows = false;
            this.viewYourOrderDataGridView.AllowUserToResizeColumns = false;
            this.viewYourOrderDataGridView.AllowUserToResizeRows = false;
            this.viewYourOrderDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewYourOrderDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewYourOrderDataGridView.ColumnHeadersHeight = 30;
            this.viewYourOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.viewYourOrderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_zakupu,
            this.nazwa_produktu,
            this.ilosc_sztuk,
            this.cena_zakupu,
            this.data_zakupu,
            this.zdjecie});
            this.viewYourOrderDataGridView.GridColor = System.Drawing.SystemColors.ControlLight;
            this.viewYourOrderDataGridView.Location = new System.Drawing.Point(17, 12);
            this.viewYourOrderDataGridView.Name = "viewYourOrderDataGridView";
            this.viewYourOrderDataGridView.ReadOnly = true;
            this.viewYourOrderDataGridView.RowHeadersVisible = false;
            this.viewYourOrderDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.viewYourOrderDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.viewYourOrderDataGridView.RowTemplate.Height = 100;
            this.viewYourOrderDataGridView.Size = new System.Drawing.Size(957, 466);
            this.viewYourOrderDataGridView.TabIndex = 0;
            // 
            // Id_zakupu
            // 
            this.Id_zakupu.DataPropertyName = "Id_kupionego_produktu";
            this.Id_zakupu.HeaderText = "Id zakupu";
            this.Id_zakupu.Name = "Id_zakupu";
            this.Id_zakupu.ReadOnly = true;
            this.Id_zakupu.Visible = false;
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
            this.ilosc_sztuk.Width = 150;
            // 
            // cena_zakupu
            // 
            this.cena_zakupu.DataPropertyName = "Cena_zakupu";
            this.cena_zakupu.HeaderText = "Cena zakupu";
            this.cena_zakupu.Name = "cena_zakupu";
            this.cena_zakupu.ReadOnly = true;
            this.cena_zakupu.Width = 150;
            // 
            // data_zakupu
            // 
            this.data_zakupu.DataPropertyName = "Data_zakupu";
            this.data_zakupu.HeaderText = "Data zakupu";
            this.data_zakupu.Name = "data_zakupu";
            this.data_zakupu.ReadOnly = true;
            this.data_zakupu.Width = 150;
            // 
            // zdjecie
            // 
            this.zdjecie.DataPropertyName = "Photo";
            this.zdjecie.HeaderText = "Zdjęcie";
            this.zdjecie.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.zdjecie.Name = "zdjecie";
            this.zdjecie.ReadOnly = true;
            this.zdjecie.Width = 150;
            // 
            // Lista_Zakupow_Klienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(986, 529);
            this.Controls.Add(this.viewYourOrderDataGridView);
            this.Controls.Add(this.moneySpentLabel);
            this.Controls.Add(this.cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lista_Zakupow_Klienta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Twoja lista zakupów";
            this.Load += new System.EventHandler(this.Lista_Zakupow_Klienta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewYourOrderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label moneySpentLabel;
        private System.Windows.Forms.DataGridView viewYourOrderDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_zakupu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazwa_produktu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ilosc_sztuk;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena_zakupu;
        private System.Windows.Forms.DataGridViewTextBoxColumn data_zakupu;
        private System.Windows.Forms.DataGridViewImageColumn zdjecie;
    }
}