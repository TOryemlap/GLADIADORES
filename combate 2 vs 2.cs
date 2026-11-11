using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                string Nom_Equi1 = "Los Leones";
                string Nom_Equi2 = "Hierro Sur";

                string Gladiador1_Equi1 = "Máximo";
                string Gladiador2_Equi1 = "Brisa";
                string Gladiador1_Equi2 = "Tauro";
                string Gladiador2_Equi2 = "Pinta";

                int PV_A_a = 20;
                int PV_A_b = 20;
                int PV_B_a = 20;
                int PV_B_b = 20;

                int VidaMax_A_a = PV_A_a;
                int VidaMax_A_b = PV_A_b;
                int VidaMax_B_a = PV_B_a;
                int VidaMax_B_b = PV_B_b;

                int ATK_A_a = 15;
                int ATK_A_b = 15;
                int ATK_B_a = 15;
                int ATK_B_b = 15;

                int DEF_A_a = 5;
                int DEF_A_b = 5;
                int DEF_B_a = 5;
                int DEF_B_b = 5;

                int Total_dano_Aa = 0;
                int Total_dano_Ab = 0;
                int Total_dano_Ba = 0;
                int Total_dano_Bb = 0;

                int turno = 1;

                int Recuperaciones_A_a = 0;
                int Recuperaciones_A_b = 0;
                int Recuperaciones_B_a = 0;
                int Recuperaciones_B_b = 0;

                int opcion = 0;
                int objetivo = 0;
                int dano = 0;
                int vidaElegida = 0;
                int ataqueElegido = 0;
                int defensaElegida = 0;
                int recuperaciones = 0;
                int vidaMaximaElegida = 0;

                 while ((PV_A_a > 0 || PV_A_b > 0) && (PV_B_a > 0 || PV_B_b > 0))
                {
                    Console.WriteLine("\n================ TURNO " + turno + " ================");

                    Console.WriteLine("EQUIPO 1: " + Nom_Equi1);
                    Console.WriteLine("1. " + Gladiador1_Equi1 + " - Vida: " + PV_A_a + "/" + VidaMax_A_a);
                    Console.WriteLine("2. " + Gladiador2_Equi1 + " - Vida: " + PV_A_b + "/" + VidaMax_A_b);

                    Console.WriteLine("EQUIPO 2: " + Nom_Equi2);
                    Console.WriteLine("1. " + Gladiador1_Equi2 + " - Vida: " + PV_B_a + "/" + VidaMax_B_a);
                    Console.WriteLine("2. " + Gladiador2_Equi2 + " - Vida: " + PV_B_b + "/" + VidaMax_B_b);

                    if (turno % 2 != 0)
                    {
                        Console.WriteLine("Juega el equipo 1 (" + Nom_Equi1 + ").");
                        Console.WriteLine("1. Atacar");
                        Console.WriteLine("2. Recuperar vida");
                        opcion = int.Parse(Console.ReadLine());

                        if (opcion == 1)
                        {
                            Console.WriteLine("¿Qué gladiador ataca? 1 o 2");
                            int atacante = int.Parse(Console.ReadLine());

                            while ((atacante != 1 && atacante != 2) ||
                                   (atacante == 1 && PV_A_a <= 0) ||
                                   (atacante == 2 && PV_A_b <= 0))
                            {
                                Console.WriteLine("Gladiador fuera de combate, eliga otro.");
                                atacante = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("¿A qué gladiador rival ataca? 1 o 2");
                            objetivo = int.Parse(Console.ReadLine());

                            while ((objetivo != 1 && objetivo != 2) ||
                                   (objetivo == 1 && PV_B_a <= 0) ||
                                   (objetivo == 2 && PV_B_b <= 0))
                            {
                                Console.WriteLine("Objetivo fuera de combate, eliga otro.");
                                objetivo = int.Parse(Console.ReadLine());
                            }

                            if (atacante == 1)
                            {
                                ataqueElegido = ATK_A_a;
                                Console.WriteLine(Gladiador1_Equi1 + " ataca.");
                            }
                            else
                            {
                                ataqueElegido = ATK_A_b;
                                Console.WriteLine(Gladiador2_Equi1 + " ataca.");
                            }

                            if (objetivo == 1)
                            {
                                defensaElegida = DEF_B_a;
                                vidaElegida = PV_B_a;
                            }
                            else
                            {
                                defensaElegida = DEF_B_b;
                                vidaElegida = PV_B_b;
                            }

                            dano = ataqueElegido - defensaElegida;

                            if (dano < 1)
                            {
                                dano = 1;
                            }

                            if (dano > vidaElegida)
                            {
                                dano = vidaElegida;
                            }

                            vidaElegida = vidaElegida - dano;

                            if (objetivo == 1)
                            {
                                PV_B_a = vidaElegida;
                            }
                            else
                            {
                                PV_B_b = vidaElegida;
                            }

                            if (atacante == 1)
                            {
                                Total_dano_Aa = Total_dano_Aa + dano;
                            }
                            else
                            {
                                Total_dano_Ab = Total_dano_Ab + dano;
                            }

                            Console.WriteLine("Daño realizado: " + dano);

                            if (vidaElegida == 0)
                            {
                                Console.WriteLine("¡El gladiador rival quedó fuera de combate!");
                            }
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("¿Qué gladiador recupera vida? 1 o 2");
                            int elegido = int.Parse(Console.ReadLine());

                            while ((elegido != 1 && elegido != 2) ||
                                   (elegido == 1 && PV_A_a <= 0) ||
                                   (elegido == 2 && PV_A_b <= 0))
                            {
                                Console.WriteLine("Gladiador fuera de combate, eliga otro.");
                                elegido = int.Parse(Console.ReadLine());
                            }

                            if (elegido == 1)
                            {
                                recuperaciones = Recuperaciones_A_a;
                                vidaElegida = PV_A_a;
                                vidaMaximaElegida = VidaMax_A_a;
                            }
                            else
                            {
                                recuperaciones = Recuperaciones_A_b;
                                vidaElegida = PV_A_b;
                                vidaMaximaElegida = VidaMax_A_b;
                            }

                            if (recuperaciones < 2 && vidaElegida < vidaMaximaElegida)
                            {
                                vidaElegida = vidaElegida + 5;

                                if (vidaElegida > vidaMaximaElegida)
                                {
                                    vidaElegida = vidaMaximaElegida;
                                }

                                if (elegido == 1)
                                {
                                    PV_A_a = vidaElegida;
                                    Recuperaciones_A_a++;
                                }
                                else
                                {
                                    PV_A_b = vidaElegida;
                                    Recuperaciones_A_b++;
                                }

                                Console.WriteLine("Vida recuperada. Ahora tiene " + vidaElegida + " puntos.");
                            }
                            else
                            {
                                Console.WriteLine("No puede recuperar vida (vida llena). Repite turno.");
                                turno--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opción no valida. Intente de nuevo.");
                            turno--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Juega el equipo 2 (" + Nom_Equi2 + ").");
                        Console.WriteLine("1. Atacar");
                        Console.WriteLine("2. Recuperar vida");
                        opcion = int.Parse(Console.ReadLine());

                        if (opcion == 1)
                        {
                            Console.WriteLine("¿Qué gladiador ataca? 1 o 2");
                            int atacante = int.Parse(Console.ReadLine());

                            while ((atacante != 1 && atacante != 2) ||
                                   (atacante == 1 && PV_B_a <= 0) ||
                                   (atacante == 2 && PV_B_b <= 0))
                            {
                                Console.WriteLine("Gladiador fuera de combate, eliga otro.");
                                atacante = int.Parse(Console.ReadLine());
                            }

                            Console.WriteLine("¿A qué gladiador rival ataca? 1 o 2");
                            objetivo = int.Parse(Console.ReadLine());

                            while ((objetivo != 1 && objetivo != 2) ||
                                   (objetivo == 1 && PV_A_a <= 0) ||
                                   (objetivo == 2 && PV_A_b <= 0))
                            {
                                Console.WriteLine("Objetivo fuera de combate, eliga otro.");
                                objetivo = int.Parse(Console.ReadLine());
                            }

                            if (atacante == 1)
                            {
                                ataqueElegido = ATK_B_a;
                                Console.WriteLine(Gladiador1_Equi2 + " ataca.");
                            }
                            else
                            {
                                ataqueElegido = ATK_B_b;
                                Console.WriteLine(Gladiador2_Equi2 + " ataca.");
                            }

                            if (objetivo == 1)
                            {
                                defensaElegida = DEF_A_a;
                                vidaElegida = PV_A_a;
                            }
                            else
                            {
                                defensaElegida = DEF_A_b;
                                vidaElegida = PV_A_b;
                            }

                            dano = ataqueElegido - defensaElegida;

                            if (dano < 1)
                            {
                                dano = 1;
                            }

                            if (dano > vidaElegida)
                            {
                                dano = vidaElegida;
                            }

                            vidaElegida = vidaElegida - dano;

                            if (objetivo == 1)
                            {
                                PV_A_a = vidaElegida;
                            }
                            else
                            {
                                PV_A_b = vidaElegida;
                            }

                            if (atacante == 1)
                            {
                                Total_dano_Ba = Total_dano_Ba + dano;
                            }
                            else
                            {
                                Total_dano_Bb = Total_dano_Bb + dano;
                            }

                            Console.WriteLine("Daño realizado: " + dano);

                            if (vidaElegida == 0)
                            {
                                Console.WriteLine("¡El gladiador rival quedo fuera de combate!");
                            }
                        }
                        else if (opcion == 2)
                        {
                            Console.WriteLine("¿Qué gladiador recupera vida? 1 o 2");
                            int elegido = int.Parse(Console.ReadLine());

                            while ((elegido != 1 && elegido != 2) ||
                                   (elegido == 1 && PV_B_a <= 0) ||
                                   (elegido == 2 && PV_B_b <= 0))
                            {
                                Console.WriteLine("Gladiador fuera de combate, eliga otro.");
                                elegido = int.Parse(Console.ReadLine());
                            }

                            if (elegido == 1)
                            {
                                recuperaciones = Recuperaciones_B_a;
                                vidaElegida = PV_B_a;
                                vidaMaximaElegida = VidaMax_B_a;
                            }
                            else
                            {
                                recuperaciones = Recuperaciones_B_b;
                                vidaElegida = PV_B_b;
                                vidaMaximaElegida = VidaMax_B_b;
                            }

                            if (recuperaciones < 2 && vidaElegida < vidaMaximaElegida)
                            {
                                vidaElegida = vidaElegida + 5;

                                if (vidaElegida > vidaMaximaElegida)
                                {
                                    vidaElegida = vidaMaximaElegida;
                                }

                                if (elegido == 1)
                                {
                                    PV_B_a = vidaElegida;
                                    Recuperaciones_B_a++;
                                }
                                else
                                {
                                    PV_B_b = vidaElegida;
                                    Recuperaciones_B_b++;
                                }

                                Console.WriteLine("Vida recuperada. Ahora tiene " + vidaElegida + " puntos.");
                            }
                            else
                            {
                                Console.WriteLine("No puede recuperar vida (vida llena). Repite turno.");
                                turno--;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Opción no valida, intente de nuevo.");
                            turno--;
                        }
                    }

                    turno++;
                }
                Console.WriteLine("\n================ FIN DEL COMBATE ================");

                if (PV_A_a > 0 || PV_A_b > 0)
                {
                    Console.WriteLine("¡El combate ha acabado! Gana el equipo: " + Nom_Equi1);
                }
                else
                {
                    Console.WriteLine("¡El combate ha acabado! Gana el equipo: " + Nom_Equi2);
                }

                Console.WriteLine("Daño total acumulado por cada gladiador:");
                Console.WriteLine(Gladiador1_Equi1 + ": " + Total_dano_Aa + " de daño");
                Console.WriteLine(Gladiador2_Equi1 + ": " + Total_dano_Ab + " de daño");
                Console.WriteLine(Gladiador1_Equi2 + ": " + Total_dano_Ba + " de daño");
                Console.WriteLine(Gladiador2_Equi2 + ": " + Total_dano_Bb + " de daño");
            }
        }
    }