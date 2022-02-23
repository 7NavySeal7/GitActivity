using System;

namespace _1._algoritmoRandom
{
    class Program
    {
        static void NumeroAleatorio()
        {
            Random generador = new Random();
            int num = generador.Next(1, 100);
            Console.WriteLine($"El número generado es: {num}");

            for (int f = 1; f <= 10; f++)
            {
                Console.Write("[Adivine el número] Ingrese un número entre 1 y 100: ");
                int valor = int.Parse(Console.ReadLine());
            }

            static void Main(string[] args)
            {
                NumeroAleatorio();
            }
        }
    }
}