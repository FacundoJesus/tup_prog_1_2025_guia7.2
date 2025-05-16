using System.Xml;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2, nombre3;
            int num1, num2, num3;

            Console.WriteLine("Ingrese el nombre del 1º alumno:");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese el número de libreta del 1º alumno:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del 2º alumno:");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese el número de libreta del 2º alumno:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del 3º alumno:");
            nombre3 = Console.ReadLine();
            Console.WriteLine("Ingrese el número de libreta del 3º alumno:");
            num3 = Convert.ToInt32(Console.ReadLine());

          
            if (num1 > num2)
            {
                if (num3 > num1)
                {
                    Console.WriteLine($"Alumno: {nombre3} Nota: {num3}");
                    Console.WriteLine($"Alumno: {nombre1} Nota: {num1}");
                    Console.WriteLine($"Alumno: {nombre2} Nota: {num2}");
                }
                else
                {
                    if (num3 > num2)
                    {
                        Console.WriteLine($"Alumno: {nombre1} Nota: {num1}");
                        Console.WriteLine($"Alumno: {nombre3} Nota: {num3}");
                        Console.WriteLine($"Alumno: {nombre2} Nota: {num2}");
                    }
                    else
                    {
                        Console.WriteLine($"Alumno: {nombre1} Nota: {num1}");
                        Console.WriteLine($"Alumno: {nombre2} Nota: {num2}");
                        Console.WriteLine($"Alumno: {nombre3} Nota: {num3}");
                    }
                }
            }

            else
            {
                if (num3 > num2)
                {
                    Console.WriteLine($"Alumno: {nombre3} Nota: {num3}");
                    Console.WriteLine($"Alumno: {nombre2} Nota: {num2}");
                    Console.WriteLine($"Alumno: {nombre1} Nota: {num1}");
                }
                else
                {
                    if (num3 > num1)
                    {
                        Console.WriteLine($"Alumno: {nombre2} Nota: {num2}");
                        Console.WriteLine($"Alumno: {nombre3} Nota: {num3}");
                        Console.WriteLine($"Alumno: {nombre1} Nota: {num1}");
                    }
                    else
                    {
                        Console.WriteLine($"Alumno: {nombre2} Nota: {num2}");
                        Console.WriteLine($"Alumno: {nombre1} Nota: {num1}");
                        Console.WriteLine($"Alumno: {nombre3} Nota: {num3}");
                    }
                }
            }
        }
    }
}
