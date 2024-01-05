using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27
{
    abstract class Bohater : IClonable
    {
        public int hp;
        public int atak;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    class Piechor : Bohater
    {
        public Piechor()
        {
            base.hp = 100;
            base.atak = 100;
        }
        public Piechor(int h, int a)
        {
            base.hp = a; 
            base.atak = h;
        }
    }
    class Lucznik : Bohater
    {
        public Lucznik()
        {
            base.hp = 80;
            base.atak = 120;
        }
        public Lucznik(int h, int a)
        {
            base.hp = a;
            base.atak = h;
        }
    }
    class Druzyna
    {
        public Bohater B1;
        public Bohater B2;
        public Bohater B3;
        public Bohater B4;
        public Bohater B5;
        public Bohater B6;
        public Bohater B7;
        public Bohater B8;
        public Bohater B9;
        public Bohater B10;
        public List<Bohater> team = new List<Bohater>();

        public Druzyna(List<Bohater> l)
        {
            this.team = l;
        }
        public void Wypisz()
        {
            foreach (Bohater b in team)
            {
                Console.WriteLine(b.hp+"  "+b.atak);
            }
            Console.WriteLine();
        }
        public void SortujAtak()
        {
            team.Sort((bohater1,bohater2) => bohater2.atak.CompareTo(bohater1.atak));
        }
        public void SortujHp()
        {
            team.Sort((bohater1, bohater2) => bohater2.hp.CompareTo(bohater1.hp));
        }
    }
    interface IClonable
    {
        object Clone();
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Bohater> l = new List<Bohater>()
            {
                new Piechor(125,90),
                new Piechor(50,45),
                new Piechor(200,59),
                new Lucznik(220,30),
                new Lucznik(300,20)
            };
            Druzyna Czerwoni = new Druzyna(l);
            Czerwoni.Wypisz();
            Czerwoni.SortujAtak();
            Czerwoni.Wypisz();
            Console.ReadKey();
        }
    }
}
