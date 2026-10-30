using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Modalidad = 5
            Console.WriteLine("Crea el equipo el jugador 1.");
            Console.Write("Introduzca el nombre de su equipo: ");
            String NombreEquipo = Console.ReadLine();
            if (Modalidad == 5)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                String NombreGladiador1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                String NombreGladiador2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 3: ");
                String NombreGladiador3 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 4: ");
                String NombreGladiador4 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 5: ");
                String NombreGladiador5 = Console.ReadLine();
            }
            else if (Modalidad == 3)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                String NombreGladiador1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                String NombreGladiador2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 3: ");
                String NombreGladiador3 = Console.ReadLine();
            }
            else if (Modalidad == 2)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                String NombreGladiador1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                String NombreGladiador2 = Console.ReadLine();
            }
            else if (Modalidad == 1)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                String NombreGladiador1 = Console.ReadLine();
            }
    }
}
