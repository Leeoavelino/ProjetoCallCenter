using System;
using System.Collections.Generic;
using System.Text;
using ProjetoCallCenter.Entities.Enum;

namespace ProjetoCallCenter.Entities
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public CargoTrabalho Cargo { get; set; }
        public double SalarioBase { get; set; }
        public Operaçao Operaçao { get; set; }

        public List<ContratoHora> Contratos { get; set; } = new List<ContratoHora>();
       

        public Trabalhador() { }

        public Trabalhador(string nome, CargoTrabalho cargo, double salarioBase, Operaçao operaçao)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioBase = salarioBase;
            Operaçao = operaçao;
        }

        public void AdicionarContrato(ContratoHora contrato)
        {
            Contratos.Add(contrato);
        }

        public void RemoverContrato(ContratoHora contrato)
        {
            Contratos.Remove(contrato);
        }

        public double SalarioTotal(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach(ContratoHora cont in Contratos)
            {
                if(cont.Data.Year == ano && cont.Data.Month == mes)
                {
                    soma += cont.ValorTotal();
                }
            }

            return soma;
        }


    }
}
