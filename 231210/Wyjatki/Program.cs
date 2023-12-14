using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int liczba1=0;
            int liczba2 = 30;
            int liczba3=1;
            try { 
                liczba3 = liczba2 / liczba1;
                }
            catch(Exception ex)
            { 
                Console.WriteLine("Nie lubię dzielić przez zero   "+ex.Message);
            }
            finally
            {
                Console.WriteLine("FINALLY");
                
            }
            Console.WriteLine(liczba3);
            */

            int[] table = new int[2];

            try
            {
                throw new IndexOutOfRangeException("haha");
                table[25] = 2;
 
                
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("Poza zakresem: " + e.Message);
            }
   

            Console.ReadKey();
        }
    }
}
