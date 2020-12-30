using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCallCenter.Entities
{
    class ContratoHora
    {
        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Horas { get; set; }

        public ContratoHora() { }

        public ContratoHora(DateTime data, double valorHora, int horas)
        {
            Data = data;
            ValorHora = valorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorHora * Horas;
        }


    }
}
