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
                if (valor > num)
                {
                    Console.WriteLine("El número ingresado es mayor");
                }
                else if (valor < num)
                {
                    Console.WriteLine("El número ingresado es menor");
                }
                else
                {
                    Console.WriteLine("El número ingresado es correcto ¡Felicidades!");
                    Console.WriteLine($"El número de intentos que requirio para acertar son {f}.");
                    Console.Write("¿Desea intentarlo nuevamente? (Escriba 1(Para Confirmar) y 2(Para rechazar)): ");
                    int num1 = int.Parse(Console.ReadLine());
                }
            }

            static void Main(string[] args)
            {
                NumeroAleatorio();
            }
        }
    }
}