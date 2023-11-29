using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25._11._2023
{
    internal class Program
    {
        public class Prostokat
        {
            public int dlugosc;
            public int szerokosc;

            public Prostokat(int a, int b)
            {
                dlugosc = a;
                szerokosc = b;
            }
            private int powierzchnia() { 
                return dlugosc*szerokosc;
            }
            private int obwod()
            {
                return (dlugosc * 2) + (szerokosc *2);
            }
            public void Pokago()
            {
                int pow = powierzchnia();
                int obw = obwod();
                Console.WriteLine("Powierzchnia :" + pow);
                Console.WriteLine("Obwod        :" + obw);
                /*for (int i = 0; i<dlugosc; i++)
                {
                    for (int j = 0; j < szerokosc; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }*/
            }
            public static int Naj(Prostokat[] tablica)
            {
                int max = tablica[0].powierzchnia();
                foreach(Prostokat prostokat in tablica)
                {
                    if (max < prostokat.powierzchnia())
                        max = prostokat.powierzchnia();
                }

                return max;
            }
        }
        static void Main(string[] args)
        {
            Prostokat[] tab = new Prostokat[3];
            tab[0] = new Prostokat(3, 5);
            tab[1] = new Prostokat(6, 3);
            tab[2] = new Prostokat(2, 4);
            foreach (Prostokat i in tab)
            {
                i.Pokago();
            }
            Console.WriteLine("Najwieksza pow to : " + Prostokat.Naj(tab));
            Console.ReadKey();
        }
    }
}
