using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasPOO
{
    class Circulo : Forma
        //Clsse Circulo
    {
    
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor) 
        : base(cor)
        {
            Raio = raio;
        }

        //Metodo para o calculo da area
        public override double Area()

        {
            return Math.PI * Raio * Raio;
        }
    }
}
