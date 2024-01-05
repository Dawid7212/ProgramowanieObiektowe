using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_21
{
    class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Osoba()
        {
            Imie = "Brak";
            Nazwisko = "Brak";
        }

        public Osoba(string imie, string nazwisko)
        {
            Imie = imie;
            Nazwisko = nazwisko;
        }
        public virtual void WypiszInfo()
        {
            Console.WriteLine("Imie : "+Imie);
            Console.WriteLine("Nazwisko : " + Nazwisko);
        }
    }

    class Student : Osoba
    {
        public int RokStudiow { get; set; }
        public string NumerGrupy { get; set; }
        public string NumerAlbumu { get; set; }

        public Student()
            : base() 
        {
            RokStudiow = 1;
            NumerGrupy = "A";
            NumerAlbumu = "00000";
        }

        public Student(string imie, string nazwisko, int rokStudiow, string numerGrupy, string numerAlbumu)
            : base(imie, nazwisko)
        {
            RokStudiow = rokStudiow;
            NumerGrupy = numerGrupy;
            NumerAlbumu = numerAlbumu;
        }
        public override void WypiszInfo()
        {
            base.WypiszInfo();
            Console.WriteLine("Rok studiow : " + RokStudiow);
            Console.WriteLine("Nr grupy : " + NumerGrupy);
            Console.WriteLine("Nr albumu : " + NumerAlbumu);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba student1 = new Student();
            student1.WypiszInfo();
            Console.ReadKey();
        }
    }
}
