using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug
{

    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                Console.WriteLine($"La suma de 15 numeros es: {SumarNumeros(numeros)}");
                Console.WriteLine($"La suma de 15 numeros pares es: {SumaPares(numeros)}");
                Console.WriteLine($"La suma de 15 numeros impares es: {SumaImpares(numeros)}");
                Console.WriteLine($"La suma de  numeros random es: {SumaRandoms()}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error:{ex.ToString()}"); ;
            }
        }
        static int SumaPares(List<int> lista)
        {
            //empieza por el 2, 4, 6, 12, 20, 30, 42, 56
            int sumapares = 0;
            foreach (var n in lista)
            {
                if (n % 2 == 0)
                {
                    sumapares += n;
                }

            }
            return sumapares;
        }
        static int SumaImpares(List<int> lista)
        {
            // 1, 4, 9, 16, 25, 36, 49, 64

            int sumaimpares = 0;
            foreach (var n in lista)
            {
                if (!(n % 2 == 0))
                {
                    sumaimpares += n;
                }

            }
            return sumaimpares;
        }
        static int SumaRandoms()
        {
            // 5, 7, 15, 18, 28, 29, 33, 40, 46, 55

            Random random = new Random();
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                suma += random.Next(1, 11);
            }
            return suma;

        }

        static int SumarNumeros(List<int> lista)
        {
            // 1, 3, 6, 10, 15, 21, 28, 36, 45, 55, 66, 78, 91, 105, 120

            int suma = 0;
            foreach (int i in lista)
            {
                suma += i;
            }
            return suma;
        }
    }
}
