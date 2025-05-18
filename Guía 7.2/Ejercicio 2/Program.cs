namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Ingrese un número:");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                Console.WriteLine("ES NEGATIVO.");

            }
            else
            {
                if (num == 0) {
                    Console.WriteLine("ES CERO.");
                }
                else
                {
                    Console.WriteLine("ES POSITIVO.");
                }
            }
        }
    }
}
