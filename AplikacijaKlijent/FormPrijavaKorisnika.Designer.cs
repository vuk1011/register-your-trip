namespace AplikacijaKlijent
{
    partial class FormPrijavaKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrijavaKorisnika));
            labelUsername = new Label();
            labelPassword = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            buttonPrijaviSe = new Button();
            SuspendLayout();
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 9.75F);
            labelUsername.Location = new Point(51, 45);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(110, 17);
            labelUsername.TabIndex = 0;
            labelUsername.Text = "Корисничко име:";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 9.75F);
            labelPassword.Location = new Point(51, 95);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(55, 17);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "Шифра:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Cursor = Cursors.IBeam;
            textBoxUsername.Location = new Point(238, 44);
            textBoxUsername.MaxLength = 50;
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(151, 23);
            textBoxUsername.TabIndex = 2;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Cursor = Cursors.IBeam;
            textBoxPassword.Location = new Point(238, 94);
            textBoxPassword.MaxLength = 50;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(151, 23);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonPrijaviSe
            // 
            buttonPrijaviSe.Cursor = Cursors.Hand;
            buttonPrijaviSe.Location = new Point(238, 150);
            buttonPrijaviSe.Name = "buttonPrijaviSe";
            buttonPrijaviSe.Size = new Size(151, 23);
            buttonPrijaviSe.TabIndex = 4;
            buttonPrijaviSe.Text = "Пријави се";
            buttonPrijaviSe.UseVisualStyleBackColor = true;
            // 
            // FormPrijavaKorisnika
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(463, 236);
            Controls.Add(buttonPrijaviSe);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelPassword);
            Controls.Add(labelUsername);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(479, 275);
            MinimumSize = new Size(479, 275);
            Name = "FormPrijavaKorisnika";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Пријава корисника";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUsername;
        private Label labelPassword;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Button buttonPrijaviSe;
    }
}