namespace ejer._16
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

            int mayor, medio, menor;

            if (numero1 > numero2 && numero1 > numero3)
            {
                mayor = numero1;
                if (numero2 > numero3)
                {
                    medio = numero2;
                    menor = numero3;
                }
                else
                {
                    medio = numero3;
                    menor = numero2;
                }
            }
            else if (numero2 > numero1 && numero2 > numero3)
            {
                mayor = numero2;
                if (numero1 > numero3)
                {
                    medio = numero1;
                    menor = numero3;
                }
                else
                {
                    medio = numero3;
                    menor = numero1;
                }
            }
            else
            {
                mayor = numero3;
                if (numero1 > numero2)
                {
                    medio = numero1;
                    menor = numero2;
                }
                else
                {
                    medio = numero2;
                    menor = numero1;
                }
            }

            Console.WriteLine("Mayor: " + mayor);
            Console.WriteLine("Medio: " + medio);
            Console.WriteLine("Menor: " + menor);
        }
    }
}
    

