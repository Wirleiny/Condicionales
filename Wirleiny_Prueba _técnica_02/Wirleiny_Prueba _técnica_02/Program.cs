using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Wirleiny_Prueba__técnica_02.Class1;

namespace Wirleiny_Prueba__técnica_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<RegistroAcademico> registros = new List<RegistroAcademico>();

            while (true)
            {
                Console.WriteLine("\n--- Menú de Opciones ---");
                Console.WriteLine("1. Crear un estudiante y su registro académico");
                Console.WriteLine("2. Mostrar registros académicos");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                       
                 Console.Write("\nIngrese el nombre del estudiante: ");
                  string nombre = Console.ReadLine();
                  Console.Write("Ingrese la edad del estudiante: ");
                  int edad = int.Parse(Console.ReadLine());
                        Estudiante estudiante = new Estudiante(nombre, edad);
                        RegistroAcademico registro = new RegistroAcademico(estudiante);


                        for (int i = 0; i < 3; i++)
                        {
                            Console.Write($"\nIngrese el nombre de la asignatura {i + 1}: ");
                            string nombreAsignatura = Console.ReadLine();
                            Console.Write("Ingrese la calificación: ");
                            double calificacion = double.Parse(Console.ReadLine());

                            Asignatura asignatura = new Asignatura(nombreAsignatura, calificacion);
                            registro.AgregarAsignatura(asignatura);
                        }

                        registros.Add(registro);
                        Console.WriteLine("\n¡Registrados exitosamente!");
                        break;

                    case 2:

                        if (registros.Count == 0)
                        {
                            Console.WriteLine("\nNo hay registros ingresados.");
                        }
                        else
                        {
                            foreach (var reg in registros)
                            {
                                Console.WriteLine("\n--- Registro Académico ---");
                                reg.MostrarRegistro();
                            }
                        }
                        break;
                    case 3:

                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Solo hay tres opciones, Lea bien y elija una de esas tres.");
                        break;
                }
            }
        }
    }
}


