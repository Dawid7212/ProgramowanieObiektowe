
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pracownik
    {
        public virtual void Pracuj()
        {
            Console.WriteLine("Pracownik pracuje");
        }
    }
    class Programista : Pracownik { 
        public override void Pracuj()
        {
            base.Pracuj();
            Console.WriteLine("Programista pracuje");
        }
    
    }
    class Projektant : Pracownik
    {
        public override void Pracuj()
        {
            Console.WriteLine("Projektant pracuje");
        }

    }
    class Ksiegowy : Pracownik 
    {
        public override void Pracuj()
        {
            Console.WriteLine("Ksiegowy pracuje");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Programista p = new Programista();
            Projektant pr = new Projektant();
            Ksiegowy k = new Ksiegowy();
            List<Pracownik> lista = new List<Pracownik>();
            lista.Add(p);
            lista.Add(pr);
            lista.Add(k);

            foreach (Pracownik x in lista) {
                x.Pracuj();
            }

            Console.ReadKey();
        }
    }
}
