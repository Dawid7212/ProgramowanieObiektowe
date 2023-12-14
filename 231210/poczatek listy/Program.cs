using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista231210
{
    class Car
    {
        private double pojenmoscSilnika;
        private string marka;
        static int iloscKol;

        static Car(){
            iloscKol = 4;
            }
       
        public Car()
        {
            marka = "brak";
            pojenmoscSilnika = 0.0;
        }
        public Car( string marka, double pojemnoscSilnika)
        {
            this.pojenmoscSilnika = pojemnoscSilnika;
            this.marka = marka;
        }
        static public Car CarCreate()
        {
            return new Car();
        }
        public void poka()
        {
            Console.WriteLine(marka);
            Console.WriteLine(pojenmoscSilnika);
        }
        ~Car()
        {
            MessageBox.Show("Zwalniam pamięć");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car vw = new Car();
            Car bmw = new Car("BMW",3.2);
            Car Audi = Car.CarCreate();
            Audi.poka();
            bmw.poka();
            vw.poka();
            Console.ReadKey();
        }
    }
}
