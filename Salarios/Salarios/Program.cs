using System;
using System.Collections.Generic;
namespace Salarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Insercao do numero de funcionarios a serem incluidos
            Console.WriteLine("Digite um número: ");

            int n = int.Parse(Console.ReadLine());
            //Criacao da lista de funcionarios
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            //Loop para preenchimento da lista
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite o Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o salário: ");
                double salario = double.Parse(Console.ReadLine());

                funcionarios.Add(new Funcionarios { Id = id, Nome = nome, Salario = salario });
            }
            //Escolha do id do funcionario para a incrementacao do salario usando o metodo da classe
            Console.WriteLine("Digite o id do funcionário: ");
            int idFunc = int.Parse(Console.ReadLine());

            var func = funcionarios.Find(x => x.Id == idFunc);

            if (func != null)
            {
                Console.WriteLine("Digite a porcentagem: ");
                double porc = double.Parse(Console.ReadLine());
                func.incrementarSalario(porc);
            }
            else
            {
                Console.WriteLine("Id inexistente!");
            }
            //Output de dados
            Console.WriteLine();
            Console.WriteLine("Atualização:");
            foreach (var item in funcionarios)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Nome);
                Console.WriteLine(item.Salario);
                Console.WriteLine("--------------");
            }
        }
    }
}
