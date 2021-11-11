using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_POO
{
    class Usados : Produtos
    {
        public string Data { get; set; }

        //Subclasse
        public Usados(string nome, double preco, string data)
        : base(nome, preco)
        {
            Data = data;
            
        }
        //Metodo Etiquetas
        public override string Etiqueta()
        {
            string etiqueta = Nome + " ( Usado ) - R$ " + Preco + " (Fabricado: " + Data + ")";
            return etiqueta;
        }
    }
}
