using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad20_30
{
    class Test : IClonable
    {
        public int liczba;
        public Test2 poleTestowe = new Test2();

        public Object Clone()
        {
            return MemberwiseClone();
        }

        public Test GlebokaKopia()
        {
            Test tempTest = new Test();
            tempTest.liczba = this.liczba;
            tempTest.poleTestowe.słowo = this.poleTestowe.słowo;
            return tempTest;
        }
    }
    interface IClonable
    {
        Object Clone();
    }
    class Test2
    {
        public string słowo;
    }

    class Zwierze : IDane
    {
        public string imie;
        public double rozmiar;
        public double waga;
        public virtual void CoJem()
        {
            Console.WriteLine("Zwierze je ludzkie mieso");
        }

        public virtual void JakSiePoruszam()
        {
            Console.WriteLine("Zwierze porusza sie jak chce");
        }
        public Zwierze KopiaPłytka()
        {
            return (Zwierze)this.MemberwiseClone();
        }
        public Zwierze KopiaGłęboka()
        {
            Zwierze tmpZwierze = new Zwierze();
            tmpZwierze.imie = this.imie;
            tmpZwierze.waga = this.waga;
            tmpZwierze.rozmiar = this.rozmiar;
            return tmpZwierze;
        }
    }
    class Pies : Zwierze
    {
        public string imie;
        public double rozmiar;
        public double waga;
        public override void CoJem()
        {
            Console.WriteLine("karme");
        }

        public override void JakSiePoruszam()
        {
            Console.WriteLine("na 4 łąpach");
        }
        public Pies KopiaGłęboka()
        {
            Pies tmpZwierze = new Pies();
            tmpZwierze.imie = this.imie;
            tmpZwierze.waga = this.waga;
            tmpZwierze.rozmiar = this.rozmiar;
            return tmpZwierze;
        }
    }
    class Wilk : Zwierze
    {
        public string imie;
        public double rozmiar;
        public double waga;
        public override void CoJem()
        {
            Console.WriteLine("mieso");
        }

        public override void JakSiePoruszam()
        {
            Console.WriteLine("na 4 łąpach");
        }
    }
    class Rekin : Zwierze
    {
        public string imie;
        public double rozmiar;
        public double waga;
        public override void CoJem()
        {
            Console.WriteLine("ryby");
        }

        public override void JakSiePoruszam()
        {
            Console.WriteLine("dzieki płetwą");
        }
    }
    class Orzeł : Zwierze
    {
        public string imie;
        public double rozmiar;
        public double waga;
        public override void CoJem()
        {
            Console.WriteLine("owady");
        }

        public override void JakSiePoruszam()
        {
            Console.WriteLine("na skrzydłąch");
        }
    }
    class Krokodyl : Zwierze
    {
        public string imie;
        public double rozmiar;
        public double waga;
        public override void CoJem()
        {
            Console.WriteLine("mieso");
        }

        public override void JakSiePoruszam()
        {
            Console.WriteLine("na 4 nogach");
        }
    }
    interface IDane
    {
        void JakSiePoruszam();
        void CoJem();
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Test obiekt1 = new Test();
            Test obiekt2 = new Test();   
            Test obiekt3 = new Test();
            obiekt1.liczba = 255;
            obiekt1.poleTestowe.słowo = "słowo";
            obiekt2 = obiekt1;
            obiekt3 = obiekt1.GlebokaKopia();
            obiekt1.liczba = 347;
            obiekt1.poleTestowe.słowo = "kaczka";

            Console.WriteLine(obiekt1.liczba + " " + obiekt1.poleTestowe.słowo);
            Console.WriteLine(obiekt2.liczba + " " + obiekt2.poleTestowe.słowo);
            Console.WriteLine(obiekt3.liczba + " " + obiekt3.poleTestowe.słowo);

            Pies york = new Pies();
            york.imie = "fifonż";
            york.rozmiar = 10.5;
            york.waga = 20;
            Pies mieszaniec = new Pies();
            Pies mieszaniec2 = new Pies();
            mieszaniec = (Pies)york.KopiaPłytka();
            mieszaniec2 = york.KopiaGłęboka();
            Console.WriteLine(york.imie);
            Console.WriteLine(mieszaniec.imie);
            Console.WriteLine(mieszaniec2.imie);
            Wilk szary = new Wilk();
            Wilk biały = new Wilk();
            Console.ReadKey();
        }
    }
}
