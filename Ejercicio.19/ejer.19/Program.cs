namespace ejer._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el número de hijos:");
            int numeroHijos = Convert.ToInt32(Console.ReadLine());

            double incentivo = 0;

            if (numeroHijos > 0)
            {
                incentivo = numeroHijos * 500;
            }

            Console.WriteLine("Sueldo: " + sueldo);
            Console.WriteLine("Número de hijos: " + numeroHijos);
            Console.WriteLine("Incentivo total: " + incentivo);
        }
    }
}
    

