using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private int _idade;

        public string Nome
        {
            get => _nome.ToUpper();


            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _nome = value;
            }

        }

        public string Sobrenome { get ; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        public int Idade
        {
            get => _idade;

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }
        //virtual diz que o metodo pode ser mudado pelo Polimorfismo
        public virtual void apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}
