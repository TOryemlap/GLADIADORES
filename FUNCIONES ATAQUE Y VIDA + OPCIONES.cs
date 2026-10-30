using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
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
            int turno = 1;
            for (int i = 1; i <= turno; i++)
            {
                if (turno % 2 == 0)
                {
                    Console.WriteLine("Turno del Gladiador2."); //Cambiar por el nombre del jugador cuando se haga la funcion.
                }
                else
                {
                    Console.WriteLine("Turno del Gladiador1.");
                }
                Console.WriteLine("¿Que acción realiza? 1. Ataque 2. Recuperar vida");
                int Accion = int.Parse(Console.ReadLine());
                int VidaGladiador1 = 15;
                int VidaGladiador2 = 18;
                int VidaMaxima = 25;
                int Ataque1 = 15;
                int Ataque2 = 15;
                int defen1 = 5;
                int defen2 = 5;
                switch (Accion)
                {
                    //SE ELIGE ATAQUE
                    case 1:
                        Console.WriteLine("Seleccionó ATAQUE.");
                        VidaGladiador2 = Ataque_ju1(Ataque1, Ataque2, VidaGladiador2, VidaGladiador1, defen1, defen2, turno);


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
            }
        }
    }
}
