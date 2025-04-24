namespace ejer._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el sueldo del empleado:");
            double sueldo = Convert.ToDouble(Console.ReadLine());

          
            double AFP = sueldo * 0.0287;
            double SFS = sueldo * 0.03;
            double ISR = 0;

           
            if (sueldo <= 34685)
            {
               
                Console.WriteLine("ISR: N/A");
            }
            else if (sueldo <= 52027.41)
            {
               
                ISR = (sueldo - 34685) * 0.15;
            }
            else if (sueldo <= 72260.25)  
            {
                
                ISR = 31216 + (sueldo - 52027.41) * 0.20;
            }
            else
            {
               
                ISR = 79776 + (sueldo - 72260.25) * 0.25;
            }

           
            double sueldoNeto = sueldo - (AFP + SFS + ISR);

           
            Console.WriteLine("Sueldo: " + sueldo);
            Console.WriteLine("Descuento de AFP: " + AFP);
            Console.WriteLine("Descuento de SFS: " + SFS);
            Console.WriteLine("Descuento de ISR: " + ISR);
            Console.WriteLine("Sueldo Neto: " + sueldoNeto);
        }
    }
}
        
  