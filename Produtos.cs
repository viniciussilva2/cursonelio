using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace cursonelio
{
    internal class Produtos
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        // ADICIONANDO UM CONSTRUTOR

        // Primeiro construtor
        public Produtos(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        // Construtor opcional
        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        // public para ser acessado em outro arquivo.
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Método para adicionar produtos e mudar a quantidade total.
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        // Método para remover produtos e mudar a quantidade total.
        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        // ToString converte o objeto para String. overridade ToString > Digitar.
        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }



    }
}
