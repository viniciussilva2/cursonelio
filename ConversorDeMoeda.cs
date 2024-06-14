using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursonelio
{
    internal class ConversorDeMoeda
    {
        private static double IOF = 0.06;

        public static double ConverterParaReais(double valorEmDolar, double cotacaoDolar)
        {
            double valorEmReais = valorEmDolar * cotacaoDolar;
            double valorComIOF = valorEmReais + (valorEmReais * IOF);
            return valorComIOF;
        }
    }

}

