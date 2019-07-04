using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer numero:");
            var n1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero:");
            var n2 = Console.ReadLine();

            Console.WriteLine("La suma es: " + suma(n1, n2));
            Console.WriteLine();
            Console.WriteLine("La resta es: " + resta(n1, n2));
            Console.WriteLine();
            Console.WriteLine("La multiplicacion es: " + multiplicacion(n1, n2));
            Console.WriteLine();
            Console.WriteLine("La division es: " + division(n1, n2));
            Console.WriteLine();
            Console.WriteLine("La potencia es: " + potencia(n1, n2));


            Console.ReadKey();

        }

        public static int suma(string n1, string n2)
        {

            return Convert.ToInt32(n1) + Convert.ToInt32(n2);
        }

        public static int resta(string n1, string n2)
        {
            return Convert.ToInt32(n1) - Convert.ToInt32(n2);
        }

        public static int multiplicacion(string n1, string n2)
        {
            return Convert.ToInt32(n1) * Convert.ToInt32(n2);
        }

        public static decimal division(string n1, string n2)
        {
            decimal division = 0;
            try
            {
                return division = decimal.Divide(Convert.ToDecimal(n1), Convert.ToDecimal(n2));
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error en la division");
                Console.WriteLine("Division de {0}.", n1 + "/0 - no se puede calcular");
            }
            return division;

        }

        public static double potencia(string n1, string n2)
        {
            return Math.Pow(Convert.ToDouble(n1), Convert.ToDouble(n2));
        }

    }
}
