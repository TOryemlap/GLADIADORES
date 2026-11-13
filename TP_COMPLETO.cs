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
            int Ataque1 = 15;
            int Ataque2 = 15;
            int defen1 = 5;
            int defen2 = 5;
            ///////////////////////////////////////////////////////////////////////////
            //
            //variables del equipo 1 
            //
            int PV_equipo1_Total = 0;//la suma total de la vida del equipo 1
            int Nom_Equi1 = 0; // nombre del equipo numero 1
            //
            //gladiador 1 equipo 1 
            //
            int Gladiador1_Equi1 = 0;// nombre gladiador 1 equipo 1
            int Total_daño_Aa = 0; //contador del daño causado en todo el juego del jugador 1 del equipo 1
            int PV_A_a = 0; //vida de gladiador 1 del equipo 1  
            int ATK_A_a = 0; //ataque del gladiador 1 del equipo 1 
            int DEF_A_a = 0;//defensa de gladiador 1 equipo 1
            //
            //gladiador 2 equipo 1
            //
            int Gladiador2_Equi1 = 0;// nombre gladiador 2 equipo 1
            int Total_daño_Ab = 0; //contador del daño causado en todo el juego del jugador 2 del equipo 1
            int PV_A_b = 0; //vida de gladiador 2 del equipo 1  
            int ATK_A_b = 0; //ataque del gladiador 2 del equipo 1 
            int DEF_A_b = 0;//defensa de gladiador 2 equipo 1
            //
            //gladiador 3 equipo 1 
            //
            int Gladiador3_Equi1 = 0;// nombre gladiador 3 equipo 1
            int Total_daño_Ac = 0; //contador del daño causado en todo el juego del jugador 3 del equipo 1
            int PV_A_c = 0; //vida de gladiador 3 del equipo 1  
            int ATK_A_c = 0; //ataque del gladiador 3 del equipo 1 
            int DEF_A_c = 0;//defensa de gladiador 3 equipo 1
            //
            //gladiador 4 equipo 1 
            //
            int Gladiador4_Equi1 = 0;// nombre gladiador 4 equipo 1
            int Total_daño_Ad = 0; //contador del daño causado en todo el juego del jugador 4 del equipo 1
            int PV_A_d = 0; //vida de gladiador 4 del equipo 1  
            int ATK_A_d = 0; //ataque del gladiador 4 del equipo 1
            int DEF_A_d = 0;//defensa de gladiador 4 equipo 1
            //
            //gladiador 5 equipo 1 
            //
            int Gladiador5_Equi1 = 0;// nombre gladiador 5 equipo 1
            int Total_daño_Ae = 0; //contador del daño causado en todo el juego del jugador 5 del equipo 1
            int PV_A_e = 0; //vida de gladiador 5 del equipo 1  
            int ATK_A_e = 0; //ataque del gladiador 5 del equipo 1 
            int DEF_A_e = 0;//defensa de gladiador 5 equipo 1
            //
            //variables del segundo equipo
            //
            int Nom_Equi2 = 0; // nombre del equipo 2 
            int PV_equipo2_Total = 0;//la suma total de la vida del equipo 2
            //
            //gladiador 1 equipo 2
            //
            int Gladiador1_Equi2 = 0;// nombre gladiador 1 equipo 2
            int Total_daño_Ba = 0; //contador del daño causado en todo el juego del jugador 1 del equipo 2
            int PV_B_a = 0; //vida de gladiador 1 del equipo 2  
            int ATK_B_a = 0; //ataque del gladiador 1 del equipo 2 
            int DEF_B_a = 0;//defensa de gladiador 1 equipo 2
            //
            //gladiador 2 equipo 2
            //
            int Gladiador2_Equi2 = 0;// nombre gladiador 2 equipo 2
            int Total_daño_Bb = 0; //contador del daño causado en todo el juego del jugador 2 del equipo 2
            int PV_B_b = 0; //vida de gladiador 2 del equipo 2  
            int ATK_B_b = 0; //ataque del gladiador 2 del equipo 2 
            int DEF_B_b = 0;//defensa de gladiador 2 equipo 2
            //
            //gladiador 3 equipo 2
            //
            int Gladiador3_Equi2 = 0;// nombre gladiador 3 equipo 2
            int Total_daño_Bc = 0; //contador del daño causado en todo el juego del jugador 3 del equipo 2
            int PV_B_c = 0; //vida de gladiador 3 del equipo 2 
            int ATK_B_c = 0; //ataque del gladiador 3 del equipo 2 
            int DEF_B_c = 0;//defensa de gladiador 3 equipo 2
            //
            //gladiador 4 equipo 2
            //
            int Gladiador4_Equi2 = 0;// nombre gladiador 4 equipo 2
            int Total_daño_Bd = 0; //contador del daño causado en todo el juego del jugador 4 del equipo 2
            int PV_B_d = 0; //vida de gladiador 4 del equipo 2  
            int ATK_B_d = 0; //ataque del gladiador 4 del equipo 2 
            int DEF_B_d = 0;//defensa de gladiador 4 equipo 2
            //
            //gladiador 4 equipo 2
            //
            int Gladiador5_Equi2 = 0;// nombre gladiador 5 equipo 2
            int Total_daño_Be = 0; //contador del daño causado en todo el juego del jugador 5 del equipo 2
            int PV_B_e = 0; //vida de gladiador 5 del equipo 2  
            int ATK_B_e = 0; //ataque del gladiador 5 del equipo 2 
            int DEF_B_e = 0;//defensa de gladiador 5 equipo 2           
            int j = 0;
            for (int i = 1; i == Modalidad; i++)
            {
                int ataque = 0;//variable auxiliar
                int defensa = 0;//variable auxiliar
                int vida = 0;//variable auxiliar
                int auxiliar2 = 0;
                int auxiliar1 = 0;
                int cont_pts_2 = 40;
                int cont_pts_1 = 40 ;
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
                    if (cont_pts_1>0)
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
                        if (cont_pts_1>0)
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
                            if (cont_pts_1==0)
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
                VidaGladiador1 = vida;
                Ataque1 = ataque;
                defen1 = defensa;
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
                VidaGladiador2 = vida;
                Ataque2 = ataque;
                defen2 = defensa;
            }
            int turno = 1;
            int contadorRecuperar = 0;
            while (VidaGladiador1 > 0 && VidaGladiador2 > 0)
            {
                if (turno % 2 == 0)
                {
                    Console.WriteLine("====================TURNO " + turno + "====================");
                    Console.WriteLine("Turno de " + gladiadoresEq2[0]);
                    Console.WriteLine("HP = " + VidaGladiador2);
                }
                else
                {
                    Console.WriteLine("====================TURNO " + turno + "====================");
                    Console.WriteLine("Turno de " + gladiadoresEq1[0]);
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
                            if (VidaGladiador1 == Vida_1antes)
                            {
                                Puntos = Vida_1antes;
                                Vida_1antes = 0;
                                VidaGladiador1 = 0;
                            }
                            Total_daño_Ba = Puntos + Total_daño_Ba;
                            Console.WriteLine("Ataca " + gladiadoresEq2[0] + "...");
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
                            if (VidaGladiador2 == Vida_2antes)
                            {
                                Puntos = Vida_2antes; ;
                                Vida_2antes = 0;
                                VidaGladiador2 = 0;
                            }
                            Total_daño_Aa = Puntos + Total_daño_Aa;
                            Console.WriteLine("Ataca " + gladiadoresEq1[0] + "...");
                            Console.WriteLine();
                            Console.WriteLine("Gladiador2 queda con " + VidaGladiador2 + " puntos de vida.");
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
            }
            int VidaEquipo1 = VidaGladiador1; //sumar las vidas de todos los gladiadores
            int VidaEquipo2 = VidaGladiador2;
            Console.WriteLine("====================GAME OVER====================");
            if (VidaEquipo1 > 0)
            {
                Console.WriteLine("El combate ha acabado... Ganan " + NombreEquipo1);
            }
            else
            {
                Console.WriteLine("El combate ha acabado... Ganan " + NombreEquipo2);
            }
            if (Total_daño_Aa > Total_daño_Ba)
            {
                MVP = Total_daño_Aa;
                Console.WriteLine("MVP del torneo (" + MVP + " de daño causado): " + gladiadoresEq1[0] + "");
            }
            else
            {
                MVP = Total_daño_Ba;
                Console.WriteLine("MVP del torneo (" + MVP + " de daño causado): " + gladiadoresEq2[0] + "");
            }
            string estadogla1;
            if (VidaGladiador1 > 0)
            {
                estadogla1 = "de pie";
            }
            else
            {
                estadogla1 = "fuera de combate";
            }
            string estadogla2;
            if (VidaGladiador2 > 0)
            {
                estadogla2 = "de pie";
            }
            else
            {
                estadogla2 = "fuera de combate";
            }
            Console.WriteLine();
            Console.WriteLine("Equipo: " + NombreEquipo1 + "     " + "NOMBRE: " + gladiadoresEq1[0] + "     " + "VIDA: " + VidaGladiador1 + "     " + "ATQ: " + Ataque1 + "     " + "DEF: " + defen1 + "     " + "DAÑO CAUSADO: " + Total_daño_Aa + "     " + "ESTADO: " + estadogla1 + "");
            Console.WriteLine("Equipo: " + NombreEquipo2 + "     " + "NOMBRE: " + gladiadoresEq2[0] + "     " + "VIDA: " + VidaGladiador2 + "     " + "ATQ: " + Ataque2 + "     " + "DEF: " + defen2 + "     " + "DAÑO CAUSADO: " + Total_daño_Ba + "     " + "ESTADO: " + estadogla2 + "");

        }
    }
}
