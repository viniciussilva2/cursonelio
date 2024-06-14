using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursonelio
{
    internal class IdadePessoa
    {
        // Criando atributos da classe IdadePessoa.
        public static int anoAtual;
        public static int anoNascimento;

        public static int CalcularIdade()
        {
            return anoAtual - anoNascimento;
        }

    }
}
