using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_9
{
    abstract class Figura
    {
        protected int z;
        protected int x;
        protected int y;
        public abstract void Pole();
 

    }
    class Kwadrat : Figura
    {
        public Kwadrat(int x)
        {
            base.z = x;
        }
        public override void Pole()
        {
            int P=z*z;
            Console.WriteLine("Pole Kwadratu jest rowne : "+P);
        }

    }
    class Trojkat : Figura 
    {
        public Trojkat(int a, int b)
        {
            base.z= a;
            base.x= b;
        }
        public override void Pole()
        {
            int P = (z * x)/2;
            Console.WriteLine("Pole Trojkata jest rowne : " + P);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Figura k = new Kwadrat(6);
            Figura t = new Trojkat(2,4);
            List<Figura> lista = new List<Figura> { k,t };
            foreach (Figura f in lista)
            {
                f.Pole();
            }
            Console.ReadKey();
        }
    }
}
