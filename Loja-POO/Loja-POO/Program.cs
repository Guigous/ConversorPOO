using System;

namespace Loja_POO
{
    class Program
    {
        static void Main(string[] args)
        {


            //Instanciamento do vetor
            Console.WriteLine("Numero de entradas : ");
            int n = int.Parse(Console.ReadLine());
            Produtos[] arrProdutos = new Produtos[n];

            //Loop
            for (int h = 1; h <= n; h++)
            {
                //Input de Dados
                Console.WriteLine("Produto #" + h);
                Console.WriteLine("Digite o Nome do Produto : ");
                string nomeproduto = Console.ReadLine();
                Console.WriteLine("Digite O Tipo de Produto (C(omum)/I(mportado)/U(sado)) ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Digite o Preco do Produto: ");
                double preco = double.Parse(Console.ReadLine());
                
                //Casos
                switch (tipo)
                {
                    case "C":
                    case "c":

                        Produtos c = new Produtos(nomeproduto, preco);
                        arrProdutos[h - 1] = c;
                        break;

                    case "U":
                    case "u":
                        
                        Console.WriteLine("Digite a Data de Fabricacao Do Produto");
                        string data = Console.ReadLine();
                        Usados u = new Usados(nomeproduto, preco, data);
                        arrProdutos[h - 1] = u;
                        break;

                    case "I":
                    case "i":

                        Console.WriteLine("Digite a Taxa do Produto: ");
                        double taxa = double.Parse(Console.ReadLine());
                        Importados i = new Importados(nomeproduto, preco, taxa);
                        arrProdutos[h - 1] = i;
                        break;

                    default:
                        Console.WriteLine("Entrada Invalida !");
                        break;
                }


            }
            //Print da etiqueta
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(arrProdutos[i].Etiqueta());
            }








        }

    }
}

