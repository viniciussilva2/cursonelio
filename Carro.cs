using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursonelio
{
    internal class Carro
    {

        // Propriedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        // Construtor
        public Carro(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }


    }
}

