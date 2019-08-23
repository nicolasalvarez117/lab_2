using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_nro_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ejercicio nro 4";
            int numero, i, j, acumulador = 0;
            bool flag = true;

            Console.Write("ingrese un numero: ");

            numero = Convert.ToInt32(Console.ReadLine());

            for (j = 1; j < numero; j++)
            {
                for (i = 1; i < j; i++)
                {
                    if (j % i == 0)
                    {
                        acumulador += i;
                    }
                }
                if (acumulador == j)
                {
                    Console.WriteLine("{0}", j);
                }
                acumulador = 0;
            }
            Console.ReadKey();
        }
    }
}
