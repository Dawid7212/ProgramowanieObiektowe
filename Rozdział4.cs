namespace nr2
{
    class Program
    {

        static void wejsciowka()
        {
            double d = 1;

            double m = 1;
            do
            {
                Console.WriteLine("Podaj swój dzień urodzenia z zakresu 1 - 31:");
                d = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj swój miesiąc urodzenia 1 - 12:");
                m = double.Parse(Console.ReadLine());

            } while (m > 12 || d > 31);
            Console.WriteLine();
            int ilosc = 0;
            for (int i = 1; i <= (d + m + 12); i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
        static void Zad1()
        {
            Console.WriteLine("Podaj długość tablicy n:");
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];
            for (int i = 0 ; i < n ; i++)
            {
                Console.WriteLine("Podaj {0} element tablicy:",i);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Podane elementy:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", liczby[i]);
            }
        }

        static void Zad2()
        {
            int[] p = {-2,4,2,7,8,9,-3,5,6,-7 };
            int[] d = new int[10];
            int j = 0;
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i]>=0)
                {
                    d[j] = p[i];
                    j++;
                }
                
            }
            Console.WriteLine("Podane elementy:");
            foreach (int x in d)
            {
                if (x != 0)
                {
                    Console.Write("{0}  ", x);
                }
                
            }
        }

        static void Zad3()
        {
            Console.WriteLine("Podaj długość tablicy n:");
            int n = int.Parse(Console.ReadLine());
            int[] liczby = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Podaj {0} element tablicy:", i);
                liczby[i] = int.Parse(Console.ReadLine());
            }
            int min = liczby[0];
            int max = liczby[0];
            int pozycja = 0, pozycja2 = 0;  
            int dodatnie= 0;
            double srednia = 0;
            Console.WriteLine("Podane elementy:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", liczby[i]);
                srednia += liczby[i];
                if (min > liczby[i])
                {
                    min = liczby[i];
                    pozycja2 = i;
                }
                if (max < liczby[i])
                {
                    max = liczby[i];
                    pozycja = i;
                }
                if (liczby[i]>=0)
                {
                    dodatnie++;
                }
            }
            srednia = (srednia/liczby.Length);
            Console.WriteLine();
            Console.WriteLine("Największy element tablicy:  {0} wystepuje na pozycji {1}", max, pozycja+1);
            Console.WriteLine("Najmniejszy element tablicy:  {0} wystepuje na pozycji {1}", min, pozycja2+1);
            Console.WriteLine("Srednia elemantów : {0}", srednia);
        }
        static void Zad4()
        {
            int[] tab = new int[100];
            int x = 0;
            Random rand = new Random();
            for (int i = 0; i < 100; i++)
            {
                tab[i] = rand.Next(1, 1000);
            }
            Console.WriteLine("Liczby pierwsze w tablicy:");
            foreach (int i in tab)
            {
                x = 0;
                if (i < 2)
                    continue; //gdy liczba jest mniejsza niż 2 to nie jest pierwszą

                for (int j = 2; j * j <= i; j++)
                {
                     if (i % j == 0)
                     {
                         x=1; //gdy znajdziemy dzielnik, to dana liczba nie jest pierwsza
                     }
                                            
                }
                if (x == 1)
                {
                    continue;
                }
                   
                Console.Write("  {0}  ", i);
            }
                
        }
        static void Zad5()
        {
            int[] tab1 = { -2, 4, 2, 7, 8, 9, -3, 5, 6, -7 };
            int[] tab2 = new int[10];
            int j = 1;
            for (int i = 0; i < tab1.Length; i++)
            {
                if (i == (tab1.Length - 1))
                {
                    j = 0;
                }
                
                tab2[j] = tab1[i];
                j++;

            }
            Console.WriteLine("Tablica 1:");
            foreach (int x in tab1)
            {
                Console.Write("{0}  ", x);
            }
            Console.WriteLine();
            Console.WriteLine("Tablica 2:");
            foreach (int x in tab2)
            {              
                    Console.Write("{0}  ", x);
            }
        }
        static void Zad6()
        {
            int[,] tab = { { 1, 4, 65, 67, 2 }, { 2, 4, 5, 7, 2 }, { 6, 8, 3, 6, 2 }, { 4, 6, 2, 7, 8 }, { 87, -45, 6, 8, -2 } };
            int suma = 0;
            for(int i = 0;i < 5; i++)
            {
                for(int j = 0;j<5; j++)
                {
                    Console.Write("{0,4}  ", tab[i,j]);
                    if (i == j)
                        suma += tab[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Suma elementów na przekątnej : {0}", suma);
        }
        static void Zad7()
        {
            int[,] tab1 = { { 3, 7, 5 },{ 7, 3, 5 } };
            int[,] tab2 = { { 8, 3, 1 }, { 71, -3, 15 } };
            int[,] tab3 = new int[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tab3[i,j] = tab1[i, j] + tab2[i,j];
                    Console.Write("{0,4}  ", tab3[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Zad8()
        {
            string[,] dniTygodnia;
            dniTygodnia = new string[7, 3]; // pamiętaj o zmianie rozmiaru tablicy
            dniTygodnia[0, 0] = "poniedzialek";
            dniTygodnia[1, 0] = "wtorek";
            dniTygodnia[0, 1] = "monday";
            dniTygodnia[1, 1] = "tuesday";
            dniTygodnia[0, 2] = "montag";
            dniTygodnia[1, 2] = "dienstag";
            dniTygodnia[2, 0] = "środa";
            dniTygodnia[2, 1] = "wednesday";
            dniTygodnia[2, 2] = "mittwoch";
            dniTygodnia[3, 0] = "czwartek";
            dniTygodnia[3, 1] = "thursday";
            dniTygodnia[3, 2] = "donnerstag";
            dniTygodnia[4, 0] = "piątek";
            dniTygodnia[4, 1] = "friday";
            dniTygodnia[4, 2] = "fraitag";
            dniTygodnia[5, 0] = "sobota";
            dniTygodnia[5, 1] = "saturday";
            dniTygodnia[5, 2] = "samstag";
            dniTygodnia[6, 0] = "niedziela";
            dniTygodnia[6, 1] = "sunday";
            dniTygodnia[6, 2] = "sonntag";
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("{0,-15}  ", dniTygodnia[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Zad9()
        {
            string ciag;
            int ilosc = 1;
            Console.WriteLine("Napisz jakies zdanie aby sprawdzic liczbe wyrazów");
            ciag = Console.ReadLine();
            for(int i = 0;i < ciag.Length-1;i++) {
                if (ciag[i] == ' ') {
                    ilosc++;
                }
            }
            Console.WriteLine("Liczba wyrazów jest równa : "+ilosc);
        }
        static void Zad10()
        {
            string data;
            Console.WriteLine("Podaj datę w formacie DD-MM-RRRR");
            data = Console.ReadLine();
            string mies = data.Substring(3, 2);
            switch (mies)
            {
                case "01":
                        Console.WriteLine("Styczneń");
                        break;
                case "02":
                    Console.WriteLine("Luty");
                    break;
                case "03":
                    Console.WriteLine("Marzec");
                    break;
                case "04":
                    Console.WriteLine("Kwiecień");
                    break;
                case "05":
                    Console.WriteLine("Maj");
                    break;
                case "06":
                case "07":
                case "08":
                case "09":
                case "10":
                case "11":
                case "12":
                    Console.WriteLine("Czerwiec - Grudzien");
                    break;
                default:
                    Console.WriteLine("Podano zły miesąc!!");
                    break;
            }
              
        }
        static void Zad11()
        {
            string a;
            int ilosc ;
            int x=0;
            Console.WriteLine("Podaj wyraz");
            a = Console.ReadLine();
            char[] tab = new char[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                ilosc = 0;
                x = 0;
                foreach(char c in tab)
                {
                    if (c == a[i]) {
                        x = 1;
                    }
                }
                if (x == 1) { continue; }
                for (int j = 0; j < a.Length; j++)
                {
                    tab[i] = a[i];
                    if (a[j] == a[i])
                    {
                        ilosc++;
                    }
                }
                Console.WriteLine("Liczba wystąpień {0} jest równa {1}", a[i],ilosc);
            }
        }
        static void Zad12()
        {
            string tekst =  "W parę godzin później, gdy noc zbierała się do odejścia,\n" +
                            "Puchatek obudził się nagle z uczuciem dziwnego przygnębienia.\n" +
                            "To uczucie dziwnego przygnębienia miewał już nieraz i wiedział,\n" +
                            "co ono oznacza. Był głodny. Więc poszedł do spiżarni,\n" +
                            "wgramolił się na krzesełko, sięgnął na górną półkę, ale nic nie znalazł.";
            Console.WriteLine(tekst);
            string[] wiersze = tekst.Split("\n");
            int liczbawierszy = wiersze.Length;
            Console.WriteLine("LIczba wierszy : "+liczbawierszy);
            for (int i = 0; i<wiersze.Length; i++)
            {
                Console.WriteLine("Wiersz {0} ma długosć {1}", i, wiersze[i].Length);
            }
        }
        static void Zad13()
        {
            string tekst = Console.ReadLine();
            int pozycja, start = 0,ilosc=0, x=0;          
            tekst.Trim();
            string[] wyrazy = tekst.Split(" ");
            string[] tmp = new string[wyrazy.Length];
            for (int i = 0; i < wyrazy.Length; i++)
            {
                ilosc = 0;
                start = 0;
                x = 0;
                while ((pozycja = tekst.IndexOf(wyrazy[i], start)) >= 0)
                {
                    ilosc++;
                    start = pozycja + wyrazy[i].Length; // dalsze szukanie x znakow dalej 
                }
                tmp[i] = wyrazy[i];
                foreach (string s in tmp)
                    {
                        if (wyrazy[i] == s)
                        {
                            x++;
                        }
                    }
                if(x > 1)
                {
                    continue;
                }
                if (ilosc>=2)
                {
                    Console.WriteLine("Słowo {0} wystąpiło {1} razy", wyrazy[i], ilosc);
                }
                
            }
            
        }
        static void Zad14()
        {
            string[] identyfikatory = { "KOMG-2002", "BH-2010", "XYZ-2015", "ABC-2005", "DEF-2018" };
            int obecnyRok = DateTime.Now.Year;

            Console.WriteLine("Liczba lat od zakupu środków trwałych:");

            foreach (string identyfikator in identyfikatory)
            {
                int rokZakupu;
                if (PobierzRokZakupu(identyfikator, out rokZakupu))
                {
                    int lataOdZakupu = obecnyRok - rokZakupu;
                    Console.WriteLine($"{identyfikator}: {lataOdZakupu} lat");
                }
                else
                {
                    Console.WriteLine($"{identyfikator}: Nieprawidłowy format identyfikatora");
                }
            }
        }
        static bool PobierzRokZakupu(string identyfikator, out int rok)
        {
            rok = 0;

            string[] czesci = identyfikator.Split('-');

            if (czesci.Length == 2 && czesci[1].Length == 4 && int.TryParse(czesci[1], out rok))
            {
                return true;
            }

            return false;
        }
    
    static void Main(string[] args)
        {
            Zad14();
            
        }


    }
}