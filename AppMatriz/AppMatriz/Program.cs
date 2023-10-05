using System;

namespace AppMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];
            int total = 0;
            int inversa = 0;
            
            int contador = 1;

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(0); c++)
                {
                    matriz[f, c] = contador++;

                    if (f + c == matriz.GetLength(0) - 1)
                    {

                        inversa += matriz[f, c];
                    }
                    if (f == 0 && c == 0)
                    {
                        total = matriz[f, c];
                    }
                    if (f == 0 && c == matriz.GetLength(1) - 1)
                    {
                        total += matriz[f, c];
                    }
                    if (c == 0 && f == matriz.GetLength(0)-1)
                    {
                        total += matriz[f, c];
                    }
                    if (c == matriz.GetLength(1) - 1 && f == matriz.GetLength(0) - 1)
                    {
                        total+= matriz[f, c];
                    }
                    Console.Write($"    {matriz[f,c]}");

                }
                Console.WriteLine("");
            }
            Console.WriteLine($"La suma total de la diagonal inversa de la matriz es {inversa}");
            Console.WriteLine($"La suma total de las esquinas de la matriz es {total}");
            Console.ReadLine();

        }
    }
}
