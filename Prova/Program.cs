using System;
using System.Collections.Generic;
using System.Linq;

namespace Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("João", 15);
            Pessoa p2 = new Pessoa("Leandro", 21);
            Pessoa p3 = new Pessoa("Paulo", 17);
            Pessoa p4 = new Pessoa("Jessica", 18);

            Pessoa pt = new Pessoa();

            List<Pessoa> pessoas = new List<Pessoa>();
            pessoas.Add(p1);
            pessoas.Add(p2);
            pessoas.Add(p3);
            pessoas.Add(p4);

            Console.WriteLine("--------------------Lista Antes-----------------------------");

            Console.WriteLine("A lista tem " + pessoas.Count() + " elementos.");

            foreach (Pessoa ind in pessoas)
            {
                Console.WriteLine(ind.Nome + ", " + ind.Idade);

            }

            int idadeM = 0;
            string nomeM = "";
            foreach (Pessoa ind in pessoas)
            {
                if (ind.Idade > idadeM  )
                {
                    idadeM = ind.Idade;
                    nomeM = ind.Nome;
                }

            }
            Console.WriteLine("A pessoa mais velha é " + nomeM);

            //List<Pessoa> ordenada = pessoas.OrderBy(Pessoa => Pessoa.Idade).ToList();

            //foreach (Pessoa ind in ordenada)
            //{
            //   Console.WriteLine(ind.Nome + ", " + ind.Idade);
                
            //}

            // Fazendo a remoção de elementos da lista
            foreach (Pessoa ind in pessoas.ToArray())
            {
                if (ind.Idade >= 18)
                {
                    pessoas.Remove(ind);

                    
                }
                
            }

        

            /*
            for (int i =0; i < pessoas.Count(); i++)
            {
                if(pt.Idade < 18)
                {
                    pessoas.RemoveAt(i);
                }

            }
            
            */

            Console.WriteLine("--------------------Lista Depois-----------------------------");
            Console.WriteLine("A lista tem " + pessoas.Count() + " elementos.");

            foreach (Pessoa ind in pessoas)
            {
              Console.WriteLine(ind.Nome + ", " + ind.Idade);

            }
        

            Console.WriteLine("------------------OUTRO EXERCICIO--------------------------------");

            Vendedor v = new Vendedor("Roberto", 37, 2500);
            Supervisor s = new Supervisor("Carlos", 25, 4100);
            Gerente g = new Gerente("Ingrid", 30, 6000);

            v.Bonificacao();
            s.Bonificacao();
            g.Bonificacao();








        }
    }
}
