using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_dinamicas.Negocios
{
    public class beca
    {
        public Boolean OtorgarBeca(int prom)
        {
            return (prom > 98) ? true : false;
        }
    }
}
