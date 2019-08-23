using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ejercicio_nro_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int min = int.MaxValue;
            int max = int.MinValue;
            double promedio = 0;
            int i;
            bool flag = true;
            for(i=0;i<5;i++)
            {
                while(flag)
                {
                    Console.WriteLine("Ingrese el numero");
                    numero = Convert.ToInt32(Console.ReadLine());
                    if (validacion.validar(numero, -100, 100))
                    {
                        promedio += numero;
                        if(numero > max)
                        {
                            max = numero;
                        }
                        else if(numero < min)
                        {
                            min = numero;
                        }
                        flag = false;
                    }
                    else
                        Console.WriteLine("Numero incorrecto");
                }
                flag = true;

            }
            Console.WriteLine("minimo {0} maximo {1} promedio {2}", min, max, promedio / 5);
            Console.ReadKey();
        }
    }
}
