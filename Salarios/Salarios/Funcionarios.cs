using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarios
{//classe de funcionarios
    class Funcionarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        //Metodo de incrementar o salario
        public void incrementarSalario(double porcentagem)
        {
            Salario *= porcentagem;
        }
    }
}
