using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_7
{
    
    internal class Program
    {
        static void Licz()
        {
            int i = 1;
            while (i <= 10000)
            {
                Console.WriteLine("watek1 : " + i);
                i++;
            }
        }
        static void Main(string[] args)
        {
            Thread thr = new Thread(Licz);
            thr.Start();
            /*thr.Join(); wtedy program1 poczeka na koniec licz*/
            int i = 1;
            while (i<=10000)
            {
                Console.WriteLine("program1 : "+i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
