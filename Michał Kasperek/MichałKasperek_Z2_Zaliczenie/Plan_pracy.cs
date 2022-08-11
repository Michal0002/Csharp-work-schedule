using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichałKasperek_Z2_Zaliczenie
{
    [Serializable]
    class Plan_pracy
    {
        private Pracownik prac;
        private DateTime miesiacdzien = DateTime.Now; //przypisujemy ponieważ wymaga wartości min./max.
        private int liczba_przepracowanych;
        private int zaplanowane_godziny;
        private int należność;
        public string nadgodziny;
        private static List<Plan_pracy> plan = new List<Plan_pracy>();

        public Pracownik Prac { get => prac; set => prac = value; }

        public DateTime MiesiacDzien
        {
            get //co chcemy dostać
            {
                return miesiacdzien;
            }
            set // co chcemy ustawić
            {
                miesiacdzien = DateTime.Now;
                miesiacdzien = value;
            }
        }
        public int Liczba_przepracowanych
        {
            get => liczba_przepracowanych;
            set
            {
                if (value < 8)
                {
                    if (MessageBox.Show("Ten pracownik przepracował mniej niż 8 godzin. Dodać do tabelki? ", "Potwierdź", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        liczba_przepracowanych = value;
                    }
                    else
                    {
                        throw new Exception("Osoba przepracowała mniej niż 8 godzin");
                    }
                }
                else
                {
                    liczba_przepracowanych = value;
                }

                }

        }
        public int Zaplanowane_godziny
        { 
            get => zaplanowane_godziny; 
            set
            {
                if (value < 1)
                    throw new Exception("Liczba zaplanowanych godzin nie może być mniejsza od 1.");
                zaplanowane_godziny = value;
            }
        }
        public int Należność
        {
            get {
                int nadgodziny = Liczba_przepracowanych - zaplanowane_godziny;

                if (liczba_przepracowanych > 8) 
                {
                    nadgodziny = nadgodziny * 3;
                    należność = (liczba_przepracowanych * prac.Stawka_godz) + nadgodziny;
                    return należność;
                }
                else
                {
                    należność = liczba_przepracowanych * prac.Stawka_godz;
                    return należność;
                }

            }
            set 
            {
                należność = value;
            }
        }
        internal static List<Plan_pracy> Plan { get => plan; set => plan = value; }
    }




        
}
