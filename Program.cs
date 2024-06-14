using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace cursonelio
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();

            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Produtos p = new Produtos(nome, preco, 5);
            //Console.WriteLine();

            ////Console.Write("Quantidade no estoque: ");
            ////int quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();

            //Console.WriteLine("Dados atualizados: " + p);

            //Console.WriteLine();

            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);

            Pessoa p1 = new Pessoa(23, "Vinicius", 2001);
            Console.WriteLine("Dados da pessoa 1: ");
            Console.WriteLine(" IDADE: " + p1.Idade);
            Console.WriteLine(" NOME: " + p1.Nome);
            Console.WriteLine(" ANO DE NASCIMENTO: " + p1.AnoNascimento);

            Pessoa p2 = new Pessoa(49, "Silvio", 1975);
            Console.WriteLine("Dados da pessoa 1: ");
            Console.WriteLine(" IDADE: " + p2.Idade);
            Console.WriteLine(" NOME: " + p2.Nome);
            Console.WriteLine(" ANO DE NASCIMENTO: " + p2.AnoNascimento);

            
        }

    }

}

