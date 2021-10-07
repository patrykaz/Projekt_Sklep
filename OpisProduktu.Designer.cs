namespace Projekt_Sklep
{
    partial class OpisProduktu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OpisProduktu));
            this.nazwaProduktuLabel = new System.Windows.Forms.Label();
            this.opisProduktuLabel = new System.Windows.Forms.Label();
            this.opisProduktuGroupBox = new System.Windows.Forms.GroupBox();
            this.cenaNettoLabel = new System.Windows.Forms.Label();
            this.cenaBruttoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buyItButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.iloscSztukLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.refreshDataButton = new System.Windows.Forms.Button();
            this.oknoObrazupanel = new System.Windows.Forms.Panel();
            this.opisProduktuGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.oknoObrazupanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // nazwaProduktuLabel
            // 
            this.nazwaProduktuLabel.AutoSize = true;
            this.nazwaProduktuLabel.Font = new System.Drawing.Font("Rockwell", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwaProduktuLabel.Location = new System.Drawing.Point(12, 9);
            this.nazwaProduktuLabel.Name = "nazwaProduktuLabel";
            this.nazwaProduktuLabel.Size = new System.Drawing.Size(244, 36);
            this.nazwaProduktuLabel.TabIndex = 0;
            this.nazwaProduktuLabel.Text = "Nazwa Produktu";
            // 
            // opisProduktuLabel
            // 
            this.opisProduktuLabel.AutoSize = true;
            this.opisProduktuLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisProduktuLabel.Location = new System.Drawing.Point(6, 36);
            this.opisProduktuLabel.Name = "opisProduktuLabel";
            this.opisProduktuLabel.Size = new System.Drawing.Size(46, 19);
            this.opisProduktuLabel.TabIndex = 0;
            this.opisProduktuLabel.Text = "opis...";
            // 
            // opisProduktuGroupBox
            // 
            this.opisProduktuGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.opisProduktuGroupBox.Controls.Add(this.opisProduktuLabel);
            this.opisProduktuGroupBox.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.opisProduktuGroupBox.Location = new System.Drawing.Point(19, 58);
            this.opisProduktuGroupBox.Name = "opisProduktuGroupBox";
            this.opisProduktuGroupBox.Size = new System.Drawing.Size(319, 127);
            this.opisProduktuGroupBox.TabIndex = 1;
            this.opisProduktuGroupBox.TabStop = false;
            this.opisProduktuGroupBox.Text = "Opis produktu";
            // 
            // cenaNettoLabel
            // 
            this.cenaNettoLabel.AutoSize = true;
            this.cenaNettoLabel.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaNettoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cenaNettoLabel.Location = new System.Drawing.Point(377, 293);
            this.cenaNettoLabel.Name = "cenaNettoLabel";
            this.cenaNettoLabel.Size = new System.Drawing.Size(138, 30);
            this.cenaNettoLabel.TabIndex = 6;
            this.cenaNettoLabel.Text = "Cena netto";
            // 
            // cenaBruttoLabel
            // 
            this.cenaBruttoLabel.AutoSize = true;
            this.cenaBruttoLabel.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cenaBruttoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cenaBruttoLabel.Location = new System.Drawing.Point(385, 333);
            this.cenaBruttoLabel.Name = "cenaBruttoLabel";
            this.cenaBruttoLabel.Size = new System.Drawing.Size(197, 41);
            this.cenaBruttoLabel.TabIndex = 8;
            this.cenaBruttoLabel.Text = "Cena brutto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(225, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cena netto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(173, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cena brutto:";
            // 
            // buyItButton
            // 
            this.buyItButton.BackColor = System.Drawing.Color.Moccasin;
            this.buyItButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.buyItButton.FlatAppearance.BorderSize = 3;
            this.buyItButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buyItButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buyItButton.Location = new System.Drawing.Point(197, 389);
            this.buyItButton.Name = "buyItButton";
            this.buyItButton.Size = new System.Drawing.Size(108, 31);
            this.buyItButton.TabIndex = 9;
            this.buyItButton.Text = "Kup teraz";
            this.buyItButton.UseVisualStyleBackColor = false;
            this.buyItButton.Click += new System.EventHandler(this.buyItButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Moccasin;
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.backButton.FlatAppearance.BorderSize = 3;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.backButton.Location = new System.Drawing.Point(425, 389);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(108, 31);
            this.backButton.TabIndex = 11;
            this.backButton.Text = "Wróć";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(24, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ilość sztuk:";
            // 
            // iloscSztukLabel
            // 
            this.iloscSztukLabel.AutoSize = true;
            this.iloscSztukLabel.Font = new System.Drawing.Font("Rockwell", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscSztukLabel.Location = new System.Drawing.Point(161, 198);
            this.iloscSztukLabel.Name = "iloscSztukLabel";
            this.iloscSztukLabel.Size = new System.Drawing.Size(80, 26);
            this.iloscSztukLabel.TabIndex = 4;
            this.iloscSztukLabel.Text = "ilośc...";
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.photoPictureBox.Location = new System.Drawing.Point(-1, -1);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(295, 219);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 21;
            this.photoPictureBox.TabStop = false;
            // 
            // refreshDataButton
            // 
            this.refreshDataButton.BackColor = System.Drawing.Color.Moccasin;
            this.refreshDataButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.refreshDataButton.FlatAppearance.BorderSize = 3;
            this.refreshDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshDataButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.refreshDataButton.Location = new System.Drawing.Point(311, 389);
            this.refreshDataButton.Name = "refreshDataButton";
            this.refreshDataButton.Size = new System.Drawing.Size(108, 31);
            this.refreshDataButton.TabIndex = 10;
            this.refreshDataButton.Text = "Odświerz";
            this.refreshDataButton.UseVisualStyleBackColor = false;
            this.refreshDataButton.Click += new System.EventHandler(this.refreshDataButton_Click);
            // 
            // oknoObrazupanel
            // 
            this.oknoObrazupanel.BackColor = System.Drawing.SystemColors.Control;
            this.oknoObrazupanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oknoObrazupanel.Controls.Add(this.photoPictureBox);
            this.oknoObrazupanel.Location = new System.Drawing.Point(372, 58);
            this.oknoObrazupanel.Name = "oknoObrazupanel";
            this.oknoObrazupanel.Size = new System.Drawing.Size(295, 219);
            this.oknoObrazupanel.TabIndex = 2;
            // 
            // OpisProduktu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(695, 455);
            this.Controls.Add(this.oknoObrazupanel);
            this.Controls.Add(this.refreshDataButton);
            this.Controls.Add(this.iloscSztukLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.buyItButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cenaBruttoLabel);
            this.Controls.Add(this.cenaNettoLabel);
            this.Controls.Add(this.opisProduktuGroupBox);
            this.Controls.Add(this.nazwaProduktuLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OpisProduktu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opis produktu";
            this.Load += new System.EventHandler(this.OpisProduktu_Load);
            this.opisProduktuGroupBox.ResumeLayout(false);
            this.opisProduktuGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.oknoObrazupanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwaProduktuLabel;
        private System.Windows.Forms.Label opisProduktuLabel;
        private System.Windows.Forms.GroupBox opisProduktuGroupBox;
        private System.Windows.Forms.Label cenaNettoLabel;
        private System.Windows.Forms.Label cenaBruttoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buyItButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label iloscSztukLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.Button refreshDataButton;
        private System.Windows.Forms.Panel oknoObrazupanel;
    }
}