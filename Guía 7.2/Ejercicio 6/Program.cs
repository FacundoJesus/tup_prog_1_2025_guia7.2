namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2;
            int ptos_set1J1, ptos_set1J2, set_ganado_J1, set_ganado_J2, ptos_set2J1, ptos_set2J2, ptos_set3J1, ptos_set3J2;

            Console.WriteLine("Nombre del Jugador 1:");
            nombre1 = Console.ReadLine();
            Console.WriteLine("Nombre del Jugador 2:");
            nombre2 = Console.ReadLine();
            

            Console.WriteLine("Puntos del 1 º set del Jugador 1:");
            ptos_set1J1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Puntos del 1 º set del Jugador 2:");
            ptos_set1J2 = Convert.ToInt32(Console.ReadLine());
            set_ganado_J1 = 0;
            set_ganado_J2 = 0;
            if (ptos_set1J1 > ptos_set1J2)
            {
                set_ganado_J1++;
            }
            else
            {
                set_ganado_J2++;
            }

            Console.WriteLine("Puntos del 2 º set del Jugador 1:");
            ptos_set2J1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Puntos del 2 º set del Jugador 2:");
            ptos_set2J2 = Convert.ToInt32(Console.ReadLine());


            if (ptos_set2J1 > ptos_set2J2)
            {
                set_ganado_J1++;
            }
            else
            {
                set_ganado_J2++;
            }

            Console.WriteLine("Puntos del 3 º set del Jugador 1:");
            ptos_set3J1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Puntos del 3 º set del Jugador 2:");
            ptos_set3J2 = Convert.ToInt32(Console.ReadLine());

            if (ptos_set3J1 > ptos_set3J2)
            {
                set_ganado_J1++;
            }
            else
            {
                set_ganado_J2++;
            }

            if (set_ganado_J1 > set_ganado_J2)
            {
                Console.WriteLine("El ganador del Juego es el Jugador 1: " + nombre1);
            }
            else
            {
                Console.WriteLine("El ganador del Juego es el Jugador 2: " + nombre2);
            }
        }
    }
}
