using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    class Gerente : Funcionarios
    {
        public Gerente(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }
        public void Bonificacao()
        {
            Salario = Salario + 10000.00;
            Console.WriteLine("O salário da " + Nome + " é de " + Salario + " reais.");
        }
    }
}
