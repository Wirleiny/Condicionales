namespace ejer._15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3)
            {
                Console.WriteLine("El número mayor es: " + numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                Console.WriteLine("El número mayor es: " + numero2);
            }
            else
            {
                Console.WriteLine("El número mayor es: " + numero3);
            }
        }
    }
}

