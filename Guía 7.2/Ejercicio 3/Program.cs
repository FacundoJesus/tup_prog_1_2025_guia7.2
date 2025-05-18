namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            string nombre1,nombre2,nombre3;
            Console.WriteLine("Ingrese el nombre del 1º alumno:");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del 1º alumno:");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del 2º alumno:");
            nombre2 = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del 2º alumno:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del 3º alumno:");
            nombre3 = Console.ReadLine();
            Console.WriteLine("Ingrese la nota del 3º alumno:");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                if (n3 > n1)
                {
                    Console.WriteLine($"Nombre: {nombre3} , Nota: {n3}");
                    Console.WriteLine($"Nombre: {nombre1} , Nota: {n1}");
                    Console.WriteLine($"Nombre: {nombre2} , Nota: {n2}");
                }
                else 
                {
                    if (n3 > n2)
                    {
                        Console.WriteLine($"Nombre: {nombre1} , Nota: {n1}");
                        Console.WriteLine($"Nombre: {nombre3} , Nota: {n3}");
                        Console.WriteLine($"Nombre: {nombre2} , Nota: {n2}");
                    }
                    else
                    {
                        Console.WriteLine($"Nombre: {nombre1} , Nota: {n1}");
                        Console.WriteLine($"Nombre: {nombre2} , Nota: {n2}");
                        Console.WriteLine($"Nombre: {nombre3} , Nota: {n3}");
                    }
                }
            }
            else
            {
                if (n3 > n2)
                {
                    Console.WriteLine($"Nombre: {nombre3} , Nota: {n3}");
                    Console.WriteLine($"Nombre: {nombre2} , Nota: {n2}");
                    Console.WriteLine($"Nombre: {nombre1} , Nota: {n1}");
                }
                else {
                    if (n3 > n1) 
                    {
                    Console.WriteLine($"Nombre: {nombre2} , Nota: {n2}");
                    Console.WriteLine($"Nombre: {nombre3} , Nota: {n3}");
                    Console.WriteLine($"Nombre: {nombre1} , Nota: {n1}");
                    }
                    else
                    {
                        Console.WriteLine($"Nombre: {nombre2} , Nota: {n2}");
                        Console.WriteLine($"Nombre: {nombre1} , Nota: {n1}");
                        Console.WriteLine($"Nombre: {nombre3} , Nota: {n3}");
                    }
                }
            }





        }
    }
}
