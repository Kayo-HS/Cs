using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }

        public override void apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota: {Nota}");
        }
    }
}