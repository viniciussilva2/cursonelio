using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursonelio
{
    internal class Funcionario
    {
        // Declaração de Variáveis.
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        // Método de mostrar o Salário do funcionário com descontos.
        public double SalarioLiquido()
        {

            return SalarioBruto - Imposto ;


        }

        // Método para aumentar o salário.
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        // ToString (override), transformar um objeto em um string para mostrar o resultado corretamente.
        public override string ToString()
        {
            return Nome + " "
                   + " " + "Salário" + " " + "$" + SalarioBruto + " "
                   + " " + "Imposto" + " " + "$"
                   + Imposto;
        }

    }
}
