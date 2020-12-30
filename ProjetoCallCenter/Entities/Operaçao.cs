using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoCallCenter.Entities
{
    class Operaçao
    {
        public string Nome { get; set; }

        public Operaçao() { }

        public Operaçao(string nome)
        {
            Nome = nome;
        }

    }
}
