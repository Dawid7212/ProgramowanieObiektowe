using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6._4
{
    internal class Program
    {
        public class Energia
        {
            public int pocz;
            public int kon;

            public Energia(int a, int b) { 
            pocz = a; 
            kon = b;
            }
            public void Pokaz()
            {
                Console.WriteLine("Początkowy stan : " + pocz);
                Console.WriteLine("Bieżący stan : " + kon);
                Console.WriteLine("Zużycie energi: " + Zuzycie());
            }
            private int Zuzycie()
            {
                return kon-pocz;
            }
        }
        static void Main(string[] args)
        {
            Energia[] tab = new Energia[2];
            tab[0] = new Energia(100, 200);
            tab[1] = new Energia(180, 210);
            foreach(Energia en in tab)
            {
                en.Pokaz();
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
