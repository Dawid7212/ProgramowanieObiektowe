using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Plec
{
    K, // Kobieta
    M // Mężczyzna
}

public class Osoba
{
    public string imie;
    public string nazwisko;
    private int rokUrodzenia;
    private int waga;
    private int wzrost;
    private bool okulary;
    private Plec plec;

    public Osoba(string imie, string nazwisko, int rokUrodzenia, int waga, int wzrost, bool okulary, Plec plec)
    {
        this.imie = imie;
        this.nazwisko = nazwisko;
        this.rokUrodzenia = rokUrodzenia;
        this.waga = waga;
        this.wzrost = wzrost;
        this.okulary = okulary;
        this.plec = plec;
    }

   

    public int ObliczWiek()
    {
        int obecnyRok = DateTime.Now.Year;
        return obecnyRok - rokUrodzenia;
    }

    public void DodajPrzedrostek()
    {
        string przedrostek = (plec == Plec.K) ? "Pani" : "Pan";
        Console.WriteLine($"Dyrektorem jest {przedrostek} {imie} {nazwisko}");
    }
}

public class Pacjent
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int Wzrost { get; set; }
    public int Waga { get; set; }

    public double ObliczBMI()
    {
        // Obliczanie BMI: masa (kg) / (wzrost (m) * wzrost (m))
        double wzrostMetry = (double)Wzrost / 100;
        return Waga / (wzrostMetry * wzrostMetry);
    }

    public void WyswietlRodzajWagi()
    {
        double bmi = ObliczBMI();

        if (bmi < 18.5)
            Console.WriteLine("Niedowaga");
        else if (bmi >= 18.5 && bmi < 24.9)
            Console.WriteLine("Wartość prawidłowa");
        else if (bmi >= 25 && bmi < 29.9)
            Console.WriteLine("Nadwaga");
        else
            Console.WriteLine("Otyłość");
    }
}

public class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
}

public class Koszyk
{
    private readonly List<Produkt> towar = new List<Produkt>();

    public void DodajDoKoszyka(Produkt produkt)
    {
        towar.Add(produkt);
    }

    public void PokazZawartoscKoszyka()
    {
        Console.WriteLine($"Liczba elementów w koszyku: {towar.Count}");
        decimal sumaCen = 0;

        foreach (var produkt in towar)
        {
            Console.WriteLine($"Produkt: {produkt.Nazwa}, Cena: {produkt.Cena}");
            sumaCen += produkt.Cena;
        }

        Console.WriteLine($"Suma cen: {sumaCen}");
    }
}

public class Zespolone
{
    public double Realna { get; set; }
    public double Urojona { get; set; }

    public Zespolone(double realna, double urojona)
    {
        Realna = realna;
        Urojona = urojona;
    }

    public static Zespolone Dodaj(Zespolone z1, Zespolone z2)
    {
        return new Zespolone(z1.Realna + z2.Realna, z1.Urojona + z2.Urojona);
    }

    public static Zespolone Odejmij(Zespolone z1, Zespolone z2)
    {
        return new Zespolone(z1.Realna - z2.Realna, z1.Urojona - z2.Urojona);
    }

    public static Zespolone Pomnoz(Zespolone z1, Zespolone z2)
    {
        double realna = z1.Realna * z2.Realna - z1.Urojona * z2.Urojona;
        double urojona = z1.Realna * z2.Urojona + z1.Urojona * z2.Realna;
        return new Zespolone(realna, urojona);
    }
}

