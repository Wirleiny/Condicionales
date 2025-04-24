using System;

namespace ejer._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Introduce el precio del artículo: ");
            double precio = double.Parse(Console.ReadLine());

           
            double descuento = 0;

           
            if (precio >= 1000 && precio <= 5000)
            {
                descuento = 0.03;
            }
            else if (precio >= 5001 && precio <= 10000)
            {
                descuento = 0.05; 
            }
            else if (precio >= 10001 && precio <= 15000)
            {
                descuento = 0.08; 
            }
            else if (precio >= 15001 && precio <= 20000)
            {
                descuento = 0.10; 
            }

           
            double montoDescuento = precio * descuento;
            double precioFinal = precio - montoDescuento;

           
            Console.WriteLine($"Precio del artículo: {precio:C2}");
            Console.WriteLine($"Descuento aplicado: {montoDescuento:C2}");
            Console.WriteLine($"Precio final: {precioFinal:C2}");
        }
    } 
}


   