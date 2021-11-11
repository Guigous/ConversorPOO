using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja_POO
{
    class Produtos
        
    {
        //Classe Base
        public string Nome { get; set; }
        public double Preco { get; set; }
        




        public Produtos(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
           
        }

        //Metodo Etiquetas
        public virtual string Etiqueta()
        {
            string etiqueta = Nome + " - R$ " + Preco;
            return etiqueta;

        }
    }




   
    

    
}
