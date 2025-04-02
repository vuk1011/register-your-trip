namespace AplikacijaKlijent.UserControls
{
    partial class UCPregledIIzmenaPrijava
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
            panelUnosJmbgPasos = new Panel();
            textBoxBrPasosa = new TextBox();
            textBoxJmbg = new TextBox();
            buttonPogledajPrijave = new Button();
            labelBrPasosa = new Label();
            labelJmbg = new Label();
            label1 = new Label();
            dataGridViewPrijave = new DataGridView();
            label2 = new Label();
            buttonIzmenaPrijave = new Button();
            buttonBrisanjePrijave = new Button();
            buttonGenerisanjePotvrde = new Button();
            panelUnosJmbgPasos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrijave).BeginInit();
            SuspendLayout();
            // 
            // panelUnosJmbgPasos
            // 
            panelUnosJmbgPasos.BorderStyle = BorderStyle.FixedSingle;
            panelUnosJmbgPasos.Controls.Add(textBoxBrPasosa);
            panelUnosJmbgPasos.Controls.Add(textBoxJmbg);
            panelUnosJmbgPasos.Controls.Add(buttonPogledajPrijave);
            panelUnosJmbgPasos.Controls.Add(labelBrPasosa);
            panelUnosJmbgPasos.Controls.Add(labelJmbg);
            panelUnosJmbgPasos.Controls.Add(label1);
            panelUnosJmbgPasos.Location = new Point(3, 3);
            panelUnosJmbgPasos.Name = "panelUnosJmbgPasos";
            panelUnosJmbgPasos.Size = new Size(558, 88);
            panelUnosJmbgPasos.TabIndex = 0;
            // 
            // textBoxBrPasosa
            // 
            textBoxBrPasosa.BackColor = SystemColors.Control;
            textBoxBrPasosa.Cursor = Cursors.IBeam;
            textBoxBrPasosa.Location = new Point(362, 41);
            textBoxBrPasosa.MaxLength = 9;
            textBoxBrPasosa.Name = "textBoxBrPasosa";
            textBoxBrPasosa.Size = new Size(111, 23);
            textBoxBrPasosa.TabIndex = 8;
            // 
            // textBoxJmbg
            // 
            textBoxJmbg.BackColor = SystemColors.Control;
            textBoxJmbg.Cursor = Cursors.IBeam;
            textBoxJmbg.Location = new Point(124, 41);
            textBoxJmbg.MaxLength = 13;
            textBoxJmbg.Name = "textBoxJmbg";
            textBoxJmbg.Size = new Size(111, 23);
            textBoxJmbg.TabIndex = 7;
            // 
            // buttonPogledajPrijave
            // 
            buttonPogledajPrijave.Cursor = Cursors.Hand;
            buttonPogledajPrijave.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPogledajPrijave.Location = new Point(434, 3);
            buttonPogledajPrijave.Name = "buttonPogledajPrijave";
            buttonPogledajPrijave.Size = new Size(119, 23);
            buttonPogledajPrijave.TabIndex = 1;
            buttonPogledajPrijave.Text = "Погледај пријаве";
            buttonPogledajPrijave.UseVisualStyleBackColor = true;
            // 
            // labelBrPasosa
            // 
            labelBrPasosa.AutoSize = true;
            labelBrPasosa.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBrPasosa.Location = new Point(264, 39);
            labelBrPasosa.Name = "labelBrPasosa";
            labelBrPasosa.Size = new Size(92, 21);
            labelBrPasosa.TabIndex = 2;
            labelBrPasosa.Text = "Бр. пасоша:";
            // 
            // labelJmbg
            // 
            labelJmbg.AutoSize = true;
            labelJmbg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelJmbg.Location = new Point(68, 39);
            labelJmbg.Name = "labelJmbg";
            labelJmbg.Size = new Size(50, 21);
            labelJmbg.TabIndex = 1;
            labelJmbg.Text = "ЈМБГ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(170, 20);
            label1.TabIndex = 0;
            label1.Text = "Ако нисте пријављени:";
            // 
            // dataGridViewPrijave
            // 
            dataGridViewPrijave.AllowUserToAddRows = false;
            dataGridViewPrijave.AllowUserToDeleteRows = false;
            dataGridViewPrijave.Location = new Point(3, 97);
            dataGridViewPrijave.MultiSelect = false;
            dataGridViewPrijave.Name = "dataGridViewPrijave";
            dataGridViewPrijave.ReadOnly = true;
            dataGridViewPrijave.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPrijave.Size = new Size(558, 266);
            dataGridViewPrijave.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 416);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 2;
            label2.Text = "Опције:";
            // 
            // buttonIzmenaPrijave
            // 
            buttonIzmenaPrijave.Cursor = Cursors.Hand;
            buttonIzmenaPrijave.Location = new Point(70, 436);
            buttonIzmenaPrijave.Name = "buttonIzmenaPrijave";
            buttonIzmenaPrijave.Size = new Size(131, 22);
            buttonIzmenaPrijave.TabIndex = 3;
            buttonIzmenaPrijave.Text = "Измените пријаву";
            buttonIzmenaPrijave.TextAlign = ContentAlignment.MiddleLeft;
            buttonIzmenaPrijave.UseVisualStyleBackColor = true;
            // 
            // buttonBrisanjePrijave
            // 
            buttonBrisanjePrijave.Cursor = Cursors.Hand;
            buttonBrisanjePrijave.Location = new Point(70, 464);
            buttonBrisanjePrijave.Name = "buttonBrisanjePrijave";
            buttonBrisanjePrijave.Size = new Size(131, 22);
            buttonBrisanjePrijave.TabIndex = 4;
            buttonBrisanjePrijave.Text = "Обришите пријаву";
            buttonBrisanjePrijave.TextAlign = ContentAlignment.MiddleLeft;
            buttonBrisanjePrijave.UseVisualStyleBackColor = true;
            // 
            // buttonGenerisanjePotvrde
            // 
            buttonGenerisanjePotvrde.Cursor = Cursors.Hand;
            buttonGenerisanjePotvrde.Location = new Point(70, 492);
            buttonGenerisanjePotvrde.Name = "buttonGenerisanjePotvrde";
            buttonGenerisanjePotvrde.Size = new Size(131, 22);
            buttonGenerisanjePotvrde.TabIndex = 5;
            buttonGenerisanjePotvrde.Text = "Генерисање потврде";
            buttonGenerisanjePotvrde.TextAlign = ContentAlignment.MiddleLeft;
            buttonGenerisanjePotvrde.UseVisualStyleBackColor = true;
            // 
            // UCPregledIIzmenaPrijava
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonGenerisanjePotvrde);
            Controls.Add(buttonBrisanjePrijave);
            Controls.Add(buttonIzmenaPrijave);
            Controls.Add(label2);
            Controls.Add(dataGridViewPrijave);
            Controls.Add(panelUnosJmbgPasos);
            Name = "UCPregledIIzmenaPrijava";
            Size = new Size(564, 568);
            panelUnosJmbgPasos.ResumeLayout(false);
            panelUnosJmbgPasos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPrijave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelUnosJmbgPasos;
        private Label label1;
        private Label labelJmbg;
        private Button buttonPogledajPrijave;
        private Label labelBrPasosa;
        private TextBox textBoxJmbg;
        private TextBox textBoxBrPasosa;
        private DataGridView dataGridViewPrijave;
        private Label label2;
        private Button buttonIzmenaPrijave;
        private Button buttonBrisanjePrijave;
        private Button buttonGenerisanjePotvrde;
    }
}
