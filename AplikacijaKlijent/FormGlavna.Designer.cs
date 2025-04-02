namespace AplikacijaKlijent
{
    partial class FormGlavna
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGlavna));
            panelLevi = new Panel();
            label3 = new Label();
            panelGlavniMeni = new Panel();
            glavniMeni = new MenuStrip();
            meniStavkaPrijavaPutovanja = new ToolStripMenuItem();
            meniStavkaPregledIIzmena = new ToolStripMenuItem();
            meniStavkaPrijavaKorisnika = new ToolStripMenuItem();
            meniStavkaRegistracija = new ToolStripMenuItem();
            meniStavkaOdjava = new ToolStripMenuItem();
            label2 = new Label();
            label1 = new Label();
            panelDesni = new Panel();
            labelPrijavljenKorisnik = new Label();
            panelLevi.SuspendLayout();
            panelGlavniMeni.SuspendLayout();
            glavniMeni.SuspendLayout();
            SuspendLayout();
            // 
            // panelLevi
            // 
            panelLevi.BackColor = SystemColors.Info;
            panelLevi.Controls.Add(labelPrijavljenKorisnik);
            panelLevi.Controls.Add(label3);
            panelLevi.Controls.Add(panelGlavniMeni);
            panelLevi.Controls.Add(label2);
            panelLevi.Controls.Add(label1);
            panelLevi.Dock = DockStyle.Left;
            panelLevi.Location = new Point(0, 0);
            panelLevi.Margin = new Padding(0);
            panelLevi.Name = "panelLevi";
            panelLevi.Size = new Size(365, 568);
            panelLevi.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Italic | FontStyle.Underline);
            label3.Location = new Point(17, 275);
            label3.Name = "label3";
            label3.Size = new Size(186, 19);
            label3.TabIndex = 3;
            label3.Text = "Изаберите жељену радњу:";
            // 
            // panelGlavniMeni
            // 
            panelGlavniMeni.BackColor = SystemColors.GradientInactiveCaption;
            panelGlavniMeni.Controls.Add(glavniMeni);
            panelGlavniMeni.Dock = DockStyle.Bottom;
            panelGlavniMeni.Location = new Point(0, 303);
            panelGlavniMeni.Margin = new Padding(0);
            panelGlavniMeni.Name = "panelGlavniMeni";
            panelGlavniMeni.Padding = new Padding(15, 20, 0, 0);
            panelGlavniMeni.Size = new Size(365, 265);
            panelGlavniMeni.TabIndex = 2;
            // 
            // glavniMeni
            // 
            glavniMeni.BackColor = SystemColors.GradientInactiveCaption;
            glavniMeni.Dock = DockStyle.Left;
            glavniMeni.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            glavniMeni.Items.AddRange(new ToolStripItem[] { meniStavkaPrijavaPutovanja, meniStavkaPregledIIzmena, meniStavkaPrijavaKorisnika, meniStavkaRegistracija, meniStavkaOdjava });
            glavniMeni.Location = new Point(15, 20);
            glavniMeni.Name = "glavniMeni";
            glavniMeni.Padding = new Padding(0);
            glavniMeni.Size = new Size(178, 245);
            glavniMeni.TabIndex = 0;
            glavniMeni.Text = "menuStrip1";
            // 
            // meniStavkaPrijavaPutovanja
            // 
            meniStavkaPrijavaPutovanja.BackColor = SystemColors.GradientInactiveCaption;
            meniStavkaPrijavaPutovanja.Font = new Font("Segoe UI", 9.75F);
            meniStavkaPrijavaPutovanja.Margin = new Padding(0, 0, 0, 15);
            meniStavkaPrijavaPutovanja.Name = "meniStavkaPrijavaPutovanja";
            meniStavkaPrijavaPutovanja.Size = new Size(177, 21);
            meniStavkaPrijavaPutovanja.Text = "Пријава путовања";
            meniStavkaPrijavaPutovanja.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meniStavkaPregledIIzmena
            // 
            meniStavkaPregledIIzmena.Font = new Font("Segoe UI", 9.75F);
            meniStavkaPregledIIzmena.Margin = new Padding(0, 0, 0, 15);
            meniStavkaPregledIIzmena.Name = "meniStavkaPregledIIzmena";
            meniStavkaPregledIIzmena.Size = new Size(177, 21);
            meniStavkaPregledIIzmena.Text = "Преглед и измена пријава";
            meniStavkaPregledIIzmena.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meniStavkaPrijavaKorisnika
            // 
            meniStavkaPrijavaKorisnika.Font = new Font("Segoe UI", 9.75F);
            meniStavkaPrijavaKorisnika.Margin = new Padding(0, 0, 0, 15);
            meniStavkaPrijavaKorisnika.Name = "meniStavkaPrijavaKorisnika";
            meniStavkaPrijavaKorisnika.Size = new Size(177, 21);
            meniStavkaPrijavaKorisnika.Text = "Пријава корисника";
            meniStavkaPrijavaKorisnika.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meniStavkaRegistracija
            // 
            meniStavkaRegistracija.Font = new Font("Segoe UI", 9.75F);
            meniStavkaRegistracija.Margin = new Padding(0, 0, 0, 15);
            meniStavkaRegistracija.Name = "meniStavkaRegistracija";
            meniStavkaRegistracija.Size = new Size(177, 21);
            meniStavkaRegistracija.Text = "Регистрација корисника";
            meniStavkaRegistracija.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meniStavkaOdjava
            // 
            meniStavkaOdjava.Font = new Font("Segoe UI", 9.75F);
            meniStavkaOdjava.Margin = new Padding(0, 0, 0, 15);
            meniStavkaOdjava.Name = "meniStavkaOdjava";
            meniStavkaOdjava.Size = new Size(177, 21);
            meniStavkaOdjava.Text = "Одјава корисника";
            meniStavkaOdjava.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(17, 48);
            label2.Name = "label2";
            label2.Size = new Size(350, 57);
            label2.TabIndex = 1;
            label2.Text = "Ово је званичан сервис за пријаву путовања у земље ЕУ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(17, 18);
            label1.Name = "label1";
            label1.Size = new Size(116, 21);
            label1.TabIndex = 0;
            label1.Text = "Добродошли,";
            // 
            // panelDesni
            // 
            panelDesni.Dock = DockStyle.Fill;
            panelDesni.Location = new Point(365, 0);
            panelDesni.Margin = new Padding(0);
            panelDesni.Name = "panelDesni";
            panelDesni.Size = new Size(564, 568);
            panelDesni.TabIndex = 1;
            // 
            // labelPrijavljenKorisnik
            // 
            labelPrijavljenKorisnik.AutoSize = true;
            labelPrijavljenKorisnik.ForeColor = Color.Blue;
            labelPrijavljenKorisnik.Location = new Point(17, 105);
            labelPrijavljenKorisnik.Name = "labelPrijavljenKorisnik";
            labelPrijavljenKorisnik.Size = new Size(38, 15);
            labelPrijavljenKorisnik.TabIndex = 4;
            labelPrijavljenKorisnik.Text = "label4";
            // 
            // FormGlavna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 568);
            Controls.Add(panelDesni);
            Controls.Add(panelLevi);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = glavniMeni;
            MaximumSize = new Size(945, 607);
            MinimumSize = new Size(945, 607);
            Name = "FormGlavna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сервис - Пријави пут за ЕУ";
            panelLevi.ResumeLayout(false);
            panelLevi.PerformLayout();
            panelGlavniMeni.ResumeLayout(false);
            panelGlavniMeni.PerformLayout();
            glavniMeni.ResumeLayout(false);
            glavniMeni.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLevi;
        private Panel panelDesni;
        private Label label2;
        private Label label1;
        private Panel panelGlavniMeni;
        private MenuStrip glavniMeni;
        private ToolStripMenuItem meniStavkaPrijavaPutovanja;
        private ToolStripMenuItem meniStavkaPregledIIzmena;
        private ToolStripMenuItem meniStavkaPrijavaKorisnika;
        private ToolStripMenuItem meniStavkaRegistracija;
        private ToolStripMenuItem meniStavkaOdjava;
        private Label label3;
        private Label labelPrijavljenKorisnik;
    }
}
