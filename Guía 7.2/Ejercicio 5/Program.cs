namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, orden, mayor;

            Console.WriteLine("Ingrese el primer número:");
            num = Convert.ToInt32(Console.ReadLine());
            orden = 1;
            mayor = num;

            Console.WriteLine("Ingrese el segundo número:");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num > mayor)
            {
                mayor = num;
                orden = 2;
            }

            Console.WriteLine("Ingrese el tercer número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > mayor)
            {
                mayor = num;
                orden = 3;
            }


            Console.WriteLine("Ingrese el tercer número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > mayor)
            {
                mayor = num;
                orden = 4;
            }


            Console.WriteLine("Ingrese el cuarto número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num > mayor)
            {
                mayor = num;
                orden = 5;
            }

            Console.WriteLine($"El mayor número es: {mayor} y se ingresó en el {orden}º orden.");
           
        }
    }
}
