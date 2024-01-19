using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<int, string> rzymskieLiczby = new Dictionary<int, string>
        {
            { 1, "I" },
            { 2, "II" },
            { 3, "III" }
        };

        Console.WriteLine("Tabliczka mnożenia dla liczb rzymskich od 1 do 3:");
        foreach (var liczba1 in rzymskieLiczby)
        {
            foreach (var liczba2 in rzymskieLiczby)
            {
                int wynikMnozenia = liczba1.Key * liczba2.Key;
                Console.WriteLine("Wynik {0} * {1} = {2}",liczba1.Value,liczba2.Value,ToRzymskie(wynikMnozenia));
            }
        }
        Console.ReadKey();
    }

    // Funkcja do konwersji liczby arabskiej na rzymską
    static string ToRzymskie(int liczba)
    {
        if (liczba < 1 || liczba > 3999)
            throw new ArgumentOutOfRangeException("Obsługiwane są tylko liczby od 1 do 3999");

        Dictionary<int, string> rzymskieZnaki = new Dictionary<int, string>
        {
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD" },
            { 100, "C" },
            { 90, "XC" },
            { 50, "L" },
            { 40, "XL" },
            { 10, "X" },
            { 9, "IX" },
            { 5, "V" },
            { 4, "IV" },
            { 1, "I" }
        };

        string wynik = "";
        foreach (var kvp in rzymskieZnaki)
        {
            while (liczba >= kvp.Key)
            {
                wynik += kvp.Value;
                liczba -= kvp.Key;
            }
        }
        return wynik;
    }
   
}