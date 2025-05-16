namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            double n1, n2, n3, condicion, promedio;

            Console.WriteLine("Ingrese la condición de promoción:");
            condicion = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la 1º nota:");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la 2º nota:");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la 3º nota:");
            n3 = Convert.ToDouble(Console.ReadLine());

            promedio = (n1 + n2 + n3) / 3;

            if (promedio > condicion){
                Console.WriteLine("El alumno promociona");
            }
            else {
                Console.WriteLine("El alumno Rinde final");
            }
        }
    }
}
