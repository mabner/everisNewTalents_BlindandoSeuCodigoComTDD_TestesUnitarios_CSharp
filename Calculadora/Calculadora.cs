using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCalculadora
{
    public class Calculadora
    {
        public int somar(int v1, int v2)
        {
            int res = v1 + v2;
            return res;
        }

        public int subtrair(int v1, int v2)
        {
            int res = v1 - v2;
            return res;
        }

        public int multiplicar(int v1, int v2)
        {
            int res = v1 * v2;
            return res;
        }

        public int dividir(int v1, int v2)
        {
            int res = v1 / v2;
            return res; ;
        }

        public List<string> historico()
        {
            return new List<string>();
        }
    }
}
