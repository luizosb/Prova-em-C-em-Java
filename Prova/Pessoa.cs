using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    class Pessoa
    {
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get ; set; }
        public int Idade { get; set ; }

        public Pessoa()
        {

        }
    }
}
