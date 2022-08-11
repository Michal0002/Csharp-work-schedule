namespace MichałKasperek_Z2_Zaliczenie
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_dodaj = new System.Windows.Forms.Button();
            this.button_usuń = new System.Windows.Forms.Button();
            this.button_edytuj = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_plan = new System.Windows.Forms.Button();
            this.button_zaplanuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dodaj
            // 
            this.button_dodaj.Location = new System.Drawing.Point(12, 490);
            this.button_dodaj.Name = "button_dodaj";
            this.button_dodaj.Size = new System.Drawing.Size(390, 48);
            this.button_dodaj.TabIndex = 5;
            this.button_dodaj.Text = "Dodaj pracownika";
            this.button_dodaj.UseVisualStyleBackColor = true;
            this.button_dodaj.Click += new System.EventHandler(this.button_dodaj_Click);
            // 
            // button_usuń
            // 
            this.button_usuń.Location = new System.Drawing.Point(408, 490);
            this.button_usuń.Name = "button_usuń";
            this.button_usuń.Size = new System.Drawing.Size(44, 48);
            this.button_usuń.TabIndex = 7;
            this.button_usuń.Text = "Usuń";
            this.button_usuń.UseVisualStyleBackColor = true;
            this.button_usuń.Click += new System.EventHandler(this.button_usuń_Click);
            // 
            // button_edytuj
            // 
            this.button_edytuj.Location = new System.Drawing.Point(458, 490);
            this.button_edytuj.Name = "button_edytuj";
            this.button_edytuj.Size = new System.Drawing.Size(390, 48);
            this.button_edytuj.TabIndex = 6;
            this.button_edytuj.Text = "Edytuj dane pracownika";
            this.button_edytuj.UseVisualStyleBackColor = true;
            this.button_edytuj.Click += new System.EventHandler(this.button_edytuj_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(836, 395);
            this.dataGridView1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nazwisko";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data urodzenia";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adres";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Urząd skarbowy";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Rozpoczęcie pracy";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Stawka [h]";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Telefon";
            this.Column8.Name = "Column8";
            // 
            // button_plan
            // 
            this.button_plan.Location = new System.Drawing.Point(13, 439);
            this.button_plan.Name = "button_plan";
            this.button_plan.Size = new System.Drawing.Size(836, 45);
            this.button_plan.TabIndex = 9;
            this.button_plan.Text = "Grafik pracy";
            this.button_plan.UseVisualStyleBackColor = true;
            this.button_plan.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_zaplanuj
            // 
            this.button_zaplanuj.Location = new System.Drawing.Point(12, 407);
            this.button_zaplanuj.Name = "button_zaplanuj";
            this.button_zaplanuj.Size = new System.Drawing.Size(836, 26);
            this.button_zaplanuj.TabIndex = 10;
            this.button_zaplanuj.Text = "Zaplanuj dni";
            this.button_zaplanuj.UseVisualStyleBackColor = true;
            this.button_zaplanuj.Click += new System.EventHandler(this.button_zaplanuj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 548);
            this.Controls.Add(this.button_zaplanuj);
            this.Controls.Add(this.button_plan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_dodaj);
            this.Controls.Add(this.button_usuń);
            this.Controls.Add(this.button_edytuj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_dodaj;
        private System.Windows.Forms.Button button_usuń;
        private System.Windows.Forms.Button button_edytuj;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button button_plan;
        private System.Windows.Forms.Button button_zaplanuj;
    }
}

