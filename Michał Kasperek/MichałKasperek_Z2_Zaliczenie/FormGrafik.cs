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
    [Serializable]
    public partial class FormPlan : Form
    {
        Plan_pracy plan; //deklaracja zmiennej

        internal FormPlan(Plan_pracy plan)
        {
            InitializeComponent();
            this.plan = plan;
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            //Dodajemy mechaników z combobox. Przypisani mechanicy -> Form1
            foreach (Pracownik p in Pracownik.Lista_pracowników)
            {
                comboBox_pracownik.Items.Add(p); //dodawanie pracowników do cb
            }

            foreach (Plan_pracy planpracy in Plan_pracy.Plan) 
            {
                comboBox_data.Items.Add(planpracy.MiesiacDzien.ToShortDateString()); //dodawanie liczby możliwych dni do przepracowania
                comboBox_godzinyprzepracowania.Items.Add(planpracy.Zaplanowane_godziny);
            }
            //przypisanie
            comboBox_pracownik.SelectedItem = plan.Prac;
            numericUpDown_godziny.Value = plan.Zaplanowane_godziny;
            comboBox_godzinyprzepracowania.SelectedItem = plan.Liczba_przepracowanych;


        }
        private void FormPlan_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void button_wstaw_Click(object sender, EventArgs e)
        {
            try
            {
                //przypisujemy zmienne
                plan.Prac = (Pracownik)comboBox_pracownik.SelectedItem;
                plan.MiesiacDzien =Convert.ToDateTime(comboBox_data.SelectedItem);
                plan.Zaplanowane_godziny = Convert.ToInt32(comboBox_godzinyprzepracowania.SelectedItem);
                plan.Liczba_przepracowanych = Convert.ToInt32(numericUpDown_godziny.Value);


                if (plan.Liczba_przepracowanych > 8)
                {
                    plan.nadgodziny = "TAK";
                }
                else
                {
                    plan.nadgodziny = "NIE";
                }


                Odśwież_tabelkę();

                //po zaakceptowaniu czyścimy wszystko
                comboBox_pracownik.SelectedIndex = -1;
                comboBox_data.SelectedIndex = -1;
                numericUpDown_godziny.Value = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się dodać wpisu.\n" + ex.Message);
            }
            
                Plan_pracy.Plan.Add(plan);
        }
        void Odśwież_tabelkę() //dodawanie wierszy do tabelki
        {  
            comboBox_data.Items.RemoveAt(comboBox_data.SelectedIndex);
            comboBox_godzinyprzepracowania.Items.RemoveAt(comboBox_godzinyprzepracowania.SelectedIndex);
            //usuwamy wybrane wartości

            dataGridView1.Rows.Add(plan.Prac, plan.MiesiacDzien.ToShortDateString(), plan.Zaplanowane_godziny, plan.Liczba_przepracowanych, plan.nadgodziny, plan.Prac.Stawka_godz, plan.Należność);
        }
        private void button_usuń_Click(object sender, EventArgs e) //usuwanie wierszy
        {
            if (dataGridView1.SelectedRows.Count >= 1) 
            {
                DialogResult result = MessageBox.Show("Chcesz usunąć dane pracownika: " + dataGridView1.SelectedRows[0].Cells[0].Value + "? ", "Usuwanie", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    int index = dataGridView1.CurrentRow.Index; //przypisanie do zmiennej index obecnego wiersza po indeksie.
                    dataGridView1.Rows.RemoveAt(index); //usuwanie wiersza z tabelki
                }
                if (result == DialogResult.No) // przypisujemy wartości
                    return;
            }
            else
            {
                MessageBox.Show("Najpierw coś wybierz");
            }
        }
    }
}
