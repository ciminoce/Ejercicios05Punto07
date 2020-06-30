using System;

namespace Ejercicios05Punto07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tabla de conversiones de temperaturas";
            int temperatura1, temperatura2;
            bool hayError = true;
            do
            {
                Console.Write("Ingrese la primer temperatura:");
                while (!int.TryParse(Console.ReadLine(), out temperatura1))
                {
                    Console.WriteLine("Primer temperatura mal ingresada... otra vez por favor");
                }

                Console.Write("Ingrese la segunda temperatura:");
                while (!int.TryParse(Console.ReadLine(), out temperatura2))
                {
                    Console.WriteLine("Segunda temperatura mal ingresada... otra vez por favor");
                }

                if (temperatura1<temperatura2)
                {
                    hayError = false;
                }
                else
                {
                    Console.WriteLine("Primer temperatura es mayor o igual a la segunda temp");
                }

            } while (hayError);

            for (int tempCelsius = temperatura1; tempCelsius <=temperatura2; tempCelsius++)
            {
                var tempFahrenheit = ConvertirFahrenheit(tempCelsius);
                Console.WriteLine($"{tempCelsius} - {tempFahrenheit:N2}");
            }
        }

        private static double ConvertirFahrenheit(int temperatura)
        {
            return 1.8 * temperatura + 32;
        }
    }
}
