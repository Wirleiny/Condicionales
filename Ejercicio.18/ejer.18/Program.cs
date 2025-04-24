namespace ejer._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la producción del lunes:");
            double produccionLunes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del martes:");
            double produccionMartes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del miércoles:");
            double produccionMiércoles = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del jueves:");
            double produccionJueves = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del viernes:");
            double produccionViernes = Convert.ToDouble(Console.ReadLine());

            double totalProduccion = produccionLunes + produccionMartes + produccionMiércoles + produccionJueves + produccionViernes;
            double promedioProduccion = totalProduccion / 5;
            double incentivo = 0;

            if (promedioProduccion >= 20000)
            {
                incentivo = 3000;
            }

            Console.WriteLine("Producción total: " + totalProduccion);
            Console.WriteLine("Promedio de producción: " + promedioProduccion);
            Console.WriteLine("Incentivo: " + incentivo);
        }
    }
}
    

