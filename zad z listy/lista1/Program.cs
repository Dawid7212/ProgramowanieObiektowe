using System;
namespace lista
{

    class Program
    {
        static void Main()
        {
            // Punkt 1
            string carName = "Mój samochód";
            Console.WriteLine(carName);

            // Punkt 4
            Car car1 = new Car();
            car1.SetCarInfo("Toyota", 2020);
            car1.DisplayCarInfo();

            // Punkt 5
            // Car car2 = new Car();
            // car2.SetCarInfo("Honda", 2018);
            // car2.DisplayCarInfo();

            // Punkt 6
            // car1 = car2;
            // Console.WriteLine("Po przypisaniu car1 = car2:");
            // car1.DisplayCarInfo();

            // Punkt 8
            Car car3 = new Car();
            car3.SetCarInfo("BMW", 2022);
            car3.DisplayCarInfo();

            // Punkt 9
            Console.WriteLine("\nDiagram UML dla klasy Car:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("|           Car             |");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("| - marka: string           |");
            Console.WriteLine("| - rok: int                |");
            Console.WriteLine("| - model: string           |");
            Console.WriteLine("| - iloscDrzwi: int         |");
            Console.WriteLine("| - pojemnoscSilnika: int   |");
            Console.WriteLine("| + srednieSpalanie: double |");
            Console.WriteLine("-------------------------------");

            // Punkt 10
            double dlugoscTrasy = 150.5;
            double spalanie = car3.ObliczSpalanie(dlugoscTrasy);
            Console.WriteLine($"\nSpalanie dla trasy o długości {dlugoscTrasy} km: {spalanie} l");

            // Punkt 11
            double cenaPaliwa = 5.5;
            double kosztPrzejazdu = car3.ObliczKosztPrzejazdu(dlugoscTrasy, cenaPaliwa);
            Console.WriteLine($"Koszt przejazdu dla trasy o długości {dlugoscTrasy} km: {kosztPrzejazdu} zł");
            Console.ReadKey();
        }
    }
}