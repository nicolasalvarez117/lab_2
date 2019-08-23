using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_nro_11
{
    public class validacion
    {


     public static bool validar (int valor,int min, int max)
        {
            if (valor >= min && valor <= max)
            {
                return true;
            }
            else
                return false;
        }
    }
}
