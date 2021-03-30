using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresNumericosEjercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numeroDecimal;
            Console.WriteLine("Ingrese un numero con varios decimales");
            var numero = Console.ReadLine();
            if (!decimal.TryParse(numero, out numeroDecimal))
            {
                Console.WriteLine("Debe ingresar un número decimal");
            }
            else
            {
                Console.WriteLine($"El numero que ud. ingresó es: {numero}, y " +
                    $"redondeado a dos decimales es: {Math.Floor(numeroDecimal)}");

            }

            Console.ReadKey();
        }
    }
}
