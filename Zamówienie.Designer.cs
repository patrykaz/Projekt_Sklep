namespace Projekt_Sklep
{
    partial class Zamówienie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zamówienie));
            this.nazwaProduktuLabel = new System.Windows.Forms.Label();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            this.iloscSztukBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderButton = new System.Windows.Forms.Button();
            this.sumaDoZaplatyLabel = new System.Windows.Forms.Label();
            this.cancelButoon = new System.Windows.Forms.Button();
            this.oknoObrazuPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloscSztukBox)).BeginInit();
            this.oknoObrazuPanel.SuspendLayout();
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
            // photoPictureBox
            // 
            this.photoPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.photoPictureBox.Location = new System.Drawing.Point(-1, -1);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(200, 166);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.photoPictureBox.TabIndex = 1;
            this.photoPictureBox.TabStop = false;
            // 
            // iloscSztukBox
            // 
            this.iloscSztukBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloscSztukBox.Location = new System.Drawing.Point(191, 249);
            this.iloscSztukBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iloscSztukBox.Name = "iloscSztukBox";
            this.iloscSztukBox.ReadOnly = true;
            this.iloscSztukBox.Size = new System.Drawing.Size(120, 22);
            this.iloscSztukBox.TabIndex = 3;
            this.iloscSztukBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iloscSztukBox.ValueChanged += new System.EventHandler(this.iloscSztukBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(111, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "ilość sztuk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(111, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "do zapłaty:";
            // 
            // orderButton
            // 
            this.orderButton.BackColor = System.Drawing.Color.Moccasin;
            this.orderButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.orderButton.FlatAppearance.BorderSize = 3;
            this.orderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.orderButton.Location = new System.Drawing.Point(138, 329);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(91, 33);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Zamawiam";
            this.orderButton.UseVisualStyleBackColor = false;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // sumaDoZaplatyLabel
            // 
            this.sumaDoZaplatyLabel.AutoSize = true;
            this.sumaDoZaplatyLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumaDoZaplatyLabel.Location = new System.Drawing.Point(186, 282);
            this.sumaDoZaplatyLabel.Name = "sumaDoZaplatyLabel";
            this.sumaDoZaplatyLabel.Size = new System.Drawing.Size(193, 29);
            this.sumaDoZaplatyLabel.TabIndex = 5;
            this.sumaDoZaplatyLabel.Text = "Kwota do zapłaty....";
            // 
            // cancelButoon
            // 
            this.cancelButoon.BackColor = System.Drawing.Color.Moccasin;
            this.cancelButoon.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.cancelButoon.FlatAppearance.BorderSize = 3;
            this.cancelButoon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButoon.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cancelButoon.Location = new System.Drawing.Point(235, 329);
            this.cancelButoon.Name = "cancelButoon";
            this.cancelButoon.Size = new System.Drawing.Size(91, 33);
            this.cancelButoon.TabIndex = 7;
            this.cancelButoon.Text = "Anuluj";
            this.cancelButoon.UseVisualStyleBackColor = false;
            this.cancelButoon.Click += new System.EventHandler(this.cancelButoon_Click);
            // 
            // oknoObrazuPanel
            // 
            this.oknoObrazuPanel.BackColor = System.Drawing.SystemColors.Control;
            this.oknoObrazuPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oknoObrazuPanel.Controls.Add(this.photoPictureBox);
            this.oknoObrazuPanel.Location = new System.Drawing.Point(138, 68);
            this.oknoObrazuPanel.Name = "oknoObrazuPanel";
            this.oknoObrazuPanel.Size = new System.Drawing.Size(200, 166);
            this.oknoObrazuPanel.TabIndex = 1;
            // 
            // Zamówienie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(477, 385);
            this.Controls.Add(this.oknoObrazuPanel);
            this.Controls.Add(this.cancelButoon);
            this.Controls.Add(this.sumaDoZaplatyLabel);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iloscSztukBox);
            this.Controls.Add(this.nazwaProduktuLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Zamówienie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zamówienie";
            this.Load += new System.EventHandler(this.Zamówienie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloscSztukBox)).EndInit();
            this.oknoObrazuPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nazwaProduktuLabel;
        private System.Windows.Forms.PictureBox photoPictureBox;
        private System.Windows.Forms.NumericUpDown iloscSztukBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Label sumaDoZaplatyLabel;
        private System.Windows.Forms.Button cancelButoon;
        private System.Windows.Forms.Panel oknoObrazuPanel;
    }
}