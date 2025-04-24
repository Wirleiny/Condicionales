namespace ejer._11
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Introduce la calificación del estudiante: ");
            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 90 && calificacion <= 100)
            {
                Console.WriteLine("Excelente");
            }
            else if (calificacion >= 80 && calificacion <= 89)
            {
                Console.WriteLine("Muy bueno");
            }
            else if (calificacion >= 75 && calificacion <= 79)
            {
                Console.WriteLine("Bueno");
            }
            else if (calificacion >= 70 && calificacion <= 74)
            {
                Console.WriteLine("Regular");
            }
            else
            {
                Console.WriteLine("Deficiente");
            }
          
        }
    }

}


