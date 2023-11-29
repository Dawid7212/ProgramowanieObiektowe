using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6._8
{
    public class Prostopadloscian
    {
        // Właściwości opisujące wymiary prostopadłościanu
        public double Dlugosc { get; set; }
        public double Szerokosc { get; set; }
        public double Wysokosc { get; set; }

        // Konstruktor klasy
        public Prostopadloscian(double dlugosc, double szerokosc, double wysokosc)
        {
            Dlugosc = dlugosc;
            Szerokosc = szerokosc;
            Wysokosc = wysokosc;
        }

        // Metoda obliczająca objętość prostopadłościanu
        public double ObliczObjetosc()
        {
            return Dlugosc * Szerokosc * Wysokosc;
        }

        // Metoda porównująca objętości dwóch prostopadłościanów
        public static bool PorownajObjetosci(Prostopadloscian prostopadloscian1, Prostopadloscian prostopadloscian2)
        {
            double objetosc1 = prostopadloscian1.ObliczObjetosc();
            double objetosc2 = prostopadloscian2.ObliczObjetosc();

            return objetosc1 == objetosc2;
        }
    }

    class Program
    {
        static void Main()
        {
            // Przykładowe użycie klasy Prostopadloscian
            Prostopadloscian prostopadloscian1 = new Prostopadloscian(3.0, 4.0, 5.0);
            Prostopadloscian prostopadloscian2 = new Prostopadloscian(2.5, 4.0, 6.0);

            Console.WriteLine("Objętość prostopadłościanu 1:",prostopadloscian1.ObliczObjetosc());
            Console.WriteLine("Objętość prostopadłościanu 2:", prostopadloscian2.ObliczObjetosc());

            bool czyObjetosciSaRowne = Prostopadloscian.PorownajObjetosci(prostopadloscian1, prostopadloscian2);

            if (czyObjetosciSaRowne)
            {
                Console.WriteLine("Objętości prostopadłościanów są równe.");
            }
            else
            {
                Console.WriteLine("Objętości prostopadłościanów nie są równe.");
            }
        }
    }
}
