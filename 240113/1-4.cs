using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _240113
{
    public class NaszWyjatekException : Exception
    {
        public NaszWyjatekException()
        {
        }

        public NaszWyjatekException(string message) 
            : base(message)
        {
            
        }
        public NaszWyjatekException(String message, Exception innerException)
            : base(message, innerException)
        {
            Console.WriteLine("Blad");
            throw innerException; 
        }
        NaszWyjatekException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }
    }
    internal class Program
    {
        static void metoda23()
        {
            throw new NotImplementedException("NIE zaimplementowana");
        }
        static void Main(string[] args)
        {
            /*
            int x;
            int y=0;
            int z=10;
            
            try
            {
                
                x = z / y;
            }
            catch (DivideByZeroException q)
            {
                Console.WriteLine("Nie dziel przez zero  "+q.Message);
            }
            finally
            {
                Console.WriteLine("Koniec");
            }
            try
            {
                metoda23();
            }
            catch (NotImplementedException qq)
            {
                Console.WriteLine(qq.Message);
            }
            */
            int x = 2;
            int y = 0;


            try
            {
                int z = x / y;

                      throw new NaszWyjatekException("Nie mnoz przez zero");

                
            }
            catch(DivideByZeroException c)
            {
                Console.WriteLine("Ej no co ty "+c.Message);
            }
            catch (NaszWyjatekException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {

                metoda23();
               int z = x / y;
                if (z != 2)
                    throw new NaszWyjatekException("74 linijka");

                throw new NaszWyjatekException("Nie dziel przez zero", new DivideByZeroException("blad dzielenia przez zero"));
            }
            catch (NaszWyjatekException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Błąd : "+ ex.Message);
            }
            Console.ReadKey();
        }
    }
}
