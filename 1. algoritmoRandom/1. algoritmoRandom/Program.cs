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


        }
        
        static void Main(string[] args)
        {
            NumeroAleatorio();
        }
    }
}
