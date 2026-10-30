using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static int ModalidadFun()
        {
            Console.WriteLine("Que modalidad Elige: | 1. 1v1 | 2. 2v2 | 3. 3v3 | 5. 5v5 |");
            int Modalidad = int.Parse(Console.ReadLine());
            return Modalidad;

        }
        static int RecuperarVida(int VidaGladiador1, int VidaGladiador2, int VidaMaxima, int turno)
        {
            Console.WriteLine("Seleccionó RECUPERAR VIDA.");
            if (turno % 2 == 0) //si turno es par = gladiador 2
            {
                if (VidaMaxima - VidaGladiador2 >= 5)
                {
                    int VidaCurada = VidaGladiador2 + 5;
                    return VidaCurada;
                }
                else
                {
                    int Curacion = VidaMaxima - VidaGladiador2;
                    int VidaCurada = VidaGladiador2 + Curacion;
                    return VidaCurada;
                }
            }
            else
                if (VidaMaxima - VidaGladiador1 >= 5)
            {
                int VidaCurada = VidaGladiador1 + 5;
                return VidaCurada;
            }
            else
            {
                int Curacion = VidaMaxima - VidaGladiador1;
                int VidaCurada = VidaGladiador1 + Curacion;
                return VidaCurada;
            }
        }
        static int Ataque_ju1(int VidaGladiador2, int VidaGladiador1, int Ataque1, int Ataque2, int defen2, int defen1, int turno)
        {
            if (turno % 2 == 0)
            {
                if (VidaGladiador2 > 0)
                {
                    Ataque1 = Ataque1 - defen2;
                    if (Ataque1 < 1)
                    {
                        Ataque1 = 1;
                    }
                    if (Ataque1 > VidaGladiador2)
                    {
                        VidaGladiador2 = 0;
                        Ataque1 = VidaGladiador2;
                    }
                    else
                    {
                        VidaGladiador2 = VidaGladiador2 - Ataque1;
                    }
                }
            }
            else
            {
                if (VidaGladiador1 > 0)
                {
                    Ataque2 = Ataque2 - defen1;
                    if (Ataque2 < 1)
                    {
                        Ataque2 = 1;
                    }
                    if (Ataque2 > VidaGladiador1)
                    {
                        VidaGladiador1 = 0;
                        Ataque2 = VidaGladiador1;
                    }
                    else
                    {
                        VidaGladiador1 = VidaGladiador1 - Ataque2;
                    }
                }
            }
            return VidaGladiador2;
        }
        static void Main(string[] args)
        {
            string NombreGladiador1_Eq1 = "";
            string NombreGladiador2_Eq1 = "";
            string NombreGladiador3_Eq1 = "";
            string NombreGladiador4_Eq1 = "";
            string NombreGladiador5_Eq1 = "";
            string NombreGladiador1_Eq2 = "";
            string NombreGladiador2_Eq2 = "";
            string NombreGladiador3_Eq2 = "";
            string NombreGladiador4_Eq2 = "";
            string NombreGladiador5_Eq2 = "";
            int Modalidad = ModalidadFun();
            Console.WriteLine("Crea el equipo el jugador 1.");
            Console.Write("Introduzca el nombre de su equipo: ");
            String NombreEquipo1 = Console.ReadLine();
            if (Modalidad == 5)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                NombreGladiador2_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 3: ");
                NombreGladiador3_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 4: ");
                NombreGladiador4_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 5: ");
                NombreGladiador5_Eq1 = Console.ReadLine();
            }
            else if (Modalidad == 3)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                NombreGladiador2_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 3: ");
                NombreGladiador3_Eq1 = Console.ReadLine();
            }
            else if (Modalidad == 2)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq1 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                NombreGladiador2_Eq1 = Console.ReadLine();
            }
            else if (Modalidad == 1)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq1 = Console.ReadLine();
            }
            Console.WriteLine("Crea el equipo el jugador 2.");
            Console.Write("Introduzca el nombre de su equipo: ");
            String NombreEquipo2 = Console.ReadLine();
            if (Modalidad == 5)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                NombreGladiador2_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 3: ");
                NombreGladiador3_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 4: ");
                NombreGladiador4_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 5: ");
                NombreGladiador5_Eq2 = Console.ReadLine();
            }
            else if (Modalidad == 3)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                NombreGladiador2_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 3: ");
                NombreGladiador3_Eq2 = Console.ReadLine();
            }
            else if (Modalidad == 2)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq2 = Console.ReadLine();
                Console.Write("Introduzca el nombre del Gladiador 2: ");
                NombreGladiador2_Eq2 = Console.ReadLine();
            }
            else if (Modalidad == 1)
            {
                Console.Write("Introduzca el nombre del Gladiador 1: ");
                NombreGladiador1_Eq2 = Console.ReadLine();
            }
            int VidaGladiador1 = 15;
            int VidaGladiador2 = 18;
            int VidaMaxima = 25;
            int Ataque1 = 15;
            int Ataque2 = 15;
            int defen1 = 5;
            int defen2 = 5;
            int turno = 1;
            while (VidaGladiador1 > 0 || VidaGladiador2 > 0)
            {
                if (turno % 2 == 0)
                {
                    Console.WriteLine("====================TURNO " + turno + "====================");
                    Console.WriteLine("Turno de " + NombreGladiador1_Eq1);
                    Console.WriteLine("HP = " + VidaGladiador2);
                }
                else
                {
                    Console.WriteLine("====================TURNO " + turno + "====================");
                    Console.WriteLine("Turno de " + NombreGladiador1_Eq2);
                    Console.WriteLine();
                    Console.WriteLine("HP = " + VidaGladiador1);
                }
                Console.WriteLine("¿Que acción realiza? 1. Ataque 2. Recuperar vida");
                int Accion = int.Parse(Console.ReadLine());
                switch (Accion)
                {
                    //SE ELIGE ATAQUE
                    case 1:
                        Console.WriteLine("Seleccionó ATAQUE.");
                        if (turno % 2 == 0)
                        {
                            int Vida_1antes = VidaGladiador1;
                            VidaGladiador1 = Ataque_ju1(Ataque1, Ataque2, VidaGladiador2, VidaGladiador1, defen1, defen2, turno);
                            int Puntos = Vida_1antes - VidaGladiador1;
                            Console.WriteLine("Ataca el Gladiador2...");
                            Console.WriteLine();
                            Console.WriteLine("Gladiador1 queda con " + VidaGladiador1 + " puntos de vida.");
                            Console.WriteLine("Gladiador2 suma " + Puntos + " puntos.");
                            Console.WriteLine();
                        }
                        else
                        {
                            int Vida_2antes = VidaGladiador2;
                            VidaGladiador2 = Ataque_ju1(Ataque1, Ataque2, VidaGladiador2, VidaGladiador1, defen1, defen2, turno);
                            int Puntos = Vida_2antes - VidaGladiador2;
                            Console.WriteLine("Ataca el Gladiador1...");
                            Console.WriteLine();
                            Console.WriteLine("Gladiador2 queda con " + VidaGladiador2 + " puntos de vida.");
                            Console.WriteLine("Gladiador1 suma " + Puntos + " puntos.");
                            Console.WriteLine();
                        }
                        break;

                    //SE ELIGE RECUPERAR VIDA
                    case 2:
                        {
                            int VidaCurada = RecuperarVida(VidaGladiador1, VidaGladiador2, VidaMaxima, turno);
                            Console.WriteLine("La vida del gladiador ahora es de " + VidaCurada + " puntos de vida.");
                            break;
                        }

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
                turno++;
            }
        }
    }
}
