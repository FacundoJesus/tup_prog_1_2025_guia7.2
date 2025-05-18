namespace Ejercicio_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, mayor;

            Console.WriteLine("Ingrese el primer número:");
            num = Convert.ToInt32(Console.ReadLine());

            mayor = num;

            Console.WriteLine("Ingrese el segundo número:");
            num = Convert.ToInt32(Console.ReadLine());
            
            if (num > mayor) {
                mayor = num;
            }
            Console.WriteLine("Ingrese el tercer número:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine("Ingrese el cuarto número:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine("Ingrese el quinto número:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num > mayor)
            {
                mayor = num;
            }
            Console.WriteLine("El mayor número es: " + mayor);
        }
    }
}
