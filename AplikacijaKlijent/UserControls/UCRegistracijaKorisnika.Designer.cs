namespace AplikacijaKlijent.UserControls
{
    partial class UCRegistracijaKorisnika
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxIme = new TextBox();
            textBoxPrezime = new TextBox();
            label2 = new Label();
            textBoxBrPasosa = new TextBox();
            label3 = new Label();
            textBoxJmbg = new TextBox();
            label4 = new Label();
            textBoxEmail = new TextBox();
            label5 = new Label();
            textBoxPassword = new TextBox();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            labelUsername = new Label();
            buttonRegistracija = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 54);
            label1.Name = "label1";
            label1.Size = new Size(37, 17);
            label1.TabIndex = 0;
            label1.Text = "Име:";
            // 
            // textBoxIme
            // 
            textBoxIme.CharacterCasing = CharacterCasing.Upper;
            textBoxIme.Cursor = Cursors.IBeam;
            textBoxIme.Location = new Point(153, 53);
            textBoxIme.MaxLength = 50;
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(100, 23);
            textBoxIme.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.CharacterCasing = CharacterCasing.Upper;
            textBoxPrezime.Cursor = Cursors.IBeam;
            textBoxPrezime.Location = new Point(153, 101);
            textBoxPrezime.MaxLength = 50;
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(100, 23);
            textBoxPrezime.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 102);
            label2.Name = "label2";
            label2.Size = new Size(64, 17);
            label2.TabIndex = 2;
            label2.Text = "Презиме:";
            // 
            // textBoxBrPasosa
            // 
            textBoxBrPasosa.Cursor = Cursors.IBeam;
            textBoxBrPasosa.Location = new Point(386, 102);
            textBoxBrPasosa.MaxLength = 9;
            textBoxBrPasosa.Name = "textBoxBrPasosa";
            textBoxBrPasosa.Size = new Size(100, 23);
            textBoxBrPasosa.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(300, 102);
            label3.Name = "label3";
            label3.Size = new Size(79, 17);
            label3.TabIndex = 6;
            label3.Text = "Бр. пасоша:";
            // 
            // textBoxJmbg
            // 
            textBoxJmbg.Cursor = Cursors.IBeam;
            textBoxJmbg.Location = new Point(386, 53);
            textBoxJmbg.MaxLength = 13;
            textBoxJmbg.Name = "textBoxJmbg";
            textBoxJmbg.Size = new Size(100, 23);
            textBoxJmbg.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(300, 54);
            label4.Name = "label4";
            label4.Size = new Size(41, 17);
            label4.TabIndex = 4;
            label4.Text = "ЈМБГ:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Cursor = Cursors.IBeam;
            textBoxEmail.Location = new Point(272, 206);
            textBoxEmail.MaxLength = 50;
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(148, 23);
            textBoxEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(141, 207);
            label5.Name = "label5";
            label5.Size = new Size(53, 17);
            label5.TabIndex = 8;
            label5.Text = "Е-маил:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Location = new Point(272, 306);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(148, 23);
            textBoxPassword.TabIndex = 11;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Cursor = Cursors.Help;
            labelPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPassword.Location = new Point(141, 307);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(55, 17);
            labelPassword.TabIndex = 10;
            labelPassword.Text = "Шифра:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Location = new Point(272, 257);
            textBoxUsername.MaxLength = 50;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(148, 23);
            textBoxUsername.TabIndex = 13;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Cursor = Cursors.Help;
            labelUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsername.Location = new Point(141, 257);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(110, 17);
            labelUsername.TabIndex = 12;
            labelUsername.Text = "Корисничко име:";
            // 
            // buttonRegistracija
            // 
            buttonRegistracija.Cursor = Cursors.Hand;
            buttonRegistracija.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonRegistracija.Location = new Point(272, 464);
            buttonRegistracija.Name = "buttonRegistracija";
            buttonRegistracija.Size = new Size(148, 30);
            buttonRegistracija.TabIndex = 14;
            buttonRegistracija.Text = "Региструјте се";
            buttonRegistracija.UseVisualStyleBackColor = true;
            // 
            // UCRegistracijaKorisnika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonRegistracija);
            Controls.Add(textBoxUsername);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxEmail);
            Controls.Add(label5);
            Controls.Add(textBoxBrPasosa);
            Controls.Add(label3);
            Controls.Add(textBoxJmbg);
            Controls.Add(label4);
            Controls.Add(textBoxPrezime);
            Controls.Add(label2);
            Controls.Add(textBoxIme);
            Controls.Add(label1);
            Name = "UCRegistracijaKorisnika";
            Size = new Size(564, 568);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxIme;
        private TextBox textBoxPrezime;
        private Label label2;
        private TextBox textBoxBrPasosa;
        private Label label3;
        private TextBox textBoxJmbg;
        private Label label4;
        private TextBox textBoxEmail;
        private Label label5;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private Label labelUsername;
        private Button buttonRegistracija;
    }
}
