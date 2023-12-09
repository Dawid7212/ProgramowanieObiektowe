using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista
{
    class Car
    {
        private string marka;
        private int rok;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double srednieSpalanie;

        public void SetCarInfo(string marka, int rok)
        {
            this.marka = marka;
            if (SprawdzRokProdukcji(rok))
            {
                this.rok = rok;
            }
            else
            {
                Console.WriteLine("Błędny rok produkcji. Ustawiono domyślny rok 2000.");
                this.rok = 2000;
            }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"\nMarka: {marka}\nRok produkcji: {rok}");
        }

        private bool SprawdzRokProdukcji(int rok)
        {
            return rok >= 1769 && rok <= 2017;
        }

        public double ObliczSpalanie(double dlugoscTrasy)
        {
            return srednieSpalanie * dlugoscTrasy;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            return ObliczSpalanie(dlugoscTrasy) * cenaPaliwa;
        }
    }
}
