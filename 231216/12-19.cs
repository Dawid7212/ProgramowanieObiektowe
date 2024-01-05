using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad12_19
{
    class Vehicle
    {

    }
    class Car : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jadę samochodem");
        }
    }
    class Bicycle : Vehicle, IRideable
    {
        public void Ride()
        {
            Console.WriteLine("Jade rowerem");
        }
    }
    interface IRideable
    {
        void Ride();
    }
    class Osoba : IGitarzysta, ISkrzypek
    {
        public void Graj()
        {
            Console.WriteLine("Gram ale nie wiem na czym");
        }
        void IGitarzysta.Graj()
        {
            Console.WriteLine("Gram na gitarze");
        }
        void ISkrzypek.Graj()
        {
            Console.WriteLine("Gram na skrzypcach");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Ride();
            Bicycle bicycle1 = new Bicycle();
            bicycle1.Ride();
            Osoba Dawid = new Osoba();
            Dawid.Graj();
            IGitarzysta gitara = (IGitarzysta)Dawid;
            gitara.Graj();
            ISkrzypek skrzypce = (ISkrzypek)Dawid;
            skrzypce.Graj();
            Console.ReadKey();
        }
    }
}
