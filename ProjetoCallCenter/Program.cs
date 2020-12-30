using System;
using ProjetoCallCenter.Entities;
using ProjetoCallCenter.Entities.Enum;

namespace ProjetoCallCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bom dia colaborador, Seja bem vindo a nossa empresa.");
            Console.WriteLine();

            Console.Write("Digite a operação que você trabalha: ");
            string nomeOpe = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Obrigado, agora por favor entre com os seus dados: ");
            Console.WriteLine();

            Console.Write("Nome do funcionario: ");
            string nome = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Cargo que vai ocupar ( Operador/Supervisor/Gestor ): ");
            CargoTrabalho cargo = Enum.Parse<CargoTrabalho>(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Salario sem adicionais: ");
            double salarioBase = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Operaçao oper = new Operaçao(nomeOpe);

            Trabalhador trabalhador = new Trabalhador(nome, cargo, salarioBase, oper);

            Console.Write("Quantos produtos extras vai trabalhar: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();


            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do produto{i}: ");
                Console.Write("Data da atividade (DD/MM/AAAA): ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine());

                Console.Write("Duração em horas: ");
                int horas = int.Parse(Console.ReadLine());

                ContratoHora contrato = new ContratoHora(data, valorHora, horas);

                trabalhador.AdicionarContrato(contrato);

            }

            Console.WriteLine();
            Console.Write("Entre com o mes e o ano que vai consultar o seu recebimento salarial no formato (MM/AAAA): ");
            string mesAno = Console.ReadLine();

            int mes = int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));
            Console.WriteLine();

            Console.WriteLine("Nome do funcionario: " + trabalhador.Nome);
            Console.WriteLine("Operação: " + trabalhador.Operaçao.Nome);
            Console.WriteLine("Salario Total de " + mesAno + ": " + trabalhador.SalarioTotal(ano, mes));








        }
    }
}
