using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    class Vendedor : Funcionarios
    {
        public Vendedor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }


        public void Bonificacao()
        {
            Salario = Salario + 3000.00;
            Console.WriteLine("O salário do " + Nome + " é de " + Salario+ " reais.");
        }

    }
}
