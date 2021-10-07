namespace Projekt_Sklep
{
    partial class Logowanie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logowanie));
            this.hasloTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.createNewAccountLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logInButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hasloTextBox
            // 
            this.hasloTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hasloTextBox.Location = new System.Drawing.Point(97, 52);
            this.hasloTextBox.Name = "hasloTextBox";
            this.hasloTextBox.PasswordChar = '*';
            this.hasloTextBox.Size = new System.Drawing.Size(100, 22);
            this.hasloTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.loginTextBox.Location = new System.Drawing.Point(97, 26);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(100, 22);
            this.loginTextBox.TabIndex = 1;
            // 
            // createNewAccountLabel
            // 
            this.createNewAccountLabel.AutoSize = true;
            this.createNewAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNewAccountLabel.Font = new System.Drawing.Font("Constantia", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.createNewAccountLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.createNewAccountLabel.Location = new System.Drawing.Point(127, 94);
            this.createNewAccountLabel.Name = "createNewAccountLabel";
            this.createNewAccountLabel.Size = new System.Drawing.Size(114, 14);
            this.createNewAccountLabel.TabIndex = 5;
            this.createNewAccountLabel.Text = "Stwórz nowe konto";
            this.createNewAccountLabel.Click += new System.EventHandler(this.createNewAccountLabel_Click);
            this.createNewAccountLabel.MouseEnter += new System.EventHandler(this.createNewAccountLabel_MouseEnter);
            this.createNewAccountLabel.MouseLeave += new System.EventHandler(this.createNewAccountLabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(47, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "hasło:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(48, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "login:";
            // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.Moccasin;
            this.logInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logInButton.FlatAppearance.BorderColor = System.Drawing.Color.MintCream;
            this.logInButton.FlatAppearance.BorderSize = 3;
            this.logInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logInButton.Font = new System.Drawing.Font("Rockwell", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.logInButton.Location = new System.Drawing.Point(32, 86);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(75, 31);
            this.logInButton.TabIndex = 4;
            this.logInButton.Text = "Zaloguj";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // Logowanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(258, 135);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.hasloTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.createNewAccountLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Logowanie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Logowanie_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox hasloTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label createNewAccountLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logInButton;
    }
}

