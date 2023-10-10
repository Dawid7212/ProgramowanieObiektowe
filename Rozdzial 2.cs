using System;
namespace pierwszy
{
    class Program
    {
        static void Zad1()
        {
            double c;
            Console.WriteLine("Podaj liczbe stopni:");
            c = double.Parse(Console.ReadLine());
            double f = 32 + ((9 / 5) * c);
            Console.WriteLine("Liczba po zmianie : " + f);
        }
        static void Zad2()
        {
            double a, b, c;
            Console.WriteLine("Podaj a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b:");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj c:");
            c = double.Parse(Console.ReadLine());
            double d = (b * b) - (4 * a * c);
            Console.WriteLine("Delta = " + d);
        }
        static void Zad3()
        {
            double waga, wzrost;
            Console.WriteLine("Kalkulator BMI");
            Console.WriteLine("Podaj wage w kg:");
            waga = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wzrost w metrach:");
            wzrost = double.Parse(Console.ReadLine());
            double bmi = waga / (wzrost * wzrost);
            Console.WriteLine("Twoje bmi: " + bmi);
        }
        static void Zad4()
        {
            int x = 100;
            Console.WriteLine(++x * 2);
            Console.WriteLine("Odpowiedź a");
        }
        static void Zad5()
        {
            int x = 2, y = 3;
            x *= y * 2;
            Console.WriteLine(x);
            Console.WriteLine("Odpowiedź d");
        }
        static void Zad6()
        {
            int x, y = 4;
            x = (y -= 2);
            x = y++;
            x = y--;
            Console.WriteLine(x);
            
        }
        static void zad7()
        {
            int x, y = 5;
            x = ++y * 2;
            x = y++;
            x = y--;
            Console.WriteLine(++y);
        }
        static void zad8()
        {
            bool x;
            int y = 1, z = 1;
            x = (y == 1 && z++ == 1);
            Console.WriteLine("x="+x);
            Console.WriteLine("y="+y);
            Console.WriteLine("z="+z);
        }


        static void zad9()
        {
            /**
            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 && y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
            

            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 && z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            int x = 1, y = 4, z = 2;
            bool wynik = (x++ > 1 & y++ == 4 & z-- > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 || y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);

            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 || ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);*/

            int x = 1, y = 3, z = 4;
            bool wynik = (x == 1 | y++ > 2 | ++z > 0);
            Console.WriteLine("wynik={0} x={1} y={2} z={3}", wynik, x, y, z);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Program wyświetla wartość 0, ponieważ wykonuje dzielenie całkowite gdy zmienne są typu int");
            decimal powierzchnia = 100, osoby = 10;
            decimal gestoscZaludnienia = osoby / powierzchnia;
            Console.WriteLine("{0:F1}",gestoscZaludnienia);

            Zad3(); // to wystarczy do wypisania poszczególnych zadan

        }

    } 
}
