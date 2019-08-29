using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_numero_17
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor color = ConsoleColor.Blue;
            Boligrafo boligrafo = new Boligrafo(100,color);
            bool flag = true;
            short tintaUsada;
            string asteriscos;
            string opcion;
            while(flag)
            {
                Console.Write("1. pintar\n2 recargar\n3 mostrar tinta\n4:salir:  ");
                opcion = Console.ReadLine();
                switch(opcion)
                {
                    case "1":
                        Console.Write("Numero de tinta a usar: ");
                        tintaUsada = Convert.ToInt16(Console.ReadLine());
                        if(!boligrafo.Pintar(tintaUsada,out asteriscos))
                        {
                            Console.WriteLine("No se pudo pintar");
                        }
                        else
                        {
                            Console.ForegroundColor = boligrafo.GetColor();
                            Console.WriteLine("pinto {0}", asteriscos);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        
                        break;
                    case "2":
                        boligrafo.Recargar();
                        break;
                    case "3":
                        Console.WriteLine("queda {0} de tinta", boligrafo.GetTinta());
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
    }
}
