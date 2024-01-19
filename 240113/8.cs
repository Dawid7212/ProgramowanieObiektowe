using System;

// Poziom 1: Klasa Calculator - Abstrakcja operacji kalkulatora
public class Calculator
{
    // Poziom 2: Metoda Calculate - Abstrakcja operacji obliczeniowej
    public static double Calculate(double num1, double num2, char operation)
    {
        switch (operation)
        {
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            case '*':
                return num1 * num2;
            case '/':
                // Poziom 3: Obsługa wyjątków - Dzielenie przez zero
                if (num2 == 0)
                {
                    throw new ArgumentException("Nie można dzielić przez zero.");
                }
                return num1 / num2;
            default:
                throw new ArgumentException("Nieznane działanie.");
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            // Poziom 1: Wejście użytkownika - Kalkulator w konsoli
            Console.WriteLine("Kalkulator - Podaj dwie liczby i operację (+, -, *, /):");
            Console.Write("Podaj pierwszą liczbę: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Podaj operację (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            // Poziom 2: Wywołanie metody Calculate z poziomu Calculator
            double result = Calculator.Calculate(num1, num2, operation);
            // Wyświetlenie wyniku
            Console.WriteLine("Wynik: "+result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Błąd formatu liczby. Podaj poprawne liczby.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Błąd: "+ex.Message);
        }
        catch (Exception)
        {
            Console.WriteLine("Wystąpił nieoczekiwany błąd.");
        }
        Console.ReadKey();
    }
}
