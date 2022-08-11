namespace MichałKasperek_Z2_Zaliczenie
{
    partial class FormDodaj
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
            this.button_anuluj = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.textBox_imie = new System.Windows.Forms.TextBox();
            this.textBox_nazwisko = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_telefon = new System.Windows.Forms.TextBox();
            this.numericUpDown_stawka = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_datarozpoczecia = new System.Windows.Forms.DateTimePicker();
            this.textBox_urządskarbowy = new System.Windows.Forms.TextBox();
            this.textBox_adreszamieszkania = new System.Windows.Forms.TextBox();
            this.dateTimePicker_dataurodzenia = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stawka)).BeginInit();
            this.SuspendLayout();
            // 
            // button_anuluj
            // 
            this.button_anuluj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_anuluj.Location = new System.Drawing.Point(128, 286);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(236, 23);
            this.button_anuluj.TabIndex = 12;
            this.button_anuluj.Text = "Anuluj";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // button_ok
            // 
            this.button_ok.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_ok.Location = new System.Drawing.Point(12, 286);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(110, 23);
            this.button_ok.TabIndex = 11;
            this.button_ok.Text = "OK";
            this.button_ok.UseVisualStyleBackColor = true;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // textBox_imie
            // 
            this.textBox_imie.Location = new System.Drawing.Point(41, 23);
            this.textBox_imie.Name = "textBox_imie";
            this.textBox_imie.Size = new System.Drawing.Size(293, 20);
            this.textBox_imie.TabIndex = 9;
            // 
            // textBox_nazwisko
            // 
            this.textBox_nazwisko.Location = new System.Drawing.Point(68, 54);
            this.textBox_nazwisko.Name = "textBox_nazwisko";
            this.textBox_nazwisko.Size = new System.Drawing.Size(266, 20);
            this.textBox_nazwisko.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_telefon);
            this.groupBox1.Controls.Add(this.textBox_nazwisko);
            this.groupBox1.Controls.Add(this.numericUpDown_stawka);
            this.groupBox1.Controls.Add(this.dateTimePicker_datarozpoczecia);
            this.groupBox1.Controls.Add(this.textBox_urządskarbowy);
            this.groupBox1.Controls.Add(this.textBox_adreszamieszkania);
            this.groupBox1.Controls.Add(this.textBox_imie);
            this.groupBox1.Controls.Add(this.dateTimePicker_dataurodzenia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 268);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nowy pracownik";
            // 
            // textBox_telefon
            // 
            this.textBox_telefon.Location = new System.Drawing.Point(116, 240);
            this.textBox_telefon.Name = "textBox_telefon";
            this.textBox_telefon.Size = new System.Drawing.Size(218, 20);
            this.textBox_telefon.TabIndex = 15;
            // 
            // numericUpDown_stawka
            // 
            this.numericUpDown_stawka.Location = new System.Drawing.Point(161, 210);
            this.numericUpDown_stawka.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_stawka.Name = "numericUpDown_stawka";
            this.numericUpDown_stawka.Size = new System.Drawing.Size(72, 20);
            this.numericUpDown_stawka.TabIndex = 14;
            // 
            // dateTimePicker_datarozpoczecia
            // 
            this.dateTimePicker_datarozpoczecia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_datarozpoczecia.Location = new System.Drawing.Point(134, 175);
            this.dateTimePicker_datarozpoczecia.Name = "dateTimePicker_datarozpoczecia";
            this.dateTimePicker_datarozpoczecia.Size = new System.Drawing.Size(99, 20);
            this.dateTimePicker_datarozpoczecia.TabIndex = 13;
            // 
            // textBox_urządskarbowy
            // 
            this.textBox_urządskarbowy.Location = new System.Drawing.Point(98, 147);
            this.textBox_urządskarbowy.Name = "textBox_urządskarbowy";
            this.textBox_urządskarbowy.Size = new System.Drawing.Size(236, 20);
            this.textBox_urządskarbowy.TabIndex = 12;
            // 
            // textBox_adreszamieszkania
            // 
            this.textBox_adreszamieszkania.Location = new System.Drawing.Point(115, 116);
            this.textBox_adreszamieszkania.Name = "textBox_adreszamieszkania";
            this.textBox_adreszamieszkania.Size = new System.Drawing.Size(219, 20);
            this.textBox_adreszamieszkania.TabIndex = 11;
            // 
            // dateTimePicker_dataurodzenia
            // 
            this.dateTimePicker_dataurodzenia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_dataurodzenia.Location = new System.Drawing.Point(94, 82);
            this.dateTimePicker_dataurodzenia.Name = "dateTimePicker_dataurodzenia";
            this.dateTimePicker_dataurodzenia.Size = new System.Drawing.Size(139, 20);
            this.dateTimePicker_dataurodzenia.TabIndex = 10;
            this.dateTimePicker_dataurodzenia.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Telefon kontaktowy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Wysokość stawki godzinowej:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data rozpoczęcia pracy:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Urząd skarbowy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adres zamieszkania:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data urodzenia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nazwisko:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Imię:";
            // 
            // FormDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 326);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.button_ok);
            this.Name = "FormDodaj";
            this.Text = "FormDodaj";
            this.Load += new System.EventHandler(this.FormDodaj_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_stawka)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_anuluj;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.TextBox textBox_imie;
        private System.Windows.Forms.TextBox textBox_nazwisko;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_telefon;
        private System.Windows.Forms.NumericUpDown numericUpDown_stawka;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datarozpoczecia;
        private System.Windows.Forms.TextBox textBox_urządskarbowy;
        private System.Windows.Forms.TextBox textBox_adreszamieszkania;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dataurodzenia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}