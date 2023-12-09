using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        // Zadanie 13
        Osoba dyrektor = new Osoba("Alina", "Kowalska", 1980, 70, 165, false, Plec.K);
        Console.WriteLine($"Imię: {dyrektor.imie}, Nazwisko: {dyrektor.nazwisko}, Wiek: {dyrektor.ObliczWiek()} lat");

        // Zadanie 14
        // Dostępy do pól zmienione w pliku Osoba.cs

        // Zadanie 15
        dyrektor.DodajPrzedrostek();

        // Zadanie 16
        // Rok 2016 zastąpiony DateTime.Now.Year w metodzie ObliczWiek

        // Zadanie 17
        Pacjent pacjent = new Pacjent
        {
            Imie = "Jan",
            Nazwisko = "Nowak",
            Wzrost = 180,
            Waga = 85
        };
        pacjent.WyswietlRodzajWagi();

        // Zadanie 18
        Produkt chleb = new Produkt { Nazwa = "Chleb", Cena = 2.5m };
        Produkt mleko = new Produkt { Nazwa = "Mleko", Cena = 1.8m };

        Koszyk koszyk = new Koszyk();
        koszyk.DodajDoKoszyka(chleb);
        koszyk.DodajDoKoszyka(mleko);
        koszyk.PokazZawartoscKoszyka();

        // Zadanie 19
        Zespolone z1 = new Zespolone(3, 4);
        Zespolone z2 = new Zespolone(1, 2);

        Zespolone suma = Zespolone.Dodaj(z1, z2);
        Zespolone roznica = Zespolone.Odejmij(z1, z2);
        Zespolone iloczyn = Zespolone.Pomnoz(z1, z2);

        Console.WriteLine($"Suma: {suma.Realna} + {suma.Urojona}i");
        Console.WriteLine($"Różnica: {roznica.Realna} + {roznica.Urojona}i");
        Console.WriteLine($"Iloczyn: {iloczyn.Realna} + {iloczyn.Urojona}i");
        Console.ReadKey();
    }
}
