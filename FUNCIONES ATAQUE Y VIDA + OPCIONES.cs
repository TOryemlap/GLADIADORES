using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static int RecuperarVida(int VidaGladiador1, int VidaGladiador2, int VidaMaxima)
        {
            Console.WriteLine("Seleccionó RECUPERAR VIDA.");
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
        static int Ataque_ju1(int VidaGladiador2, int Ataque1, int defen2)
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

            return VidaGladiador2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("¿Que acción realiza?");
            int Accion = int.Parse(Console.ReadLine());
            int VidaGladiador1 = 15;
            int VidaGladiador2 = 18;
            int VidaMaxima = 25;
            int Ataque1 = 15;
            int defen2 = 5;
        switch (Accion)
        {
        //SE ELIGE ATAQUE
          case 1:
          Console.WriteLine("Seleccionó ATAQUE.");
          VidaGladiador2 = Ataque_ju1(Ataque1, VidaGladiador2, defen2);


        break;

        //SE ELIGE RECUPERAR VIDA
          case 2:
        {
            int VidaCurada = RecuperarVida(VidaGladiador1, VidaGladiador2, VidaMaxima);
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

