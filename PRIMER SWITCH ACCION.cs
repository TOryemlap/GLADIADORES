using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static int Opciones()
        {
            Console.WriteLine("¿Que acción realiza?"):
            int Accion = int.Parse(ConsoleReadLine());
            switch (Accion)
            {
                //SE ELIGE ATAQUE
                case 1:
                    Console.WriteLine("Seleccionó ATAQUE.");



                    break;
                //SE ELIGE RECUPERAR VIDA
                case 2;
                    Console.WriteLine("Seleccionó RECUPERAR VIDA.");



                    break;
            }
        static void Main(string[] args)
        {
        }
    }
}
