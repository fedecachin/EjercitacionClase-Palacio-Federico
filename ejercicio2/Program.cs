using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar un número y mostrar el cuadrado y
            //el cubo del mismo. Se debe validar que el número sea mayor
            //que cero, caso contrario, mostrar el
            //mensaje: "ERROR. ¡Reingresar número!".

            double numeroIngresado;
            bool esNumerico;
            int bandera = 1;
            double cuadrado;
            double cubo;

            Console.WriteLine("ingrese un numero");
            do
            {
                if (bandera == 0)
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
                esNumerico = double.TryParse(Console.ReadLine(), out numeroIngresado);

                bandera = 0;

            } while (esNumerico);

            cuadrado = Math.Pow(numeroIngresado, 2);
            cubo = Math.Pow(numeroIngresado, 3);

            Console.WriteLine($"numero al cuadrado {cuadrado}. numero al cubo {cubo}");
        }
    }
}
