using System;

namespace cursonelio
{
    internal class Triangulo
    {

        // DEFINIÇÃO DA CLASSE.
        // O TRIANGULO TEM TRÊS ATRIBUTOS.
        // AS VARIÁVEIS SÃO OS ATRIBUTOS DA CLASSE, QUE SÃO OS LADOS DO TRIÂNGULO.
        // PUBLIC PODEMOS ACESSAR ESSAS VARIÁVEIS EM OUTRO ARQUIVO.


        // ATRIBUTOS DA CLASSE TRIÂNGULO PARA SEREM CHAMADOS LÁ NA CLASSE PRINCIPAL ATRAVÉS DE UM OBJETO.

        public double A;
        public double B;
        public double C;

        public double Area(double A, double B, double C)
        {
            double p = (A + B + C) / 2; 
            double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return raiz;
        }


    }
}
