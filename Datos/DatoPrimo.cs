using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DatoPrimo
    {
        public bool Primo(int num)
        {
            int cont = 0;
            if (num > 7)
            {
                cont++;
            }
            for (int i = 1; i <= 7; i++)
            {
                if (num % i == 0)
                {
                    cont++;
                }
            }
            if (cont == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
