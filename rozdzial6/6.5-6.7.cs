using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static zad6._5.Program;

namespace zad6._5
{
    internal class Program
    {
        public class Odcinek
        {
            private Punkty A;
            private Punkty B;

            public Odcinek(Punkty a, Punkty b)
            {
                A = a;
                B = b;
            }
            public void Pokaz()
            {
                A.Wyswietl();
                B.Wyswietl();
                Console.WriteLine("Długość tego odcinka : {0:F2}", Dlugosc());
            }
            private double Dlugosc()
            {
                double x1 = A.X;
                double y1 = A.Y;

                double x2 = B.X;
                double y2 = B.Y;

                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
        }
        public class Punkty
        {
            private double x;
            private double y;

            public Punkty(double x, double y)
            {
                this.x = x;
                this.y = y;
            }
            public double X
            {
                get { return x; }
                set { x = value; }
            }

            public double Y
            {
                get { return y; }
                set { y = value; }
            }
            public void Przesun()
            {
                Console.WriteLine();
                Console.WriteLine("O ile przesunąć?");
                Console.WriteLine("Pierwsza współrzędna :");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Druga współrzędna :");
                double b = double.Parse(Console.ReadLine());
                x += a;
                y += b;
            }
            public void Wyswietl()
            {
                Console.WriteLine();
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
            }
            public static bool Czy(Punkty[] punkty)
            {
                if (punkty.Length < 3)
                    return false;

                double x1 = punkty[0].X;
                double y1 = punkty[0].Y;

                double x2 = punkty[1].X;
                double y2 = punkty[1].Y;

                double x3 = punkty[2].X;
                double y3 = punkty[2].Y;

                return (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) == 0;
            }
        }

        static void Main(string[] args)
        {
            Punkty[] tab = new Punkty[3];
            tab[0] = new Punkty(6.0, 2.0);
            tab[1] = new Punkty(4.0, 12.0);
            tab[2] = new Punkty(1.0, 5.0);
            foreach (Punkty i in tab)
            {
                i.Wyswietl();
            }

            Console.WriteLine("Czy punkty leżą na jednej prostej? : " + Punkty.Czy(tab));
            Odcinek AB = new Odcinek(tab[0], tab[1]);
            Console.WriteLine("Odcinek AB ma współrzędne : ");
            AB.Pokaz();
            Console.ReadKey();
        }
    }
}