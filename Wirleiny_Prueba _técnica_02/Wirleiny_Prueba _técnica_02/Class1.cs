using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wirleiny_Prueba__técnica_02
{
    internal class Class1
    {
        public class Estudiante
        {
            public string Nombre { get; set; }
            public int Edad { get; set; }

            public Estudiante(string nombre, int edad)
            {
                Nombre = nombre;
                Edad = edad;
            }
        }

        public class Asignatura
        {
            public string Nombre { get; set; }
            public double Calificacion { get; set; }

            public Asignatura(string nombre, double calificacion)
            {
                Nombre = nombre;
                Calificacion = calificacion;
            }
        }

        public class RegistroAcademico
        {
            public Estudiante Estudiante { get; set; }
            private List<Asignatura> Asignaturas { get; set; }

            public RegistroAcademico(Estudiante estudiante)
            {
                Estudiante = estudiante;
                Asignaturas = new List<Asignatura>();
            }

            public void AgregarAsignatura(Asignatura asignatura)
            {
                Asignaturas.Add(asignatura);
            }

            public void MostrarRegistro()
            {
                Console.WriteLine($"Estudiante: {Estudiante.Nombre}");
                Console.WriteLine($"Edad: {Estudiante.Edad}");
                Console.WriteLine("Asignaturas:");
                foreach (var asignatura in Asignaturas)
                {
                    Console.WriteLine($"  - {asignatura.Nombre}: {asignatura.Calificacion}");
                }
                Console.WriteLine($"Promedio: {CalcularPromedio():F2}");
            }
            public double CalcularPromedio()
            {
                if (Asignaturas.Count == 0) return 0;

                double suma = 0;
                foreach (var asignatura in Asignaturas)
                {
                    suma += asignatura.Calificacion;
                }
                return suma / Asignaturas.Count;
            }
        }
    }
}