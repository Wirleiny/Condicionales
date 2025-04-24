using System.ComponentModel.Design;

namespace La_discoteca_ejer8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa tu edad: ");
            int edad = int.Parse(Console.ReadLine());

           
            Console.Write("Ingresa tu sexo (hembra/varon): ");
            string sexo = Console.ReadLine().ToLower();

            if (edad >= 18)
            {
                if (sexo == "hembra")
                {
                    Console.WriteLine("Entras gratis.");
                }
                if (sexo == "varon")
                {
                    Console.WriteLine("Entras pagando.");
                }
            }

            
            if (edad < 18)
            {
                Console.WriteLine("No puedes entrar.");




            }
    }
}
