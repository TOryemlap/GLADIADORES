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
        static int Ataque_ju1(int Ataque1, int Ataque2, int VidaGladiador2, int VidaGladiador1, int defen1, int defen2, int turno)
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
                    if (Ataque1 >= VidaGladiador2)
                    {
                        Ataque1 = VidaGladiador2;
                        VidaGladiador2 = 0;

                    }
                    else
                    {
                        VidaGladiador2 = VidaGladiador2 - Ataque1;
                    }
                }
                return Ataque1;
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
                    if (Ataque2 >= VidaGladiador1)
                    {
                        Ataque2 = VidaGladiador1;
                        VidaGladiador1 = 0;

                    }
                    else
                    {
                        VidaGladiador1 = VidaGladiador1 - Ataque2;
                    }
                }
                return Ataque2;
            }

        }
        static void Main(string[] args)
        {
            int Modalidad = ModalidadFun();

            string[] gladiadoresEq1 = new string[Modalidad];
            string[] gladiadoresEq2 = new string[Modalidad];

            //SE CREA EQUIPO 1
            Console.WriteLine("Crea el equipo el jugador 1.");
            Console.Write("Introduzca el nombre de su equipo: ");
            string NombreEquipo1 = Console.ReadLine();

            for (int i = 0; i < Modalidad; i++)
            {
                Console.Write($"Introduzca el nombre del Gladiador {i + 1}: ");
                gladiadoresEq1[i] = Console.ReadLine();
            }

            //SE CREA EQUIPO 2
            Console.WriteLine("Crea el equipo el jugador 2.");
            Console.Write("Introduzca el nombre de su equipo: ");
            string NombreEquipo2 = Console.ReadLine();

            for (int i = 0; i < Modalidad; i++)
            {
                Console.Write($"Introduzca el nombre del Gladiador {i + 1}: ");
                gladiadoresEq2[i] = Console.ReadLine();
            }
            int MVP = 0;
            int VidaGladiador1 = 20;
            int VidaGladiador2 = 20;
            int VidaMaxima = 25; //variable auxiliar
            ///////////////////////////////////////////////////////////////////////////
            //

            // ---EQUIPO 1---
            int[] pv1 = { 0, 0, 0, 0, 0 };
            int[] atk1 = { 0, 0, 0, 0, 0 };
            int[] def1 = { 0, 0, 0, 0, 0 };
            int[] totalDano1 = { 0, 0, 0, 0, 0 };

            //EQUIPO 2
            int[] pv2 = { 0, 0, 0, 0, 0 };
            int[] atk2 = { 0, 0, 0, 0, 0 };
            int[] def2 = { 0, 0, 0, 0, 0 };
            int[] totalDano2 = { 0, 0, 0, 0, 0 };
            int j = 0;
            for (int i = 1; i == Modalidad; i++)
            {
                int ataque = 0;//variable auxiliar
                int defensa = 0;//variable auxiliar
                int vida = 0;//variable auxiliar
                int auxiliar2 = 0;
                int auxiliar1 = 0;
                int cont_pts_2 = 40;
                int cont_pts_1 = 40;
                Console.WriteLine("==================== HORA DE DISTRIBUIR PUNTOS ====================");
                Console.WriteLine();
                Console.WriteLine("tienes 40 puntos exactos para distribuir los por cada gladiador");
                Console.WriteLine();
                Console.WriteLine();
                //definir puntos turno equipo 1 
                do
                {
                    cont_pts_1 = 40;
                    Console.WriteLine("Turno del equipo " + NombreEquipo1 + " de distribuir los puntos para " + gladiadoresEq1[j] + "");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("ataque: (5 min, 20 max): ");
                    ataque = int.Parse(Console.ReadLine());
                    while (ataque < 5 || ataque > 20)
                    {
                        Console.WriteLine();
                        Console.Write("ataque: (5 min, 20 max): ");
                        ataque = int.Parse(Console.ReadLine());
                    }
                    cont_pts_1 = cont_pts_1 - ataque;
                    Console.WriteLine();
                    Console.WriteLine("le quedan " + cont_pts_1 + " puntos");
                    if (cont_pts_1 > 0)
                    {
                        Console.WriteLine("vida: (min 10, max 25): ");
                        vida = int.Parse(Console.ReadLine());
                        while (vida < 10 || vida > 25)
                        {
                            Console.WriteLine();
                            Console.Write("vida: (min 10, max 25): ");
                            vida = int.Parse(Console.ReadLine());
                        }
                        cont_pts_1 = cont_pts_1 - vida;
                        Console.WriteLine();
                        Console.WriteLine("le quedan " + cont_pts_1 + " puntos");
                        if (cont_pts_1 > 0)
                        {
                            Console.WriteLine("defensa: (min 1, max 10): ");
                            defensa = int.Parse(Console.ReadLine());
                            while (defensa < 1 || defensa > 10)
                            {
                                Console.WriteLine();
                                Console.Write("defensa: (min 1, max 10): ");
                                defensa = int.Parse(Console.ReadLine());
                            }
                            cont_pts_1 = cont_pts_1 - defensa;
                            if (cont_pts_1 == 0)
                            {
                                auxiliar1 = 1;
                            }
                            else
                            {
                                if (cont_pts_1 > 0)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("NO LLEGASTE A LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("SOBRE PASASTE LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        else
                        {
                            if (cont_pts_1 > 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("NO LLEGASTE A LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("SOBRE PASASTE LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                Console.WriteLine("");
                            }
                        }
                    }
                    else
                    {
                        if (cont_pts_1 > 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("NO LLEGASTE A LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("SOBRE PASASTE LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                            Console.WriteLine("");
                        }
                    }

                } while (auxiliar1 == 0);
                Console.WriteLine("");
                Console.WriteLine("Puntos distribuidos correctamente");
                Console.WriteLine("");
                pv1[j] = vida;
                atk1[j] = ataque;
                def1[j] = defensa;
                // definir puntos equipo 2 
                Console.WriteLine();
                Console.WriteLine();
                do
                {
                    cont_pts_2 = 40;
                    Console.WriteLine("Turno del equipo " + NombreEquipo2 + " de distribuir los puntos para " + gladiadoresEq2[j] + "");
                    Console.WriteLine();
                    Console.Write("ataque: (5 min, 20 max): ");
                    ataque = int.Parse(Console.ReadLine());
                    while (ataque < 5 || ataque > 20)
                    {
                        Console.WriteLine();
                        Console.Write("ataque: (5 min, 20 max): ");
                        ataque = int.Parse(Console.ReadLine());
                    }
                    cont_pts_2 = cont_pts_2 - ataque;
                    Console.WriteLine();
                    Console.WriteLine("le quedan " + cont_pts_2 + " puntos");
                    if (cont_pts_2 > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("vida: (min 10, max 25): ");
                        vida = int.Parse(Console.ReadLine());
                        while (vida < 10 || vida > 25)
                        {
                            Console.WriteLine();
                            Console.Write("vida: (min 10, max 25): ");
                            vida = int.Parse(Console.ReadLine());
                        }
                        cont_pts_2 = cont_pts_2 - vida;
                        Console.WriteLine();
                        Console.WriteLine("le quedan " + cont_pts_2 + " puntos");
                        if (cont_pts_2 > 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("defensa: (min 1, max 10): ");
                            defensa = int.Parse(Console.ReadLine());
                            while (defensa < 1 || defensa > 10)
                            {
                                Console.WriteLine();
                                Console.Write("defensa: (min 1, max 10): ");
                                defensa = int.Parse(Console.ReadLine());
                            }
                            cont_pts_2 = cont_pts_2 - defensa;
                            if (cont_pts_2 == 0)
                            {
                                auxiliar2 = 1;
                            }
                            else
                            {
                                if (cont_pts_2 > 0)
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("NO LLEGASTE A LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                    Console.WriteLine("");
                                }
                                else
                                {
                                    Console.WriteLine("");
                                    Console.WriteLine("SOBRE PASASTE LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                    Console.WriteLine("");
                                }
                            }
                        }
                        else
                        {
                            if (cont_pts_2 > 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("NO LLEGASTE A LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                Console.WriteLine("");
                            }
                            else
                            {
                                Console.WriteLine("");
                                Console.WriteLine("SOBRE PASASTE LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                                Console.WriteLine("");
                            }
                        }
                    }
                    else
                    {
                        if (cont_pts_2 > 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("NO LLEGASTE A LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("");
                            Console.WriteLine("SOBRE PASASTE LA CANTIDAD DE PUNTOS PARA DISTRIBUIR PORFAVOR INTENTE DEVUELTA");
                            Console.WriteLine("");
                        }
                    }

                } while (auxiliar2 == 0);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Puntos distribuidos correctamente");
                Console.WriteLine("");
                Console.WriteLine("");
                pv2[j] = vida;
                atk2[j] = ataque;
                def2[j] = defensa;
            }
            if (Modalidad == 1)
            {
                int turno = 1;
                int contadorRecuperar = 0;
                int VidaEquipo1 = pv1[0] + pv1[1] + pv1[2] + pv1[3] + pv1[4]; //sumar las vidas de todos los gladiadores
                int VidaEquipo2 = pv2[0] + pv2[1] + pv2[2] + pv2[3] + pv2[4];
                while (VidaEquipo1 > 0 && VidaEquipo2 > 0)
                {
                    if (turno % 2 == 0)
                    {
                        Console.WriteLine("====================TURNO " + turno + "====================");
                        Console.WriteLine("Turno de " + gladiadoresEq2[0]);
                        Console.WriteLine("HP = " + pv2[0]);
                    }
                    else
                    {
                        Console.WriteLine("====================TURNO " + turno + "====================");
                        Console.WriteLine("Turno de " + gladiadoresEq1[0]);
                        Console.WriteLine();
                        Console.WriteLine("HP = " + pv1[0]);
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
                                int Vida_1antes = pv1[0];
                                pv1[0] = Ataque_ju1(atk1[0], atk2[0], pv2[0], pv1[0], def1[0], def2[0], turno);
                                int Puntos = Vida_1antes - pv1[0];
                                if (pv1[0] == Vida_1antes)
                                {
                                    Puntos = Vida_1antes;
                                    Vida_1antes = 0;
                                    VidaGladiador1 = 0;
                                }
                                totalDano2[0] = Puntos + totalDano2[0];
                                Console.WriteLine("Ataca " + gladiadoresEq2[0] + "...");
                                Console.WriteLine();
                                Console.WriteLine("Gladiador1 queda con " + pv1[0] + " puntos de vida.");
                                Console.WriteLine("Gladiador2 suma " + Puntos + " puntos.");
                                Console.WriteLine();
                            }
                            else
                            {
                                int Vida_2antes = pv2[0];
                                pv2[0] = Ataque_ju1(atk1[0], atk2[0], pv2[0], pv1[0], def1[0], def2[0], turno);
                                int Puntos = Vida_2antes - pv2[0];
                                if (pv2[0] == Vida_2antes)
                                {
                                    Puntos = Vida_2antes; ;
                                    Vida_2antes = 0;
                                    pv2[0] = 0;
                                }
                                totalDano1[0] = Puntos + totalDano1[0];
                                Console.WriteLine("Ataca " + gladiadoresEq1[0] + "...");
                                Console.WriteLine();
                                Console.WriteLine("Gladiador2 queda con " + pv2[0] + " puntos de vida.");
                                Console.WriteLine("Gladiador1 suma " + Puntos + " puntos.");
                                Console.WriteLine();
                            }
                            break;

                        //SE ELIGE RECUPERAR VIDA
                        case 2:
                            {
                                if (contadorRecuperar <= 2)
                                {
                                    contadorRecuperar++;
                                    int VidaCurada = RecuperarVida(VidaGladiador1, VidaGladiador2, VidaMaxima, turno);
                                    Console.WriteLine("La vida del gladiador ahora es de " + VidaCurada + " puntos de vida.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Un gladiador no puede recuperar vida más de dos veces por combate.");
                                    break;
                                }
                            }

                        default:
                            Console.WriteLine("Opción no válida. Intente de nuevo.");
                            break;
                    }
                    turno++;
                 VidaEquipo1 = pv1[0] + pv1[1] + pv1[2] + pv1[3] + pv1[4]; //sumar las vidas de todos los gladiadores
                 VidaEquipo2 = pv2[0] + pv2[1] + pv2[2] + pv2[3] + pv2[4];
                }
                Console.WriteLine("====================GAME OVER====================");
                if (VidaEquipo1 > 0)
                {
                    Console.WriteLine("El combate ha acabado... Ganan " + NombreEquipo1);
                }
                else
                {
                    Console.WriteLine("El combate ha acabado... Ganan " + NombreEquipo2);
                }
                if (totalDano1[0] > totalDano2[0])
                {
                    MVP = totalDano1[0];
                    Console.WriteLine("MVP del torneo (" + MVP + " de daño causado): " + gladiadoresEq1[0] + "");
                }
                else
                {
                    MVP = totalDano2[0];
                    Console.WriteLine("MVP del torneo (" + MVP + " de daño causado): " + gladiadoresEq2[0] + "");
                }
                string estadogla1;
                if (pv1[0] > 0)
                {
                    estadogla1 = "de pie";
                }
                else
                {
                    estadogla1 = "fuera de combate";
                }
                string estadogla2;
                if (pv2[0] > 0)
                {
                    estadogla2 = "de pie";
                }
                else
                {
                    estadogla2 = "fuera de combate";
                }
                Console.WriteLine();
                Console.WriteLine("Equipo: " + NombreEquipo1 + "     " + "NOMBRE: " + gladiadoresEq1[0] + "     " + "VIDA: " + pv1[0] + "     " + "ATQ: " + atk1[0] + "     " + "DEF: " + def1[0] + "     " + "DAÑO CAUSADO: " + totalDano1[0] + "     " + "ESTADO: " + estadogla1 + "");
                Console.WriteLine("Equipo: " + NombreEquipo2 + "     " + "NOMBRE: " + gladiadoresEq2[0] + "     " + "VIDA: " + pv2[0] + "     " + "ATQ: " + atk2[0] + "     " + "DEF: " + def2[0] + "     " + "DAÑO CAUSADO: " + totalDano2[0] + "     " + "ESTADO: " + estadogla2 + "");

            }
            if(Modalidad==2)
            {
                int turno = 1;
                int contadorRecuperar = 0;
                int VidaEquipo1 = pv1[0] + pv1[1] + pv1[2] + pv1[3] + pv1[4]; //sumar las vidas de todos los gladiadores
                int VidaEquipo2 = pv2[0] + pv2[1] + pv2[2] + pv2[3] + pv2[4];
                while (VidaEquipo1 > 0 && VidaEquipo2 > 0)
                {
                    if (turno % 2 == 0)
                    {
                        Console.WriteLine("====================TURNO " + turno + "====================");
                        Console.WriteLine("Turno de " + NombreEquipo2);
                        Console.WriteLine("1. " + gladiadoresEq2[0] + " - HP = " + pv2[0]);
                        Console.WriteLine("2. " + gladiadoresEq2[1] + " - HP = " + pv2[1]);
                    }
                    else
                    {
                        Console.WriteLine("====================TURNO " + turno + "====================");
                        Console.WriteLine("Turno de " + NombreEquipo1);
                        Console.WriteLine();
                        Console.WriteLine("1. " + gladiadoresEq1[0] + " - HP = " + pv1[0]);
                        Console.WriteLine("2. " + gladiadoresEq1[1] + " - HP = " + pv1[1]);
                    }
                    Console.WriteLine("¿Que acción realiza? 1. Ataque 2. Recuperar vida");
                    int Accion = int.Parse(Console.ReadLine());
                    switch (Accion)
                    {
                        case 1:
                            Console.WriteLine("Seleccionó ATAQUE.");
                            if (turno % 2 == 0)
                            {
                                Console.WriteLine("¿Qué gladiador de " + NombreEquipo2 + " ataca? (1: " + gladiadoresEq2[0] + " / 2: " + gladiadoresEq2[1] + ")");
                                int atacaNum = int.Parse(Console.ReadLine());
                                while ((atacaNum == 1 && pv2[0] <= 0) || (atacaNum == 2 && pv2[1] <= 0))
                                {
                                    if (atacaNum == 1 && pv2[atacaNum] <= 0)
                                    {
                                        Console.WriteLine("El jugador " + gladiadoresEq2[atacaNum] + " queda inhabilitado y fuera de combate y no se lo puede usar mas.");
                                        Console.WriteLine("¿Qué gladiador de " + NombreEquipo2 + " ataca? (1: " + gladiadoresEq2[0] + " / 2: " + gladiadoresEq2[1] + ")");
                                        atacaNum = int.Parse(Console.ReadLine());
                                    } 
                                }

                                Console.WriteLine("¿A quién del equipo rival (" + Nom_Equi1 + ") deseas atacar? (1: " + Gladiador1_Equi1 + " / 2: " + Gladiador2_Equi1 + ")");
                                int objetivoNum = int.Parse(Console.ReadLine());
                                while ((objetivoNum == 1 && PV_A_a <= 0) || (objetivoNum == 2 && PV_A_b <= 0))
                                {
                                    if (objetivoNum == 1 && PV_A_a <= 0)
                                    {
                                        Console.WriteLine("No se le puede atacar a " + Gladiador1_Equi1 + " porque quedó fuera de combate e inhabilitado.");
                                    }
                                    if (objetivoNum == 2 && PV_A_b <= 0)
                                    {
                                        Console.WriteLine("No se le puede atacar a " + Gladiador2_Equi1 + " porque quedó fuera de combate e inhabilitado.");
                                    }
                                    Console.WriteLine("¿A quién del equipo rival (" + Nom_Equi1 + ") deseas atacar? (1: " + Gladiador1_Equi1 + " / 2: " + Gladiador2_Equi1 + ")");
                                    objetivoNum = int.Parse(Console.ReadLine());
                                }

                                if (atacaNum == 1 && objetivoNum == 1)
                                {
                                    int Vida_1antes = PV_A_a;
                                    PV_A_a = Ataque_ju1(ATK_B_a, ATK_A_a, PV_B_a, PV_A_a, DEF_B_a, DEF_A_a, turno);
                                    int Puntos = Vida_1antes - PV_A_a;
                                    if (PV_A_a == Vida_1antes)
                                    {
                                        Puntos = Vida_1antes;
                                        Vida_1antes = 0;
                                        PV_A_a = 0;
                                    }
                                    Total_daño_Ba = Puntos + Total_daño_Ba;
                                    Console.WriteLine("Ataca " + Gladiador1_Equi2 + " a " + Gladiador1_Equi1 + "...");
                                    Console.WriteLine();
                                    Console.WriteLine("Gladiador1 queda con " + PV_A_a + " puntos de vida.");
                                    Console.WriteLine("Gladiador2 suma " + Puntos + " puntos.");
                                    Console.WriteLine();
                                    if (PV_A_a == 0)
                                    {
                                        Console.WriteLine("El jugador " + Gladiador1_Equi1 + " queda inhabilitado y fuera de combate y no se lo puede usar mas.");
                                    }
                                }
                            }
        }
    }
}
