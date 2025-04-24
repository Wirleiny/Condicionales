namespace ejer._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine(numero + " es un número par.");
            }
            else
            {
                Console.WriteLine(numero + " es un número impar.");
            }
        }
    }
}
