namespace MichałKasperek_Z2_Zaliczenie
{
    partial class FormPlan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_godzinyprzepracowania = new System.Windows.Forms.ComboBox();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_pracownik = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_godziny = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_wstaw = new System.Windows.Forms.Button();
            this.button_usuń = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_godziny)).BeginInit();
            this.SuspendLayout();
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
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column2,
            this.Column6});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Imię i nazwisko pracownika";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Data";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Il. godzin do przepracowania";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Il. przepracowanych godzin";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nadgodziny";
            this.Column7.Name = "Column7";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Stawka pracownika";
            this.Column2.Name = "Column2";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Należność";
            this.Column6.Name = "Column6";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 177);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plan";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_godzinyprzepracowania);
            this.groupBox2.Controls.Add(this.comboBox_data);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox_pracownik);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numericUpDown_godziny);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 135);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dane";
            // 
            // comboBox_godzinyprzepracowania
            // 
            this.comboBox_godzinyprzepracowania.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_godzinyprzepracowania.FormattingEnabled = true;
            this.comboBox_godzinyprzepracowania.Location = new System.Drawing.Point(171, 77);
            this.comboBox_godzinyprzepracowania.Name = "comboBox_godzinyprzepracowania";
            this.comboBox_godzinyprzepracowania.Size = new System.Drawing.Size(58, 21);
            this.comboBox_godzinyprzepracowania.TabIndex = 11;
            // 
            // comboBox_data
            // 
            this.comboBox_data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Location = new System.Drawing.Point(45, 53);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(121, 21);
            this.comboBox_data.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Data:";
            // 
            // comboBox_pracownik
            // 
            this.comboBox_pracownik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_pracownik.FormattingEnabled = true;
            this.comboBox_pracownik.Location = new System.Drawing.Point(72, 23);
            this.comboBox_pracownik.Name = "comboBox_pracownik";
            this.comboBox_pracownik.Size = new System.Drawing.Size(121, 21);
            this.comboBox_pracownik.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Przepracowane godziny:";
            // 
            // numericUpDown_godziny
            // 
            this.numericUpDown_godziny.Location = new System.Drawing.Point(134, 105);
            this.numericUpDown_godziny.Name = "numericUpDown_godziny";
            this.numericUpDown_godziny.Size = new System.Drawing.Size(59, 20);
            this.numericUpDown_godziny.TabIndex = 8;
            this.numericUpDown_godziny.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ilość godzin do przepracowania:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pracownik:";
            // 
            // button_wstaw
            // 
            this.button_wstaw.Location = new System.Drawing.Point(264, 199);
            this.button_wstaw.Name = "button_wstaw";
            this.button_wstaw.Size = new System.Drawing.Size(304, 65);
            this.button_wstaw.TabIndex = 3;
            this.button_wstaw.Text = "Wstaw";
            this.button_wstaw.UseVisualStyleBackColor = true;
            this.button_wstaw.Click += new System.EventHandler(this.button_wstaw_Click);
            // 
            // button_usuń
            // 
            this.button_usuń.Location = new System.Drawing.Point(264, 265);
            this.button_usuń.Name = "button_usuń";
            this.button_usuń.Size = new System.Drawing.Size(304, 65);
            this.button_usuń.TabIndex = 4;
            this.button_usuń.Text = "Usuń";
            this.button_usuń.UseVisualStyleBackColor = true;
            this.button_usuń.Click += new System.EventHandler(this.button_usuń_Click);
            // 
            // FormPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 335);
            this.Controls.Add(this.button_usuń);
            this.Controls.Add(this.button_wstaw);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormPlan";
            this.Text = "FormGrafik";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlan_FormClosing);
            this.Load += new System.EventHandler(this.FormPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_godziny)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_pracownik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_godziny;
        private System.Windows.Forms.Button button_wstaw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_usuń;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.ComboBox comboBox_godzinyprzepracowania;
    }
}