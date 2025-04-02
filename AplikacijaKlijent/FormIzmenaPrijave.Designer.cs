namespace AplikacijaKlijent
{
    partial class FormIzmenaPrijave
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIzmenaPrijave));
            listBoxDrzaveEU = new ListBox();
            buttonIzmeniPrijavu = new Button();
            dateTimePickerDatumIzlaska = new DateTimePicker();
            dateTimePickerDatumUlaska = new DateTimePicker();
            comboBoxNacinPrevoza = new ComboBox();
            labelDrzave = new Label();
            labelNacinPrevoza = new Label();
            labelDatumIzlaska = new Label();
            labelDatumUlaska = new Label();
            SuspendLayout();
            // 
            // listBoxDrzaveEU
            // 
            listBoxDrzaveEU.FormattingEnabled = true;
            listBoxDrzaveEU.ItemHeight = 15;
            listBoxDrzaveEU.Location = new Point(202, 44);
            listBoxDrzaveEU.Name = "listBoxDrzaveEU";
            listBoxDrzaveEU.SelectionMode = SelectionMode.MultiSimple;
            listBoxDrzaveEU.Size = new Size(112, 109);
            listBoxDrzaveEU.Sorted = true;
            listBoxDrzaveEU.TabIndex = 26;
            // 
            // buttonIzmeniPrijavu
            // 
            buttonIzmeniPrijavu.Cursor = Cursors.Hand;
            buttonIzmeniPrijavu.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIzmeniPrijavu.Location = new Point(69, 343);
            buttonIzmeniPrijavu.Name = "buttonIzmeniPrijavu";
            buttonIzmeniPrijavu.Size = new Size(138, 30);
            buttonIzmeniPrijavu.TabIndex = 25;
            buttonIzmeniPrijavu.Text = "Измени пријаву";
            buttonIzmeniPrijavu.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDatumIzlaska
            // 
            dateTimePickerDatumIzlaska.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumIzlaska.Location = new Point(203, 265);
            dateTimePickerDatumIzlaska.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dateTimePickerDatumIzlaska.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerDatumIzlaska.Name = "dateTimePickerDatumIzlaska";
            dateTimePickerDatumIzlaska.Size = new Size(111, 23);
            dateTimePickerDatumIzlaska.TabIndex = 24;
            // 
            // dateTimePickerDatumUlaska
            // 
            dateTimePickerDatumUlaska.Format = DateTimePickerFormat.Short;
            dateTimePickerDatumUlaska.Location = new Point(202, 232);
            dateTimePickerDatumUlaska.MaxDate = new DateTime(2040, 12, 31, 0, 0, 0, 0);
            dateTimePickerDatumUlaska.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePickerDatumUlaska.Name = "dateTimePickerDatumUlaska";
            dateTimePickerDatumUlaska.Size = new Size(111, 23);
            dateTimePickerDatumUlaska.TabIndex = 23;
            // 
            // comboBoxNacinPrevoza
            // 
            comboBoxNacinPrevoza.BackColor = SystemColors.Control;
            comboBoxNacinPrevoza.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxNacinPrevoza.FormattingEnabled = true;
            comboBoxNacinPrevoza.Location = new Point(202, 183);
            comboBoxNacinPrevoza.Name = "comboBoxNacinPrevoza";
            comboBoxNacinPrevoza.Size = new Size(163, 23);
            comboBoxNacinPrevoza.TabIndex = 22;
            // 
            // labelDrzave
            // 
            labelDrzave.AutoSize = true;
            labelDrzave.Font = new Font("Segoe UI", 9.75F);
            labelDrzave.Location = new Point(69, 44);
            labelDrzave.Name = "labelDrzave";
            labelDrzave.Size = new Size(70, 17);
            labelDrzave.TabIndex = 18;
            labelDrzave.Text = "Држава/е:";
            // 
            // labelNacinPrevoza
            // 
            labelNacinPrevoza.AutoSize = true;
            labelNacinPrevoza.Font = new Font("Segoe UI", 9.75F);
            labelNacinPrevoza.Location = new Point(69, 184);
            labelNacinPrevoza.Name = "labelNacinPrevoza";
            labelNacinPrevoza.Size = new Size(102, 17);
            labelNacinPrevoza.TabIndex = 19;
            labelNacinPrevoza.Text = "Начин превоза:";
            // 
            // labelDatumIzlaska
            // 
            labelDatumIzlaska.AutoSize = true;
            labelDatumIzlaska.Font = new Font("Segoe UI", 9.75F);
            labelDatumIzlaska.Location = new Point(69, 269);
            labelDatumIzlaska.Name = "labelDatumIzlaska";
            labelDatumIzlaska.Size = new Size(97, 17);
            labelDatumIzlaska.TabIndex = 21;
            labelDatumIzlaska.Text = "Датум изласка:";
            // 
            // labelDatumUlaska
            // 
            labelDatumUlaska.AutoSize = true;
            labelDatumUlaska.Font = new Font("Segoe UI", 9.75F);
            labelDatumUlaska.Location = new Point(69, 236);
            labelDatumUlaska.Name = "labelDatumUlaska";
            labelDatumUlaska.Size = new Size(90, 17);
            labelDatumUlaska.TabIndex = 20;
            labelDatumUlaska.Text = "Датум уласка:";
            // 
            // FormIzmenaPrijave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 416);
            Controls.Add(listBoxDrzaveEU);
            Controls.Add(buttonIzmeniPrijavu);
            Controls.Add(dateTimePickerDatumIzlaska);
            Controls.Add(dateTimePickerDatumUlaska);
            Controls.Add(comboBoxNacinPrevoza);
            Controls.Add(labelDrzave);
            Controls.Add(labelNacinPrevoza);
            Controls.Add(labelDatumIzlaska);
            Controls.Add(labelDatumUlaska);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(455, 455);
            MinimumSize = new Size(455, 455);
            Name = "FormIzmenaPrijave";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Измена пријаве";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxDrzaveEU;
        private Button buttonIzmeniPrijavu;
        private DateTimePicker dateTimePickerDatumIzlaska;
        private DateTimePicker dateTimePickerDatumUlaska;
        private ComboBox comboBoxNacinPrevoza;
        private Label labelDrzave;
        private Label labelNacinPrevoza;
        private Label labelDatumIzlaska;
        private Label labelDatumUlaska;
    }
}