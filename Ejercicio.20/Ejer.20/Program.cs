namespace Ejer._20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("Ingrese el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese el nombre de la materia: ");
                string materia = Console.ReadLine();

                Console.WriteLine("\nIngrese las 4 notas del estudiante:");
                Console.Write("Nota 1: ");
                double nota1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: ");
                double nota2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: ");
                double nota3 = double.Parse(Console.ReadLine());
                Console.Write("Nota 4: ");
                double nota4 = double.Parse(Console.ReadLine());

                double promedio = (nota1 + nota2 + nota3 + nota4) / 4;
                string resultado = "";
                double calificacionFinal = promedio;

                Console.WriteLine($"\nPromedio de las notas: {promedio}");

                if (promedio >= 70)
                {
                    resultado = "Aprobado";
                    Console.WriteLine($"El estudiante {nombre} ha aprobado la materia {materia} con un promedio de {promedio}. No necesita completivo ni extraordinario.");
                }
                else
                {
                    Console.WriteLine("Bienvenido al completivo.");
                    Console.WriteLine("Ingrese la nota del examen completivo:");
                    double notaCompletivo = double.Parse(Console.ReadLine());
                    double completivo = (promedio * 0.5) + (notaCompletivo * 0.5);

                    calificacionFinal = completivo;

                    Console.WriteLine($"Resultado del completivo: {calificacionFinal}");

                    if (completivo < 70)
                    {
                        Console.WriteLine("Bienvenido al extraordinario.");
                        Console.WriteLine("Ingrese la nota del examen extraordinario:");
                        double notaExtraordinario = double.Parse(Console.ReadLine());
                        double extraordinario = (promedio * 0.3) + (notaExtraordinario * 0.7);
                        calificacionFinal = extraordinario;

                        Console.WriteLine($"Resultado del extraordinario: {calificacionFinal}");
                    }
                }

                Console.WriteLine("\nResultados:");
                Console.WriteLine($"Estudiante: {nombre}");
                Console.WriteLine($"Materia: {materia}");
                Console.WriteLine($"Calificación final: {calificacionFinal}");
                Console.WriteLine($"Situación: {(calificacionFinal >= 70 ? "Aprobado" : "Reprobado")}");
            }
        }
    }
}

