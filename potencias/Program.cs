using System;

namespace adivinarNumero
{
    public class Prueba
    {
        public static void Main()
        {
            int n1, n2, contador;

            n2 = 7;
            contador = 1;
            Console.Write("Adivina un número del 1 al 10");
            n1 = Convert.ToInt32(Console.ReadLine());

            while ((n1 != n2) && (contador < 3))
            {
                Console.WriteLine("Número incorrecto");

                Console.Write("Intenta de nuevo, Adivina un número del 1 al 10:");
                n1 = Convert.ToInt32(Console.ReadLine());

                contador++;
            }

            if (n1 == n2)
                Console.WriteLine("Has acertado");
            else
                Console.WriteLine("Has acabado tus intentos");
        }
    }
}