namespace Wirleiny_prueba_técnica_01
{
    using System;

    class Program
    {
        static char[,] teatro = new char[10, 10];

        static void InicializarTeatro()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    teatro[i, j] = 'L';
                }
            }
        }

        static void MostrarMapa()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido al Teatro"); 
           
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(teatro[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void ReservarAsiento()
        {
            int fila, asiento;
            Console.WriteLine("Ingrese la fila (1-10): ");
            fila = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Ingrese el asiento (1-10): ");
            asiento = int.Parse(Console.ReadLine()) - 1;

            if (fila < 0 || fila >= 10 || asiento < 0 || asiento >= 10)
            {
                Console.WriteLine("Error, inténtelo de nuevo.");
                return;
            }

            if (teatro[fila, asiento] == 'L')
            {
                teatro[fila, asiento] = 'X';
                Console.WriteLine("Asiento reservado");
            }
            else
            {
                Console.WriteLine("Este asiento ya está ocupado.");
            }
        }

        static void VerAsientosLibres()
        {
            Console.WriteLine("Asientos libres:");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (teatro[i, j] == 'L')
                    {
                        Console.WriteLine($"Fila {i + 1}, Asiento {j + 1}");
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            InicializarTeatro();

            bool continuar = true;
            while (continuar)
            {
                Console.Clear();
                MostrarMapa();
                Console.WriteLine("\nSeleccione una opción:");
                Console.WriteLine("1. Reservar un asiento");
                Console.WriteLine("2. Ver asientos libres");
                Console.WriteLine("3. Salir");
                Console.Write("Elija una opción (1-3): ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        ReservarAsiento();
                        break;
                    case 2:
                        VerAsientosLibres();
                        break;
                    case 3:
                        continuar = false;
                        Console.WriteLine("\nDisfrute del show");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                if (continuar)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}


