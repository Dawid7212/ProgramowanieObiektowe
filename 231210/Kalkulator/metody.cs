using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class metody
    {
        private double wynik;

    public void Dodawanie(double a, double b)
    {
        wynik = a + b;
    }

    public void Odejmowanie(double a, double b)
    {
        wynik = a - b;
    }

    public void Mnozenie(double a, double b)
    {
        wynik = a * b;
    }

    public void Dzielenie(double a, double b)
    {
        
            wynik = a / b;
        
    }

    public void Potegowanie(double a, double b)
    {
        wynik = Math.Pow(a, b);
    }

    public void Pierwiastkowanie(double a, double b)
    {
        if (b != 0)
            wynik = Math.Pow(a, 1.0 / b);
        else
            Console.WriteLine("Nie można pierwiastkować przez zero.");
    }

    public double PobierzWynik()
    {
        return wynik;
    }
    }
}
