using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            string numero2;
            byte nota1;
            byte nota2;
            Alumno nuevoAlumno = new Alumno("nicolas","alvarez",1);
            Console.WriteLine("Ingrese las notas del alumno: ");
            Console.Write("Nota 1: ");

            numero = Console.ReadLine();
            Console.Write("Nota 2: ");
            numero2 = Console.ReadLine();

            byte.TryParse(numero, out nota1);
            byte.TryParse(numero2, out nota2);

            nuevoAlumno.Estudiar(nota1, nota2);
            nuevoAlumno.CalcularFinal();

            Console.WriteLine(nuevoAlumno.Mostrar());
            Console.ReadKey();


        }
    }
}
