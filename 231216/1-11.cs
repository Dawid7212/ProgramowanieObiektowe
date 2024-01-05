using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Osoba
    {
        protected string Imie;
        protected string Nazwisko;
        protected int RokUrodzenia;
        private string miejsceZamieszkania;

        public string MiejsceZamieszkania
        {
            get { return miejsceZamieszkania; }
            set { miejsceZamieszkania = value; }
        }
      

        public Osoba(string i, string n, int r)
        {
            Imie = i;
            Nazwisko = n;
            RokUrodzenia = r;
        }
        public void WypiszInfo()
        {
            Console.WriteLine("Imie : "+Imie);
            Console.WriteLine("Nazwisko : " + Nazwisko);
            Console.WriteLine("Rok urodzenia : " + RokUrodzenia);
            ObliczWiek();
        }
        public void ObliczWiek()
        {
            int x = DateTime.Now.Year;
            int wiek = x - RokUrodzenia;
            Console.WriteLine("Wiek : "+wiek);
        }
    }
    class Student : Osoba
    {
        int rok;
        int nr_grupy;
        int nr_albumu;
        
        public Student(string i, string n, int r, int rok, int nr_grupy, int nr_albumu, string miejsceZamieszkania)
            :base( i,  n, r)
        {
            this.rok = rok;
            this.nr_grupy = nr_grupy;
            this.nr_albumu = nr_albumu;
            this.MiejsceZamieszkania = miejsceZamieszkania;

        }
        public new void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok : " + rok);
            Console.WriteLine("Numer grupy : " + nr_grupy);
            Console.WriteLine("Numer albumu : " + nr_albumu);
            Console.WriteLine("Miejsce zamieszkania: "+MiejsceZamieszkania);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student Andrzej = new Student("Andrzej", "Nowak", 2000, 2021, 3, 69, "Krakow");
            Student Karol = new Student("Karol", "Kowalski",1999,2032,5,53,"Warszawa");
            Andrzej.WypiszInfo();
            Osoba Adam = new Osoba("Adam","Morus",2005);
            Osoba Kasia = Karol;
            Kasia.WypiszInfo();
            Console.WriteLine(Andrzej.MiejsceZamieszkania);
            /*Student Arek = (Student)Adam;*/
     
            


            Console.ReadKey();
        }
    }
}
