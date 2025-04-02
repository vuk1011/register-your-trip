namespace AplikacijaKlijent.UserControls
{
    partial class UCPrijavaPutovanja
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
            panelLicniPodaci = new Panel();
            textBoxBrPasosa = new TextBox();
            textBoxJmbg = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxIme = new TextBox();
            labelBrPasosa = new Label();
            labelJmbg = new Label();
            labelPrezime = new Label();
            labelIme = new Label();
            labelDatumIzlaska = new Label();
            labelDatumUlaska = new Label();
            labelNacinPrevoza = new Label();
            labelDrzave = new Label();
            comboBoxNacinPrevoza = new ComboBox();
            dateTimePickerDatumUlaska = new DateTimePicker();
            dateTimePickerDatumIzlaska = new DateTimePicker();
            buttonPodnesiPrijavu = new Button();
            listBoxDrzaveEU = new ListBox();
            panelLicniPodaci.SuspendLayout();
            SuspendLayout();
            // 
            // panelLicniPodaci
            // 
            panelLicniPodaci.BorderStyle = BorderStyle.FixedSingle;
            panelLicniPodaci.Controls.Add(textBoxBrPasosa);
            panelLicniPodaci.Controls.Add(textBoxJmbg);
            panelLicniPodaci.Controls.Add(textBoxPrezime);
            panelLicniPodaci.Controls.Add(textBoxIme);
            panelLicniPodaci.Controls.Add(labelBrPasosa);
            panelLicniPodaci.Controls.Add(labelJmbg);
            panelLicniPodaci.Controls.Add(labelPrezime);
            panelLicniPodaci.Controls.Add(labelIme);
            panelLicniPodaci.Location = new Point(3, 3);
            panelLicniPodaci.Name = "panelLicniPodaci";
            panelLicniPodaci.Size = new Size(558, 182);
            panelLicniPodaci.TabIndex = 0;
            // 
            // textBoxBrPasosa
            // 
            textBoxBrPasosa.BackColor = SystemColors.Control;
            textBoxBrPasosa.Cursor = Cursors.IBeam;
            textBoxBrPasosa.Location = new Point(385, 109);
            textBoxBrPasosa.MaxLength = 9;
            textBoxBrPasosa.Name = "textBoxBrPasosa";
            textBoxBrPasosa.Size = new Size(111, 23);
            textBoxBrPasosa.TabIndex = 7;
            // 
            // textBoxJmbg
            // 
            textBoxJmbg.BackColor = SystemColors.Control;
            textBoxJmbg.Cursor = Cursors.IBeam;
            textBoxJmbg.Location = new Point(385, 46);
            textBoxJmbg.MaxLength = 13;
            textBoxJmbg.Name = "textBoxJmbg";
            textBoxJmbg.Size = new Size(111, 23);
            textBoxJmbg.TabIndex = 6;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.BackColor = SystemColors.Control;
            textBoxPrezime.CharacterCasing = CharacterCasing.Upper;
            textBoxPrezime.Cursor = Cursors.IBeam;
            textBoxPrezime.Location = new Point(127, 109);
            textBoxPrezime.MaxLength = 50;
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(111, 23);
            textBoxPrezime.TabIndex = 5;
            // 
            // textBoxIme
            // 
            textBoxIme.BackColor = SystemColors.Control;
            textBoxIme.CharacterCasing = CharacterCasing.Upper;
            textBoxIme.Cursor = Cursors.IBeam;
            textBoxIme.Location = new Point(127, 46);
            textBoxIme.MaxLength = 50;
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(111, 23);
            textBoxIme.TabIndex = 4;
            // 
            // labelBrPasosa
            // 
            labelBrPasosa.AutoSize = true;
            labelBrPasosa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBrPasosa.Location = new Point(287, 107);
            labelBrPasosa.Name = "labelBrPasosa";
            labelBrPasosa.Size = new Size(92, 21);
            labelBrPasosa.TabIndex = 3;
            labelBrPasosa.Text = "Бр. пасоша:";
            // 
            // labelJmbg
            // 
            labelJmbg.AutoSize = true;
            labelJmbg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJmbg.Location = new Point(329, 44);
            labelJmbg.Name = "labelJmbg";
            labelJmbg.Size = new Size(50, 21);
            labelJmbg.TabIndex = 2;
            labelJmbg.Text = "ЈМБГ:";
            // 
            // labelPrezime
            // 
            labelPrezime.AutoSize = true;
            labelPrezime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPrezime.Location = new Point(45, 107);
            labelPrezime.Name = "labelPrezime";
            labelPrezime.Size = new Size(76, 21);
            labelPrezime.TabIndex = 1;
            labelPrezime.Text = "Презиме:";
            // 
            // labelIme
            // 
            labelIme.AutoSize = true;
            labelIme.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIme.Location = new Point(77, 44);
            labelIme.Name = "labelIme";
            labelIme.Size = new Size(44, 21);
            labelIme.TabIndex = 0;
            labelIme.Text = "Име:";
            // 
            // labelDatumIzlaska
            // 
            labelDatumIzlaska.AutoSize = true;
            labelDatumIzlaska.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDatumIzlaska.Location = new Point(145, 453);
            labelDatumIzlaska.Name = "labelDatumIzlaska";
            labelDatumIzlaska.Size = new Size(117, 21);
            labelDatumIzlaska.TabIndex = 11;
            labelDatumIzlaska.Text = "Датум изласка:";
            // 
            // labelDatumUlaska
            // 
            labelDatumUlaska.AutoSize = true;
            labelDatumUlaska.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDatumUlaska.Location = new Point(153, 416);
            labelDatumUlaska.Name = "labelDatumUlaska";
            labelDatumUlaska.Size = new Size(109, 21);
            labelDatumUlaska.TabIndex = 10;
            labelDatumUlaska.Text = "Датум уласка:";
            // 
            // labelNacinPrevoza
            // 
            labelNacinPrevoza.AutoSize = true;
            labelNacinPrevoza.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNacinPrevoza.Location = new Point(141, 362);
            labelNacinPrevoza.Name = "labelNacinPrevoza";
            labelNacinPrevoza.Size = new Size(121, 21);
            labelNacinPrevoza.TabIndex = 9;
            labelNacinPrevoza.Text = "Начин превоза:";
            // 
            // labelDrzave
            // 
            labelDrzave.AutoSize = true;
            labelDrzave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDrzave.Location = new Point(179, 225);
            labelDrzave.Name = "labelDrzave";
            labelDrzave.Size = new Size(83, 21);
            labelDrzave.TabIndex = 8;
            labelDrzave.Text = "Држава/е:";
            // 
            // comboBoxNacinPrevoza
            // 
            comboBoxNacinPrevoza.BackColor = SystemColors.Control;
            comboBoxNacinPrevoza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNacinPrevoza.FormattingEnabled = true;
            comboBoxNacinPrevoza.Location = new Point(268, 364);
            comboBoxNacinPrevoza.Name = "comboBoxNacinPrevoza";
            comboBoxNacinPrevoza.Size = new Size(163, 23);
            comboBoxNacinPrevoza.TabIndex = 13;
            // 
            // dateTimePickerDatumUlaska
            // 
            dateTimePickerDatumUlaska.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumUlaska.Location = new Point(268, 418);
            dateTimePickerDatumUlaska.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dateTimePickerDatumUlaska.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerDatumUlaska.Name = "dateTimePickerDatumUlaska";
            dateTimePickerDatumUlaska.Size = new Size(111, 23);
            dateTimePickerDatumUlaska.TabIndex = 14;
            // 
            // dateTimePickerDatumIzlaska
            // 
            dateTimePickerDatumIzlaska.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumIzlaska.Location = new Point(268, 455);
            dateTimePickerDatumIzlaska.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dateTimePickerDatumIzlaska.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerDatumIzlaska.Name = "dateTimePickerDatumIzlaska";
            dateTimePickerDatumIzlaska.Size = new Size(111, 23);
            dateTimePickerDatumIzlaska.TabIndex = 15;
            // 
            // buttonPodnesiPrijavu
            // 
            buttonPodnesiPrijavu.Cursor = Cursors.Hand;
            buttonPodnesiPrijavu.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPodnesiPrijavu.Location = new Point(190, 514);
            buttonPodnesiPrijavu.Name = "buttonPodnesiPrijavu";
            buttonPodnesiPrijavu.Size = new Size(185, 34);
            buttonPodnesiPrijavu.TabIndex = 16;
            buttonPodnesiPrijavu.Text = "Поднеси пријаву";
            buttonPodnesiPrijavu.UseVisualStyleBackColor = true;
            // 
            // listBoxDrzaveEU
            // 
            listBoxDrzaveEU.FormattingEnabled = true;
            listBoxDrzaveEU.ItemHeight = 15;
            listBoxDrzaveEU.Location = new Point(268, 225);
            listBoxDrzaveEU.Name = "listBoxDrzaveEU";
            listBoxDrzaveEU.SelectionMode = SelectionMode.MultiSimple;
            listBoxDrzaveEU.Size = new Size(112, 109);
            listBoxDrzaveEU.Sorted = true;
            listBoxDrzaveEU.TabIndex = 17;
            // 
            // UCPrijavaPutovanja
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBoxDrzaveEU);
            Controls.Add(buttonPodnesiPrijavu);
            Controls.Add(dateTimePickerDatumIzlaska);
            Controls.Add(dateTimePickerDatumUlaska);
            Controls.Add(comboBoxNacinPrevoza);
            Controls.Add(panelLicniPodaci);
            Controls.Add(labelDrzave);
            Controls.Add(labelNacinPrevoza);
            Controls.Add(labelDatumIzlaska);
            Controls.Add(labelDatumUlaska);
            Name = "UCPrijavaPutovanja";
            Size = new Size(564, 568);
            panelLicniPodaci.ResumeLayout(false);
            panelLicniPodaci.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelLicniPodaci;
        private Label labelBrPasosa;
        private Label labelJmbg;
        private Label labelPrezime;
        private Label labelIme;
        private TextBox textBoxIme;
        private TextBox textBoxBrPasosa;
        private TextBox textBoxJmbg;
        private TextBox textBoxPrezime;
        private Label labelDatumIzlaska;
        private Label labelDatumUlaska;
        private Label labelNacinPrevoza;
        private Label labelDrzave;
        private ComboBox comboBoxNacinPrevoza;
        private DateTimePicker dateTimePickerDatumUlaska;
        private DateTimePicker dateTimePickerDatumIzlaska;
        private Button buttonPodnesiPrijavu;
        private ListBox listBoxDrzaveEU;
    }
}
