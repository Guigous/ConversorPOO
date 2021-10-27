using System;

namespace Loja_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o Nome do Produto : ");
            string nomeproduto = Console.ReadLine() ;
            Console.WriteLine("Digite O Tipo de Produto (C(omum)/I(mportado)/U(sado) ");
            string tipo = Console.ReadLine();
            
            
            
            
            switch(tipo)
            {
                case "C":



                    

                case "I":

                case "U":


                default:
                    Console.WriteLine("Entrada Invalida !");
                    break;
                
            




            }
            Console.WriteLine("Deseja Adicionar Mais Um Produto ? (S/N)");

        }
    }
}
