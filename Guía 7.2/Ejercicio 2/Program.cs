namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Ingrese el número a evaluar:");
            num = Convert.ToDouble(Console.ReadLine());

            if (num < 0) {
                Console.WriteLine("El número es NEGATIVO");
            }
            else if (num == 0){
                Console.WriteLine("El número es CERO");
            }
            else {
                Console.WriteLine("El número es POSITIVO");
            }


        }
    }
}
