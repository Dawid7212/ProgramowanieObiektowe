using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad30
{
    class Punkt : IMetody, ICloneable
    {
        public double X;
        public double Y;
        public string nazwa;

        public Punkt(double x, double y, string n)
        {
            this.X = x;
            this.Y = y;
            this.nazwa = n;
        }
        public Punkt()
        {
           
        }

        public void LiczObwod()
        {
            Console.WriteLine("Obwod punku to 0");
        }

        public void PobierzDaneZKlawiatury()
        {
            Console.WriteLine("Podaj wspolrzedną X:");
            double.TryParse(Console.ReadLine(), out X);
            Console.WriteLine("Podaj wspolrzedną Y:");
            double.TryParse(Console.ReadLine(), out Y);
            Console.WriteLine("Podaj nazwe punktu:");
            nazwa = Console.ReadLine();
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Punkt  o nazwie" + nazwa + " o wspl : x=" + X + " , y=" + Y;
        }

        public void Wyswietl()
        {
            Console.WriteLine("PUNKT");
            Console.WriteLine("Nazwa :" + nazwa);
            Console.WriteLine("Wspl x = " + X);
            Console.WriteLine("Wspl y = " + Y);
            Console.WriteLine();
        }

        public object Clone()
        {
            return (Punkt)this.MemberwiseClone();
        }
    }
    class Kolo : ICloneable, IMetody
    {
        public Punkt srodek = new Punkt();
        public double r;
        public string nazwa;

        public Kolo(Punkt s, double r, string n)
        {
            this.srodek = s;
            this.r = r;
            this.nazwa = n;
        }
        public Kolo()
        {

        }
        public override string ToString()
        {
            return "Kolo  o nazwie" + nazwa + " o wspl srodka : x=" + srodek.X + " , y=" + srodek.Y;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void LiczObwod()
        {
            double obw = 2 * 3.14 * r;
            Console.WriteLine("Obwod koła : " + obw);
            Console.WriteLine();
        }

        public void PobierzDaneZKlawiatury()
        {
            Console.WriteLine("Podaj nazwe:");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj promien:");
            double.TryParse(Console.ReadLine(), out r);
            srodek.PobierzDaneZKlawiatury();
            Console.WriteLine();
        }

        public void Wyswietl()
        {
            Console.WriteLine("Nazwa :" + nazwa);
            Console.WriteLine("Promien = " + r);
            Console.WriteLine("Dane srodka:");
            srodek.Wyswietl();
            LiczObwod();
            Console.WriteLine();
        }
    }
    class Kwadrat : IMetody, ICloneable
    {
        public Punkt A = new Punkt();
        public Punkt B = new Punkt();
        public Punkt C = new Punkt();
        public Punkt D = new Punkt();
        public string nazwa;

        public Kwadrat(string n, Punkt a, Punkt b, Punkt c, Punkt d)
        {
            this.nazwa = n;
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }
        public Kwadrat()
        {
           
        }

        public void LiczObwod()
        {
            double bok1 = Math.Sqrt((B.X - A.X) * (B.X - A.X) + (B.Y - A.Y) * (B.Y - A.Y));
            double bok2 = Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y));
            double bok3 = Math.Sqrt((D.X - C.X) * (D.X - C.X) + (D.Y - C.Y) * (D.Y - C.Y));
            double bok4 = Math.Sqrt((A.X - D.X) * (A.X - D.X) + (A.Y - D.Y) * (A.Y - D.Y));
            double Obw = bok1 + bok2 + bok3 + bok4;
            Console.WriteLine("obwod kwadratu = " + Obw);
        }

        public void PobierzDaneZKlawiatury()
        {
            Console.WriteLine("Podaj nazwe:");
            nazwa = Console.ReadLine();
            Console.WriteLine("Podaj dane dla pkt A :");
            A.PobierzDaneZKlawiatury();
            Console.WriteLine("Podaj dane dla pkt B :");
            B.PobierzDaneZKlawiatury();
            Console.WriteLine("Podaj dane dla pkt C :");
            C.PobierzDaneZKlawiatury();
            Console.WriteLine("Podaj dane dla pkt D :");
            D.PobierzDaneZKlawiatury();
            Console.WriteLine();
        }

        public override string ToString()
        {
            return "Kwadrat  o nazwie" + nazwa;
        }

        public void Wyswietl()
        {
            Console.WriteLine("Nazwa : " + nazwa);
            A.Wyswietl();
            B.Wyswietl();
            C.Wyswietl();
            D.Wyswietl();

            Console.WriteLine();
        }

        public object Clone()
        {
            return (Kwadrat)this.MemberwiseClone();
        }
    }
    interface ICloneable
    {
        object Clone();
    }
    interface IMetody
    {
        void LiczObwod();
        void PobierzDaneZKlawiatury();
        void Wyswietl();
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            /*Punkt P = new Punkt();
            Kwadrat K = new Kwadrat();
            K.PobierzDaneZKlawiatury();
            K.LiczObwod();
            K.Wyswietl();*/
            Kolo kolo = new Kolo();
            kolo.PobierzDaneZKlawiatury();
            kolo.ToString();
            kolo.LiczObwod();
            kolo.Wyswietl();
            Kolo k = new Kolo();
            k=(Kolo)kolo.Clone();
            Kwadrat X = new Kwadrat();
            Kwadrat Z = new Kwadrat();
            Z = (Kwadrat)X.Clone();
            Punkt C = new Punkt();
            Punkt B = new Punkt();
            B = (Punkt)C.Clone();
            Console.ReadKey();
        }
    }
}