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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void Form1_Load(object sender, EventArgs e) //deserializacja
        {
            try
            {
                FileStream fs = new FileStream("prac1.war", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();

                Pracownik.Lista_pracowników = (List<Pracownik>)bf.Deserialize(fs);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Nie udało się wczytać danych z pliku");
            }
            Odśwież_tabelkę(); //wywołanie funkcji - wypelnianie tabelki wcześniejszymi danymi

            //wczytanie danych z pliku planpracy.txt
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
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //serializacja
        {
            FileStream fs = new FileStream("prac1.war", FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();

            bf.Serialize(fs, Pracownik.Lista_pracowników);
            fs.Close();

        }
        private void button_dodaj_Click(object sender, EventArgs e) //dodawanie pracownika
        {
            try
            {
                Pracownik nowy = new Pracownik();  //deklaracja nowego obiektu
                FormDodaj form = new FormDodaj(nowy);
                form.ShowDialog();
                if (form.DialogResult != DialogResult.OK)
                    return;

                Pracownik.Lista_pracowników.Add(nowy);
                Odśwież_tabelkę(); //funkcja majaca na celu dodanie do tabeli
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nie udało się doddać wpisu.\n" + ex.Message);
            }
        }
        private void button_usuń_Click(object sender, EventArgs e) //usuwanie wybranego wiersza
        {
            DialogResult result = MessageBox.Show("Chcesz usunąć dane pracownika: " + dataGridView1.SelectedRows[0].Cells[0].Value + " " + dataGridView1.SelectedRows[0].Cells[1].Value + "? ", "Usuwanie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                int index = dataGridView1.CurrentRow.Index; //przypisanie do zmiennej index obecnego wiersza po indeksie.
                dataGridView1.Rows.RemoveAt(index); //usuwanie wiersza z tabelki

                Pracownik.Lista_pracowników.RemoveAt(index);
            }
            if (result == DialogResult.No) // przypisujemy wartości
                return;
        }

        void Odśwież_tabelkę() //dodawanie do tabelki
        {
            dataGridView1.Rows.Clear();
            foreach (Pracownik p in Pracownik.Lista_pracowników)
            {
                dataGridView1.Rows.Add(p.Imię, p.Nazwisko, p.Data.ToShortDateString(), p.Adres, p.Urzad, p.Data_Rozpoczecia.ToShortDateString(), p.Stawka_godz, p.Telefon);
            }
        }

        private void button_edytuj_Click(object sender, EventArgs e) //Edycja danych //wywołuje formatke FormDodaj
        {
            Pracownik pracownik = new Pracownik();
            FormDodaj form_edytuj = new FormDodaj(pracownik);

            DialogResult result = MessageBox.Show("Chcesz edytować dane dla: " + dataGridView1.SelectedRows[0].Cells[0].Value + " " + dataGridView1.SelectedRows[0].Cells[1].Value + "? ", "Usuwanie", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) // przypisujemy wartości z klasy do komórek tabelki
            {
                pracownik.Imię = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                pracownik.Nazwisko = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                pracownik.Data = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[2].Value);
                pracownik.Adres = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                pracownik.Urzad = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                pracownik.Data_Rozpoczecia = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value);
                pracownik.Stawka_godz = Convert.ToInt32(dataGridView1.CurrentRow.Cells[6].Value);
                pracownik.Telefon = dataGridView1.CurrentRow.Cells[7].Value.ToString();

                if (form_edytuj.ShowDialog() != DialogResult.OK)
                    return;

                //dodajemy przypisane wartości do tabelki w wybrane miejsce
                dataGridView1.SelectedRows[0].Cells[0].Value = pracownik.Imię;
                dataGridView1.SelectedRows[0].Cells[1].Value = pracownik.Nazwisko;
                dataGridView1.SelectedRows[0].Cells[2].Value = pracownik.Data.ToShortDateString();
                dataGridView1.SelectedRows[0].Cells[3].Value = pracownik.Adres;
                dataGridView1.SelectedRows[0].Cells[4].Value = pracownik.Urzad;
                dataGridView1.SelectedRows[0].Cells[5].Value = pracownik.Data_Rozpoczecia.ToShortDateString();
                dataGridView1.SelectedRows[0].Cells[6].Value = Convert.ToInt32(pracownik.Stawka_godz);
                dataGridView1.SelectedRows[0].Cells[7].Value = pracownik.Telefon;
                int selectedIndex = dataGridView1.CurrentCell.RowIndex; //wybrany wiersz
                Pracownik.Lista_pracowników.RemoveAt(selectedIndex);
                Pracownik.Lista_pracowników.Add(pracownik);

            }
        }
        private void button1_Click(object sender, EventArgs e) //wywołanie formatki z planem
        {
            Plan_pracy prac = new Plan_pracy();
            FormPlan formplan = new FormPlan(prac);
            formplan.ShowDialog();
        }

        private void button_zaplanuj_Click(object sender, EventArgs e) //wywołanie formatki z 
        {
            FormPlanowanie planowanie = new FormPlanowanie();
            planowanie.ShowDialog();
        }
    }
    }
