namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double condicion, nota1, nota2, nota3, promedio;
            Console.WriteLine("Ingrese la condición de promoción");
            condicion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la 1º nota a evaluar:");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la 2º nota a evaluar:");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la 3º nota a evaluar:");
            nota3 = Convert.ToDouble(Console.ReadLine());


            promedio = (nota1 + nota2 + nota3) / 3;

            if (promedio > condicion)
            {
                Console.WriteLine("PROMOCIONA");
            }
            else
            {
                Console.WriteLine("RINDE FINAL");
            }
        }
    }
}
