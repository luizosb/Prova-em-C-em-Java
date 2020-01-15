using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    class Funcionarios
    {
        public void Bonificacao()
        {
            Salario = Salario + 0;
        }

        public Funcionarios(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        public string Nome { get ; set ; }
        public int Idade { get ; set ; }
        public double Salario { get ; set; }
    }
}
