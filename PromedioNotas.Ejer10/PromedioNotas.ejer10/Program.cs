
using System;

namespace PromedioNotas.ejer10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa la nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la nota 4: ");
            double nota4 = double.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3 + nota4) / 4; 

            string resultado; 
            if (promedio >= 70)
            {
                resultado = "Aprobó"; 
            }
            else
            {
                resultado = "Reprobó"; 
            }

            Console.WriteLine($"Promedio de las notas: {promedio:F2}"); 
            Console.WriteLine($"Resultado: {resultado}"); 
        }
    }
}
