using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6._9
{
    struct Prostoka
    {
        public int dlugosc;
        public int szerokosc;
        public Prostoka(int dl, int sz){
            dlugosc = dl; szerokosc = sz;
            }
        public void Pokaz()
        {
            Console.WriteLine("Długosc: {0}",dlugosc);
            Console.WriteLine("Szerokosc: {0}", szerokosc);
            Console.WriteLine("Powierzchnia: {0}", Pow());
            Console.WriteLine("obwód: {0}", Obw());
        }
        private int Pow()
        {
            return dlugosc*szerokosc;
        }
        private int Obw()
        {
            return 2*szerokosc+2*dlugosc;
        }
    }
internal class Program
{  
    static void Main(string[] args)
    {

        Prostoka[] tab1 = new Prostoka[3];
            tab1[0] = new Prostoka(10,15);
            tab1[0] = new Prostoka(20, 35);
            tab1[0] = new Prostoka(12, 5);
            foreach (Prostoka i in tab1)
            {
                i.Pokaz();
                Console.WriteLine();
            }
        

        Console.ReadKey();
    }
}
}