using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Alumno
    {

        private string nombre;
        private string apellido;
        private int legajo;
        byte nota1;
        byte nota2;
        float notaFinal = -1;

        public Alumno(string nombre,string apellido,int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }


        public void CalcularFinal()
        {
            if(nota1 >= 4 && nota2 >= 4)
            {
                Random a = new Random();
                notaFinal = a.Next(nota1, nota2);
            }
        }
        public void Estudiar(byte notaUno,byte notaDos)
        {
            nota1 = notaUno;
            nota2 = notaDos;
        }
        public string Mostrar()
        {
            string mostrar;
            if(notaFinal != -1)
            {
                mostrar = nombre + " " + apellido + " " + nota1 + " " + nota2 + " " + notaFinal;
            }
            else
            {
                mostrar = nombre + " " + apellido + " "+ legajo +" " + nota1 + " " + nota2 + " " + "alumno desaprobado";
            }
            return mostrar;
        }
    }
}
