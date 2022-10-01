using cadastrinho2._0.Entities;
using cadastrinho2._0.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Repository
{
    public class PostgresRepositoryPessoa : IRepositoryPessoa
    {
        private readonly IConnection conn;

        public PostgresRepositoryPessoa(IConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Pessoa pessoa)
        {
            NpgsqlCommand comando = new NpgsqlCommand();
            comando.Connection = (NpgsqlConnection) conn.GetDbConnection();
            comando.CommandText = "";
            comando.Parameters.AddWithValue("@Id", pessoa.Id);
            comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
            comando.Parameters.AddWithValue("@Cpf", pessoa.CPF);
            comando.Parameters.AddWithValue("@DatadeNascimento", pessoa.DataNascimento);
            comando.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
            comando.ExecuteNonQuery();
        }

        public void Insert2(Pessoa pessoa, string nome2)
        {
            throw new NotImplementedException();
        }
    }
}
