using System;

namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numerosIngresado;
            int maximo = 0;
            int minimo = 0;
            float promedio = 0;
            float promedioFinal;
            bool esNumerico;

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ingrese un numero");
                esNumerico = int.TryParse(Console.ReadLine(), out numerosIngresado);
                promedio += numerosIngresado;

                if (numerosIngresado > maximo)
                {
                    maximo = numerosIngresado;
                }
                else
                {
                    if (numerosIngresado < minimo)
                    {
                        minimo = numerosIngresado;
                    }
                }
            }
            
            if (esNumerico)
            {
                promedioFinal = promedio / 5;

                Console.WriteLine($"el maximo es {maximo}, el minimo es {minimo} y el promedio es {promedioFinal}");
            } else
            {
                Console.WriteLine($"alguno de los datos ingresados no es numerico");
            }
            
        }
    }
}
