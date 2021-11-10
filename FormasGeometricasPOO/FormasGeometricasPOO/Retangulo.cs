using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasPOO 
{

    class Retangulo : Forma
    {
        //Classe Retangulo


        public double Largura { get; set; }

        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) 
        : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }
        //Metodo para o calculo da area
        public override double Area()
        {
            return Largura * Altura;
        }
    }
}