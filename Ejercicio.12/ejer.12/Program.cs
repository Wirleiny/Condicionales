namespace ejer._12
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduce un número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                Console.WriteLine("El número es positivo");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo");
            }
            else
            {
                Console.WriteLine("El número es cero");
            }
        }
    }
}
       

