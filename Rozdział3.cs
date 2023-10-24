namespace nr2
{
    class Program
    {
        static void Wejsciowka()
        {
            decimal masa, wysokosc, bmi;
            Console.WriteLine("KALKULATOR BMI");
            Console.WriteLine("Podaj swoją masę :");
            masa = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach (użyj przecinka dla dokładnych wartosci):");
            wysokosc = decimal.Parse(Console.ReadLine());
            bmi = masa / (wysokosc * wysokosc);
            Console.WriteLine("Twoje dane: {0}kg, {1}m",masa,wysokosc);
            Console.WriteLine("Twoje BMI: {0:F2}",bmi);
        }
        static void Zad1()
        {
            Console.WriteLine("Podaj rok aby sprawdzić czy jest to rok przestępny: ");
            int rok = int.Parse(Console.ReadLine());
            if ((rok % 4 == 0 && rok % 100 != 0) || rok % 400 == 0)
            {
                Console.WriteLine("Podany rok jest przestępny");
            }
            else { Console.WriteLine("Podany rok NIE jest przestępny"); };
        }
        static void Zad2()
        {
            Console.WriteLine("Podaj dwie liczby całkowite (zatwierdź enterem każdą z nich): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a%b == 0)
            {
                Console.WriteLine("Druga liczba jest dzielnikiem pierwszej");
            }
            else { Console.WriteLine("Druga liczba NIE jest dzielnikiem pierwszej"); };
        }
        static void Zad3()
        {
            Console.WriteLine("Podaj trzy liczby całkowite (zatwierdź enterem każdą z nich): ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a > b && a>c)
            {
                Console.WriteLine("Liczba {0} jest najwieksza",a);
            }
            else if(b > c && b>a)
            {
                Console.WriteLine("Liczba {0} jest najwieksza", b);
            }
            else if (c > a && c > b)
            {
                Console.WriteLine("Liczba {0} jest najwieksza", c);
            }
            else { Console.WriteLine("Wprowadzono takie same liczby"); }
        }
        static void Zad4()
        {
            Console.WriteLine("PROSTY KALKULATOR");
            Console.WriteLine("Wybierz rodzaj działania, masz do wyboru '+' '-' '/' '*'  (zatwierdź enterem)");
            string znak = Console.ReadLine();
            Console.WriteLine("Wprowadz dwie liczby (zatwierdź enterem każdą z nich)");
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            switch (znak)
            {
                case "+":
                    decimal suma = a + b;
                    Console.WriteLine("{0} + {1} = {2}", a, b, suma);
                    break;
                case "-":
                    decimal r = a - b;
                    Console.WriteLine("{0} - {1} = {2}", a, b, r);
                    break;
                case "/":
                    decimal iloraz = a / b;
                    Console.WriteLine("{0} / {1} = {2}", a, b, iloraz);
                    break;
                case "*":
                    decimal iloczyn = a * b;
                    Console.WriteLine("{0} * {1} = {2}", a, b, iloczyn);
                    break;

                default:
                    Console.WriteLine("Wprowadzono zły symbol ! ");
                    break;
            }
        }
            static void Zad5()
            {
                Console.WriteLine("LICZBA PIERWIASTKOW ROWNANIA KWDRATOWYCH");
                Console.WriteLine("Podaj A, B i C (zatwierdź enterem każą z nich)");
                decimal a = decimal.Parse(Console.ReadLine());
                decimal b = decimal.Parse(Console.ReadLine());
                decimal c = decimal.Parse(Console.ReadLine());
                decimal delta = (b*b)-4*a*c;
                if (delta > 0)
                {
                    Console.WriteLine("DELTA={0} czyli program ma dwa pierwiastki równania",delta);
                }
                else if (delta == 0)
                {
                    Console.WriteLine("DELTA={0} czyli program ma jeden pierwiastek równania", delta);
                }
                else
                {
                    Console.WriteLine("DELTA={0} czyli program ma zero pierwiastków równania", delta);
                }
            }

        static void Zad6()
        {
            double masa, wysokosc, bmi;
            double aha = 18.5;
            Console.WriteLine("KALKULATOR BMI");
            Console.WriteLine("Podaj swoją masę :");
            masa = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj swój wzrost w metrach (użyj przecinka dla dokładnych wartosci):");
            wysokosc = double.Parse(Console.ReadLine());
            bmi = masa / (wysokosc * wysokosc);
            Console.WriteLine("Twoje dane: {0}kg, {1}m", masa, wysokosc);
            Console.WriteLine("Twoje BMI: {0:F2}", bmi);
            Console.WriteLine("Kategoria wg 6pkt klasyfikacji:");
            if (bmi < 16)
            {
                Console.WriteLine("1.wygłodzenie");
            }
            else if (bmi >= 16 && bmi <17)
            {
                Console.WriteLine("2.wychudzenie");
            }
            else if (bmi >= 17 && bmi < aha)
            {
                Console.WriteLine("3.niedowaga");
            }
            else if (bmi >= aha && bmi < 25)
            {
                Console.WriteLine("4. pożądana waga");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("5. nadwaga");
            }
            else if (bmi >= 30 && bmi <= 40)
            {
                Console.WriteLine("6. otyłość");
            }
        }
        static void Zad7()
        {
            Console.WriteLine("Wpisz nr dnia tygodnia");
            string numer = Console.ReadLine();
            switch (numer)
            {
                case "1":
                    Console.WriteLine("Poniedziałek");
                    break;
                case "2":
                    Console.WriteLine("Wtorek");
                    break;
                case "3":
                    Console.WriteLine("Środa");
                    break;
                case "4":
                    Console.WriteLine("Czwartek");
                    break;
                case "5":
                    Console.WriteLine("Piątek");
                    break;
                case "6":
                    Console.WriteLine("Sobota");
                    break;
                case "7":
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiego dnia tygodnia");
                    break;

            }
       
        }

        static void Zad8()
        {
            double s;
            double a = 4.8;
            Console.WriteLine("STYPENDIA");
            Console.WriteLine("Podaj swoją srednią z ocen :");
            s = double.Parse(Console.ReadLine());
            Console.WriteLine("Kwota przysługiwanego stypendium:");
            
            if (s >= 2 && s<4)
            {
                Console.WriteLine("0.00PLN");
            }
            else if (s >= 4 && s < a)
            {
                Console.WriteLine("350.00PLN");
            }
            else if (s >= a && s <= 5)
            {
                Console.WriteLine("550.00PLN");
            }
            else 
            {
                Console.WriteLine("Podano nieodpowiednią średnią");
            }
        }

        static void Zad9()
        {
            double a = 4.8;
            int w;
            char x = '*';
            Console.WriteLine("FIGURY");
            Console.WriteLine("Podaj wysokosc figur (liczbe wierszy) :");
            w = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i <= w; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = w; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= w; i++)
            {
                for (int k = (w-i); k >= 1; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 1; i <= w; i++)
            {
                if (i==1 || i==w)
                {
                    for (int j = 1; j <= w; j++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int k = 1; k <= (w-2); k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }    
                Console.WriteLine();
            }
        }
        static void Zad10()
        {
            Console.WriteLine("Podaj n aby obliczyć n!");
            double n = double.Parse(Console.ReadLine());
            double sil = 1;
            for (int i = 1 ; i<=n ; i++)
            {
                sil *= i;
            }
            Console.WriteLine("Silnia {0}! jest równa {1}",n,sil);
        }
        static void Zad11()
        {
            Console.WriteLine("Ile kolejnych liczb całkowitych należy do siebie dodać aby przekroczyc 100");
            int tmp = 0;
            int i = 1; ;
            int ilosc = 0;
            while (tmp <= 100)
            {
                tmp += i;
                i++;
                ilosc++;
            }
            Console.WriteLine("Należy dodać {0} liczb",ilosc);
        }
        static void Zad12()
        {
            Console.WriteLine("Podaj 0 jeśli chcesz zakończć działanie programu");
            int ilosc = 0;
            double n;
            do
            {
                Console.WriteLine("Podaj liczbe");
                n = double.Parse(Console.ReadLine());
                ilosc++;
            } while (n != 0);
            Console.WriteLine("Wprowadziłeś {0} liczb", ilosc);
        }
        static void Zad13()
        {
            Console.WriteLine("Podaj n aby obliczyć wartosć szeregu W(n)=1 – 2 + 3 – 4 + ...± n");
            double n = double.Parse(Console.ReadLine());
            double w = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    w += i;
                }
                else
                {
                    w -= i;
                }
            }
            Console.WriteLine("Wartość szeregu jest równa {0}", w);
        }
        static void Zad14()
        {
            Console.WriteLine("Podaj koncową liczbę n przediału aby znaleść w nim liczby doskonałe <1,n>");
            int n = int.Parse(Console.ReadLine());
            int suma=1;
            for (int i = 2; i <= n; i++)
            {
                for (int j = 2; j*j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        suma += j;
                        if (i / j != j)
                        {
                            suma += i / j;
                        }
                    }
                    
                }
                if (suma == i)
                {
                    Console.WriteLine("{0}",i);
                }
                suma = 1;
            }
        }
        static void Zad15()
        {
            int kwota = 10;
            int kombinacje = 0;

            for (int zł1 = 0; zł1 <= kwota; zł1++)
            {
                for (int zł2 = 0; zł2 <= kwota / 2; zł2++)
                {
                    for (int zł5 = 0; zł5 <= kwota / 5; zł5++)
                    {
                        if (zł1 + 2 * zł2 + 5 * zł5 == kwota)
                        {
                            kombinacje++;
                            Console.WriteLine($"Kombinacja {kombinacje}: {zł1} x 1 zł + {zł2} x 2 zł + {zł5} x 5 zł");
                        }
                    }
                }
            }

            Console.WriteLine("Liczba różnych kombinacji: " + kombinacje);
        }
        static void Main(string[] args)
        {
            Zad15();
        }
    }

}


