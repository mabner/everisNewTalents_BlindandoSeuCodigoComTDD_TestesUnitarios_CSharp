﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCalculadora
{
    public class Calculadora
    {
        private List<string> listaHistorico;

        public Calculadora()
        {
            listaHistorico = new List<string>();
        }

        public int somar(int v1, int v2)
        {
            int res = v1 + v2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int subtrair(int v1, int v2)
        {
            int res = v1 - v2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int multiplicar(int v1, int v2)
        {
            int res = v1 * v2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public int dividir(int v1, int v2)
        {
            int res = v1 / v2;

            listaHistorico.Insert(0, "Res: " + res);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count -3);
            return listaHistorico;
        }
    }
}
