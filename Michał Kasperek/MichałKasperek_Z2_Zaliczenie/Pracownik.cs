using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MichałKasperek_Z2_Zaliczenie
{
    [Serializable]
    class Pracownik
    {
        private string imię;
        private string nazwisko;
        private DateTime dataurodzenia = DateTime.Now;
        private string adres;
        private string urzadskarbowy;
        private DateTime datarozpoczecia = DateTime.Now;
        private int stawka;
        private string telefon;


        private static List<Pracownik> lista_pracownicy
           = new List<Pracownik>();

        public string Imię
        {
            get
            {
                return imię;
            }
            set
            {
                if (value.Length < 1 )
                    throw new Exception("Podatek musi mieć wartość nieujemną");
                imię = value;
            }
        }

        public string Nazwisko
        {
            get => nazwisko;
            set
            {
                if (value.Length < 1)
                    throw new Exception("Nazwisko nie może być puste");
                nazwisko = value;
            }
        }
        public DateTime Data
        {

            get
            {
                return dataurodzenia;
            }
            set
            {

                dataurodzenia = value;

            }
        }
        public string Adres
        {
            get => adres;
            set
            {
                if (value.Length < 1)
                    throw new Exception("Adres nie może być pusty");
                adres = value;
            }
        }
        public string Urzad
        {
            get => urzadskarbowy;
            set
            {
                if (value.Length < 1)
                    throw new Exception("Nazwa urzędu nie może być pusta");
                urzadskarbowy = value;
            }
        }
        public DateTime Data_Rozpoczecia
        {
            get
            {

                return datarozpoczecia;
            }

            set
            {
                datarozpoczecia = DateTime.Now;
                datarozpoczecia = value;
            }
        }
        public int Stawka_godz
        {
            get => stawka;
            set
            {
                if (value < 1)
                    throw new Exception("Stawka nie może być mniejsza od 1");
                stawka = value;
            }
        }
        public string Telefon
        {
            get => telefon;
            set
            {
                if (value.Length < 1)
                    throw new Exception("Wprowadź numer telefonu");
                telefon = value;
            }
        }
        internal static List<Pracownik> Lista_pracowników { get => lista_pracownicy; set => lista_pracownicy = value; }

        public override string ToString()//Polimorfizm  metoda dla typu obiektu 
        {
            return Imię + (" ") + Nazwisko + (" ");
        }
    }
}
