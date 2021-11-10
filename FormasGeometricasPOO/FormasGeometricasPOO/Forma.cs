using FormasGeometricasPOO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormasGeometricasPOO
{//Classe de formas
    abstract class Forma
    {
        public Cor Cor { get; set; }
        

        protected Forma(Cor cor)
        {
            Cor = cor;
        }

        public virtual double Area()
            
        {
            return (double)Cor;
        }
    }
    

        
    
    
    
    
    


}       

















