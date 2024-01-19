using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osoba
{
    class Osoba
    {
        private string imie;
        private int wiek;

        public Osoba()
        {

        }
        public Osoba(string i, int w)
        {
            this.imie = i;
            this.wiek = w; 
        }
        public string Imie()
        {
            return this.imie;
        }
        public void DodajImie(string x)
        {
            this.imie = x;
        }
        public int Wiek()
        {
            return this.wiek;
        }
        public void DodajWiek(int w)
        {
            this.wiek = w;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int,string> imiona = new SortedList<int,string>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
            imiona.Add(1,"Kamil");
            imiona.Add(3, "Andrzej");
            imiona.Add(2, "Wieslaw");
            imiona.Add(5, "Adam");
            imiona.Add(4, "Bogdan");
            imiona.Remove(1); //mozna usunac dowolna wartosc
            Console.WriteLine(imiona[2]);//mozna wydobyc dowolna wartosc
            Console.WriteLine("Uzycie count : "+imiona.Count());
            Console.WriteLine("Uzycie capacity : "+imiona.Capacity);
            foreach(var z in imiona)
            {
                Console.WriteLine(z.Value);
            }

            Console.WriteLine();
            Console.WriteLine();

            Queue<Osoba> osoby = new Queue<Osoba>();
            Osoba Arek = new Osoba("Arek",30);
            Osoba Marcel = new Osoba("Marcel",25);
            Osoba Heniek = new Osoba("Heniek", 20);
            Osoba Ambrozy = new Osoba("Ambroz",40);
            Osoba Marek = new Osoba("Marek", 42);
            osoby.Enqueue(Arek);
            osoby.Enqueue(Marcel);
            osoby.Enqueue(Heniek);
            osoby.Enqueue(Ambrozy);
            osoby.Enqueue(Marek);
            osoby.Dequeue(); //w kolejce queue mozemy usuwac tylko pierwszy element
            //queue nie mozna sortowac
            Console.WriteLine(osoby.Count());
            //queue nie mozemy uzyc capacity(pojemnosci)
            //w queue nie mozemy wydobyc dowolnego elementu
            Console.WriteLine(osoby);
            foreach (Osoba x in osoby) {
                Console.Write(x.Imie()+" ");
                Console.Write(x.Wiek());
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();

            Stack<int> wiek = new Stack<int>();
            wiek.Push(Arek.Wiek()); //30
            wiek.Push(Marcel.Wiek());//25
            wiek.Push(Ambrozy.Wiek());//40
            wiek.Push(Marek.Wiek());//42
            wiek.Push(Heniek.Wiek());//20
            //w Stack kazdy dodany element idzie na poczatek
            wiek.Pop();
            //w Stack mozna usuwac elementy tylko z poczatku
            //Stack nie posiada metody do sortowania 
            // w Stack nie mozemy wyswietlic takiego elementu jaki chcemy
            //Stack nie mozemy odwrocic kolejnosci, no chyba ze stworzymy liste na podstawie tego stosu
            List<int> lista = new List<int>(wiek);
            foreach (var i in wiek)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(wiek);
            Console.ReadKey();
        }
    }
}
