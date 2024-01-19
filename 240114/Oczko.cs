using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oczko
{
    enum Talia
    {
        AScz = 10,
        ASpo = 10,
        dama = 7,
        krol = 8,
        jopek = 6,
        dawk = 2
    }
    internal class Program
    {
        static int LosujKarte(List<int> listaLiczb)
        {
                Random random = new Random();
                int losowyIndex = random.Next(listaLiczb.Count);
                return listaLiczb[losowyIndex];
        }
        static void Main(string[] args)
        {
            Dictionary<int, string> Karty = new Dictionary<int, string>();
            Karty.Add(11,"AS");
            Karty.Add(4, "Krol");
            Karty.Add(10, "Dziesiatka");
            Karty.Add(2, "Jopek");
            Karty.Add(3, "Dama");
            Karty.Add(9, "Dziewiatka");
            Karty.Add(8, "Osemka");
            Karty.Add(7, "Siudemka");
            List<int> pkt = new List<int>();
            Console.WriteLine(Karty.Count());
            foreach (var item in Karty)
            {
                pkt.Add(item.Key);
            }
            List<int> Gracz1 = new List<int>();
            List<int> Gracz2 = new List<int>();
            Console.Write("Gracz 1:");
            string x="t";
            while (true)
            {
                
                Console.Write("Wybierz [N] konczysz losowanie");
                x =Console.ReadLine();
                if (x == "n")
                    break;
                Gracz1.Add(LosujKarte(pkt));
                Console.WriteLine("Twoje punkty:"+Gracz1.Sum());            
            }
            Console.Write("Gracz 2:");
            string z = "t";
            while (true)
            {

                Console.Write("Wybierz[N] konczysz losowanie");
                z = Console.ReadLine();
                if (z == "n")
                    break;
                Gracz2.Add(LosujKarte(pkt));
                Console.WriteLine("Twoje punkty:" + Gracz2.Sum());
            }

            Console.WriteLine("Wyniki : " );
            Console.WriteLine("Gracz1 : " + Gracz1.Sum());
            Console.WriteLine("Gracz1 : " + Gracz2.Sum());
            // int indeksLosowegoElementu = random.Next(Talia.Count );
            // Gracz1.Add();
            Console.ReadKey();
        }
    }
}
