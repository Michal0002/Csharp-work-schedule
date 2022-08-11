using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichałKasperek_Z2_Zaliczenie
{
    public partial class FormPlanowanie : Form
    {

        public FormPlanowanie()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Plan_pracy p = new Plan_pracy();
            p.Zaplanowane_godziny = (int)numericUpDown_godziny.Value;
            p.MiesiacDzien = dateTimePicker1.Value;

            Plan_pracy.Plan.Add(p);

            Odśwież_tabelkę();
        }
        void Odśwież_tabelkę() //dodawanie wierszy do tabelki
        {
            dataGridView1.Rows.Clear();
            foreach (Plan_pracy plan in Plan_pracy.Plan)
            {
                dataGridView1.Rows.Add(plan.MiesiacDzien.ToShortDateString(), plan.Zaplanowane_godziny);
            }

        }
        private void FormPlanowanie_Load(object sender, EventArgs e)
        {
            //Plan_pracy p = new Plan_pracy();
            //numericUpDown_godziny.Value = p.Zaplanowane_godziny;
            //dateTimePicker1.Value = p.MiesiacDzien;

            try
            {
                FileStream fs = new FileStream("planpracy.txt", FileMode.Open, access: FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                Plan_pracy.Plan = (List<Plan_pracy>)bf.Deserialize(fs);
                fs.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nie udało się wczytać danych z pliku");
            }

            Odśwież_tabelkę(); //wywołanie funkcji - wypelnianie tabelki wcześniejszymi danymi
        }

        private void FormPlanowanie_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileStream fs = new FileStream("planpracy.txt", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, Plan_pracy.Plan);


            fs.Close();
        }

        private void button_usuń_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentRow.Index; //przypisanie do zmiennej index obecnego wiersza po indeksie.
            dataGridView1.Rows.RemoveAt(index); //usuwanie wiersza z tabelki

            Plan_pracy.Plan.RemoveAt(index);

        }
    }
}
