using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6._10
{
    struct KandydatNaStudia
    {
        public string Nazwisko;
        private double PunktyMatematyka;
        private double PunktyInformatyka;
        private double PunktyJezykObcy;



        public KandydatNaStudia(string Naz, double Mat, double inf, double jo)
        {
            Nazwisko = Naz;
            PunktyMatematyka = Mat;
            PunktyInformatyka = inf;
            PunktyJezykObcy = jo;
        }
        public double Punkty()
        {
            return (PunktyMatematyka*0.6)+(PunktyInformatyka*0.5)+(PunktyJezykObcy*0.2);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            KandydatNaStudia[] lista = new KandydatNaStudia[3];
            lista[0] = new KandydatNaStudia("Przytulski",59,80,30);
            lista[1] = new KandydatNaStudia("Kalinowski", 89, 53, 39);
            lista[2] = new KandydatNaStudia("Przytulski", 49, 60, 34);

            Console.WriteLine("{0,-15}  {1,-15}", "Kandydat", "Punkty:");
            foreach(KandydatNaStudia i in lista)
            {
                Console.WriteLine("{0,-15}  {1,-15}",i.Nazwisko, i.Punkty());
            }
            Console.ReadKey();
        }
    }
}
