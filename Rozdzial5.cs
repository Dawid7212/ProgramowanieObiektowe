class Program
{
    static void Zad1()
    {
        string t;
        Console.WriteLine("Podaj temp w F aby zamienic ją na C :");
        t = Console.ReadLine();
        Double.TryParse(t, out double x);
        Console.WriteLine("{0} stopni F to {1:F2} stopni C", x, temperatury(x));
    }
    static double temperatury(double a) {
        Console.WriteLine("Wynik dzielenia");
        return (a - 32) * 5 / 9;
    }
    static void Zad2()
    {
        string a, b, x;
        Console.WriteLine("Podaj granice przediału a,b zatwierdzając enterem każdą wprowadzaną wartość");
        a = Console.ReadLine();
        b = Console.ReadLine();
        Console.WriteLine("Podaj x :");
        x = Console.ReadLine();
        Double.TryParse(a, out double a1);
        Double.TryParse(b, out double b1);
        Double.TryParse(x, out double x1);
        bool czy = przedzial(a1, b1, x1);
        Console.WriteLine("wynik:" + czy);
        if (czy)
        {
            Console.WriteLine("{0} mieści się w przedziale", x1);
        }
        else
        {
            Console.WriteLine("{0} nie miesci sie w przedziale", x1);
        }
    }
    static bool przedzial(double a, double b, double x)
    {
        return (x >= a) && (x <= b);
    }
    static void Zad3()
    {

        Console.WriteLine("Podaj dwie współrzędne punktu A :");
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        Double.TryParse(a, out double a1);
        Double.TryParse(b, out double b1);
        double wek1 = 3;
        double wek2 = 2;
        Console.WriteLine("Podano A({0},{1})", a1, b1);
        Przesun(ref a1, ref b1, wek1, wek2);
        Console.WriteLine("Po przesunięciu A({0},{1})", a1, b1);
    }
    static void Przesun(ref double a, ref double b, double w1, double w2)
    {
        a += w1;
        b += w2;
    }

    static void Zad4()
    {
        int[] tab1 = { 1, 2, 3, 4, 5 };
        int n = 2;
        Console.WriteLine("Tablica początkowa:");
        for (int i = 0; i < tab1.Length; i++)
        {
            Console.Write(" " + tab1[i]);
        }
        Console.WriteLine();
        int[] tab2 = Mnozenie1(tab1, n);
        Console.WriteLine("Sposób pierwszy:");
        for (int i = 0; i < tab2.Length; i++)
        {
            Console.Write(" "+tab2[i]);
        }
        Console.WriteLine();
        Console.WriteLine("Sposób drugi:");
        Mnozenie2(ref tab1, n);
        for (int i = 0; i < tab1.Length; i++)
        {
            Console.Write(" " + tab1[i]);
        }
        Console.WriteLine();


        string[] tab3 = { "ana", "david", "marsel" };
        zad6(ref tab3, 2);
        for (int i = 0; i < tab3.Length; i++)
        {
            Console.Write(" " + tab3[i]);
        }
    }
    static void zad6(ref string[] tab, int n)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            for(int j=1; j < n; j++)
            {
                tab[i] += tab[i];
            }
            
        }
    }
    static int[] Mnozenie1(int[] tab, int x)
    {
        int[] tabx = new int[tab.Length];
        for(int i = 0; i < tab.Length; i++)
        {
            tabx[i] = tab[i] * x;
        }
        return tabx;
    }
    static void Mnozenie2(ref int[] tab, int x)
    {
        
        for (int i = 0; i < tab.Length; i++)
        {
            tab[i] = tab[i] * x;
        }
        
    }


    static void Zad5()
    {
        Console.WriteLine("Podaj długość :");
        int d = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj szerokosc :");
        int sz = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj znak :");
        string z = Console.ReadLine();
        Console.WriteLine();
        Rysuj(d,sz,z);
        Console.WriteLine();
        Rysuj(sz, d, z);
        Console.ReadKey();
    }
    static void Rysuj(int dl, int sz, string z)
    {
        for (int i = 0; i < dl; i++)
        {
            for (int j = 0; j < sz; j++)
            {
                Console.Write(z);
            }
            Console.WriteLine();
        }
    }
    static void Zad7()
    {
        Console.WriteLine("W = (x+1)+(x+2)+...+(x+n)");
        Console.WriteLine("Podaj liczbe naturalna x: :");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Podaj liczbe naturalna n: :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("W = "+W(x,n));
    }
    static int W(int x, int n)
    {
        int W = 0;
        for(int i=1; i <= n; i++)
        {
            W += (x+i);
        }
        return W;
    }
    static void Zad8()
    {
        Console.WriteLine("Podaj liczbe naturalna x aby zsumować jej cyfry :");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Wynik : " + cyfry(x));
    }
    static int cyfry(int x)
    {  
        int suma = 0;
        while (x > 0)
        {
            suma += x % 10;
            x /= 10;
        }
        return suma;
    }
    static void Zad9()
    {
        Console.WriteLine("Podaj liczbe naturalna n aby obliczyc ciąg fibonacziego :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Wynik rekurencji= " + fib(n));
        Console.WriteLine("Wynik iteracyjny = " + Fibiteracyjnie(n));
    }
    static int fib(int n)
    {
        if(n == 0 || n == 1)
        {
            return n;
        }
        else
        {
            return fib(n-1)+fib(n-2);
        }
    }
    static int Fibiteracyjnie(int n)
    {
        if (n <= 1)
            return n;

        int a = 0;
        int b = 1;
        int temp = 0;

        for (int i = 2; i <= n; i++)
        {
            temp = a + b;
            a = b;
            b = temp;
        }

        return b;
    }
    static int Oblicz(int n)
    {
        if (n <= 1) return (1);
        else return (n + Oblicz(n - 1));
    }
    static void Main(string[] args)
    {
        Zad9();
    }
}