using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichałKasperek_Z2_Zaliczenie
{
    [Serializable]
    public partial class FormDodaj : Form
    {
        Pracownik pracownik; 
        internal FormDodaj(Pracownik pracownik) //odwołujemy się za pomocą zmiennej 'pracownik' w całym dokumencie
        {
            InitializeComponent();
            this.pracownik = pracownik;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            //przypisujemy do klasy
            pracownik.Imię = textBox_imie.Text;
            pracownik.Nazwisko = textBox_nazwisko.Text;
            pracownik.Data = dateTimePicker_dataurodzenia.Value;
            pracownik.Adres = textBox_adreszamieszkania.Text;
            pracownik.Urzad = textBox_urządskarbowy.Text;
            pracownik.Data_Rozpoczecia = dateTimePicker_datarozpoczecia.Value;
            pracownik.Stawka_godz = Convert.ToInt32(numericUpDown_stawka.Value);
            pracownik.Telefon = textBox_telefon.Text;

        }

        private void FormDodaj_Load(object sender, EventArgs e)
        {
            //edycja
            textBox_imie.Text = pracownik.Imię;
            textBox_nazwisko.Text = pracownik.Nazwisko;
            dateTimePicker_dataurodzenia.Value = pracownik.Data;
            textBox_adreszamieszkania.Text = pracownik.Adres;
            textBox_urządskarbowy.Text = pracownik.Urzad;
            dateTimePicker_datarozpoczecia.Value = pracownik.Data_Rozpoczecia;
            numericUpDown_stawka.Value = pracownik.Stawka_godz;
            textBox_telefon.Text = pracownik.Telefon;
        }
    }
}
