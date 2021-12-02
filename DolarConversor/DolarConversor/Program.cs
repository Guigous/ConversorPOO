using System;

namespace DolarConversor
{
          class Program
          {
            static void Main(string[] args)
            {
            //input de dados
            Console.WriteLine("--------------- Conversor ---------------");
            Console.WriteLine("Quantos dolares a serem comprados: ");
            double dolares = double.Parse(Console.ReadLine());
            

            //instaciamento da clace
            ConversorDeMoeda conversor = new ConversorDeMoeda(dolares);

            //output de dados
            Console.WriteLine("Cotacao Atual do Dolar: R$5.61 ");
            Console.WriteLine("Dolares Comprados: " + dolares);
            Console.WriteLine("Valor a ser Pago: " + conversor.CalculoDolar());
            Console.WriteLine("Valor do IOF: 4.08%" );
            Console.WriteLine("Valor total da compra com IOF: " + conversor.CalculoDolarIOF());








        }
          }
    
    
}
