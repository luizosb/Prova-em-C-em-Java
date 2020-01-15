using System;
using System.Collections.Generic;
using System.Text;

namespace Prova
{
    class Supervisor : Funcionarios
    {
        public Supervisor(string nome, int idade, double salario) : base(nome, idade, salario)
        {
        }

        public void Bonificacao()
        {
            Salario = Salario + 5000.00;
            Console.WriteLine("O salário do " + Nome + " é de " + Salario + " reais.");
        }

    }
          



}
