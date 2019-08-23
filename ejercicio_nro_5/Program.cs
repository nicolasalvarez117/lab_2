using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_nro_5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i ,j,k ;
            int numero;
            Console.Title = "ejercicio nro 5";

            Console.Write("ingrese un numero: ");

            numero = Convert.ToInt32(Console.ReadLine());
            int acumulador = 0;

            for(i=8;i<=numero;i++)
            {
                for(j=1;j<=i;j++)
                {
                    acumulador += j;
                }
                for(k=1;k<=i;k++)
                {
                    if( (k*k) == acumulador)
                    {
                        Console.WriteLine("{0}", k);
                    }
                }
                acumulador = 0;
            }
            Console.ReadKey();


            
        }
    }
}
