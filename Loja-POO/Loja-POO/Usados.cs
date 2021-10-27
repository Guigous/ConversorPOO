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


        public Usados(string nome, double preco, string data)
        : base(nome, preco)
        {
            data = data.ToString();
            
        }
    }
}
