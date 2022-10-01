using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Entities
{
    public class Pessoa
    {
        public Pessoa()
        {

        }

        public Pessoa(string id, string nome, string telefone, DateTime datanascimento, string cpf)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            DataNascimento = datanascimento;
            CPF = cpf;
        }

        public string Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
    }
}
