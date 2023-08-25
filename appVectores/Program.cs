using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.Write("Ingrese el tamaño del vector: ");
            int tamaño = int.Parse(Console.ReadLine());

            int[] vector = new int[tamaño];

            Console.WriteLine("Ingrese los elementos del vector:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write($"Elemento {i + 1}: ");
                vector[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("elementos ingresado:");

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write(vector[i] + " ");
            }
            int suma = 0;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;

            for (int i = 0; i < tamaño; i++)
            {
                suma += vector[i];
                maximo = Math.Max(maximo, vector[i]);
                minimo = Math.Min(minimo, vector[i]);
            }

            double promedio = (double)suma / tamaño;

            Console.WriteLine("\nResultados:");
            Console.WriteLine($"Suma de elementos: {suma}");
            Console.WriteLine($"Promedio de elementos: {promedio}");
            Console.WriteLine($"Valor máximo: {maximo}");
            Console.WriteLine($"Valor mínimo: {minimo}");
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed.ToString("hh\\:mm\\:ss\\.fff"));

            Console.ReadKey();
        }
    }
}
