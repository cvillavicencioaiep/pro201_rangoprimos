using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPrimo
    {
        public bool evalPrimo(int x)
        {
            DatoPrimo a = new DatoPrimo();
            if (a.Primo(x))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    
        public int[] cantPrimo(int ini, int fin)
        {
            int cont = 0;
            int primerPrimo = 0;
            int ultimoPrimo = 0;
            for (int i = ini; i <= fin; i++)
            {
                if (evalPrimo(i))
                {
                    cont++;
                    if (primerPrimo == 0)
                    {
                        primerPrimo = i;
                    }
                    ultimoPrimo = i;
                }
            }
            int[] resultado = { primerPrimo, ultimoPrimo, cont };
            return resultado;
        }
    }
}
