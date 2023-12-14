using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            metody kalkulator = new metody();

            while (true)
            {
                try
                {
                    Console.WriteLine("Wybierz operację:");
                    Console.WriteLine("1. Dodawanie");
                    Console.WriteLine("2. Odejmowanie");
                    Console.WriteLine("3. Mnożenie");
                    Console.WriteLine("4. Dzielenie");
                    Console.WriteLine("5. Potęgowanie");
                    Console.WriteLine("6. Pierwiastkowanie");
                    Console.WriteLine("0. Koniec programu");
                    Console.Write("Podaj numer operacji: ");

                    int sw = int.Parse(Console.ReadLine());
                    if (sw == 0)
                        break;

                    Console.Write("Podaj pierwszą liczbę: ");
                    double l1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Podaj drugą liczbę: ");
                    double l2 = Convert.ToDouble(Console.ReadLine());

                    switch (sw)
                    {
                        case 1:
                            kalkulator.Dodawanie(l1, l2);
                            break;
                        case 2:
                            kalkulator.Odejmowanie(l1, l2);
                            break;
                        case 3:
                            kalkulator.Mnozenie(l1, l2);
                            break;
                        case 4:
                            kalkulator.Dzielenie(l1, l2);
                            break;
                        case 5:
                            kalkulator.Potegowanie(l1, l2);
                            break;
                        case 6:
                            kalkulator.Pierwiastkowanie(l1, l2);
                            break;
                        default:
                            Console.WriteLine("Nieprawidłowy numer operacji.");
                            break;
                    }

                    Console.WriteLine("Wynik operacji: " + kalkulator.PobierzWynik());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Błąd formatu liczby. Wprowadź poprawną liczbę.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Nie dziel przez zero.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Wystąpił błąd: " + ex.Message);
                }


                finally
                {
                    Console.WriteLine("Koniec działania.");
                }
            }
            Console.ReadKey();
        }
    }
}
