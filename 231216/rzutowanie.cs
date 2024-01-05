using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rzutowanie
{
    class BaseClass
    {
        public string Imie;

        public BaseClass(string imie)
        {
            Imie = imie;
        }

        public void Wypisz()
        {
            Console.WriteLine(Imie);
        }
    }
    class DerrivedClass : BaseClass {
        public string Nazwisko;
        public DerrivedClass(string imie, string n) 
            :base(imie) {
            Nazwisko = n;
        }

        public void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine(Nazwisko);
        }
        
     }
    
    class NextDerrivedClass : DerrivedClass {
        public int wiek;
        public NextDerrivedClass(string imie, string n, int w) : base(imie, n)
        {
            wiek = w;
        }
        public void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine(wiek);
        }
    }

    class Konto
    {
        private double saldop;
        private double saldok;
        private double wyplaty = 0;
        private double wplaty = 0;
        public Konto(double x)
        {
            saldop = x;
            saldok = x;
        }
        public void Wyplac(double a)
        {
            saldok -= a;
            wyplaty += a;
            Console.WriteLine("Z konta ucieklo " + a + " zl");
        }
        public void Wplac(double b)
        {
            saldok += b;
            wplaty += b;
            Console.WriteLine("Do konta doszlo "+b+" zl");
        }
        public void SaldoPoczatkowe(){
            Console.WriteLine("Początkowe : " + saldop);
        }
        public void SaldoKoncowe()
        {
            Console.WriteLine("Koncowe : " + saldok);
        }


        public void ZapiszOperacjeDoPliku(string nazwaPliku)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nazwaPliku))
                {

                    // Dodaj wpłaty i wypłaty do pliku
                    writer.WriteLine("Operacje:");
                    writer.WriteLine("Saldo poczatkowe : " + saldop);
                    writer.WriteLine("Suma wplat :" + wplaty);
                    writer.WriteLine("Suma wyplat :" + wyplaty);
                    writer.WriteLine("Saldo koncowe : " + saldok); 
                }

                Console.WriteLine("Operacje zostały zapisane do pliku w sciezce: " + nazwaPliku);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas zapisywania do pliku: {ex.Message}");
            }
        }
        public virtual void WczytajOperacjeZPliku(string nazwaPliku)
        {
            try
            {
                if (File.Exists(nazwaPliku))
                {
                    using (StreamReader reader = new StreamReader(nazwaPliku))
                    {
                        // Przykładowe wczytanie historii konta (możesz dostosować do swoich potrzeb)
                        string linia;
                        while ((linia = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(linia);
                        }
                    }
                }
                else
                {
                    Console.WriteLine($"Plik {nazwaPliku} nie istnieje. Rozpoczęto nową historię konta.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd podczas wczytywania pliku: {ex.Message}");
            }
        }
    }
    class KontoPrywatne : Konto
    {
        public KontoPrywatne(double x,double kwota) :base(x) { }
        public void PrzelewWynagrodzenia(double kwota)
        {
            // Implementacja przelewu wynagrodzenia
            Console.WriteLine($"Przelew wynagrodzenia: {kwota}");
            Wplac(kwota);
        }

        public void Otrzymanie500Plus()
        {
            // Implementacja otrzymania świadczenia 500+
            Console.WriteLine("Otrzymano świadczenie 500+");
            Wplac(500.0);
        }

        // ... inne metody specyficzne dla konta prywatnego
    }

    class KontoFirmowe : Konto
    {
        public KontoFirmowe(double x, double kwota) : base(x) { }
        public void PrzelewDoZUS(double kwota)
        {
            // Implementacja przelewu do ZUS
            Console.WriteLine($"Przelew do ZUS: {kwota}");
            Wyplac(kwota);
        }

        public void PrzelewDoUS(double kwota)
        {
            // Implementacja przelewu do US
            Console.WriteLine($"Przelew do US: {kwota}");
            Wyplac(kwota);
        }

        // ... inne metody specyficzne dla konta firmowego
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass nowy = new BaseClass("Dawid");
            DerrivedClass tak = new DerrivedClass("Adam", "Nowak");
            nowy.Wypisz();
            /*DerrivedClass nowszy = (DerrivedClass)nowy; nie mozna*/
            /*NextDerrivedClass NxtObj1 = (NextDerrivedClass)nowy; nie mozna*/
            BaseClass tak2 = (BaseClass)tak; /* mozna */
            tak2.Wypisz();

            NextDerrivedClass aha = new NextDerrivedClass("Pawel","Mocny",40);
            BaseClass tak3 = (BaseClass)aha; /* mozna */
            tak3.Wypisz();

            NextDerrivedClass test = new NextDerrivedClass("Kasia", "Jakas",40);
            DerrivedClass x = (DerrivedClass)test;/* mozna */
            x.Wypisz();
            /* rzutowac mozna tylko do gory czyli klase pochodna na bazową bo wtedy klasa bazowa 
            wybiera sobie tylko te zmienne ktore potrzebuje, a w druga strone brakuje zmiennych 
            bo klasa bazowa ma ich mniej */



            Konto PKO = new Konto(2000.0);
            PKO.WczytajOperacjeZPliku("E:\\nowe rozdanie\\c#\\231216\\rzutowanie\\dane.txt");
            PKO.Wplac(200.5);
                PKO.Wyplac(1150.0);
                PKO.Wyplac(500.0);
                PKO.SaldoPoczatkowe();
                PKO.SaldoKoncowe();
                PKO.ZapiszOperacjeDoPliku("E:\\nowe rozdanie\\c#\\231216\\rzutowanie\\dane.txt");
            
            Console.ReadKey();
        }
    }
}
