using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolarConversor
{
    class ConversorDeMoeda
    {
        public double DolarCotacao { get; private set; }
        public double Iof { get; private set; }
        public double Dolares { get; private set; }

        public ConversorDeMoeda(double dolares)
        {
            //cosntrutor
            DolarCotacao = 5.61;
            Iof = (4.08/100) + 1;
            Dolares = dolares;
        }

        //Cotacao Dolar
        //https://www.google.com/search?client=opera-gx&q=dolar+cotacao&sourceid=opera&ie=UTF-8&oe=UTF-8

        //IOF
        //https://www.istoedinheiro.com.br/aumento-do-iof-veja-onde-e-como-suas-contas-serao-afetadas/
        //metodo de calculo do dolar
        public double CalculoDolar()
        {
            double dolar = Dolares * DolarCotacao;
            return dolar;
        }
        //metodo do calculo com IOF
        public double CalculoDolarIOF()
        {
            double dolariof = CalculoDolar() * Iof;
            return dolariof;

        }
        //Retorno do IOF
        public string RetornoIOF()
        {
            double iof = (Iof * 100) - 1;
            return Iof.ToString();
        }
    }
}
