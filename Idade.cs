using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursonelio
{
    internal class Idade
    {

        public static int AnoNascimento;
        public static int AnoAtual;

        public static int CalcularIdade(int AnoNascimento, int AnoAtual)
        {
            return AnoAtual - AnoNascimento;

        }




    }
}
