using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_numero_17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        ConsoleColor color;
        short tinta;

        public Boligrafo(short tinta,ConsoleColor color)
        {
            
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor() => color;
        public short GetTinta() => tinta;

        public bool Pintar(short gasto,out string dibujo)
        {
            bool bandera = false;
            if (gasto >= 0 && gasto <= 100)
            {
                string asteriscos = "";
                short tintaActual = GetTinta();
                if(gasto > tintaActual)
                {
                    gasto = tintaActual;
                }
                for (int i = 0; i < gasto; i++)
                {
                    asteriscos += "*";
                    tintaActual--;
                }
                this.SetTinta(tintaActual);
                dibujo = asteriscos;

                bandera = true;
            }
            else
            {
                dibujo = "";
            }
            return bandera;

        }
        public void SetTinta(short tinta)
        {
            if(tinta <= cantidadTintaMaxima && tinta >= 0)
            {
                this.tinta = tinta;
            }
        }
        public void Recargar()
        {
            
           this.SetTinta(cantidadTintaMaxima);
        }
    }
}
