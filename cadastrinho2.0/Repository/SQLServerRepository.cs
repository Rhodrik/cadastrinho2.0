using cadastrinho2._0.Conexoes;
using cadastrinho2._0.Entities;
using cadastrinho2._0.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Repository
{
    public class SQLServerRepositoryPessoa : IRepositoryPessoa
    {
        private readonly IConnection conn;

        public SQLServerRepositoryPessoa(IConnection conn)
        {
            this.conn = conn;
        }

        public void Insert(Pessoa pessoa)
        {
            string insertSql = "INSERT INTO todosdados (Id, Nome, Telefone, DatadeNascimento, Cpf) VALUES (@Id, @Nome, @Telefone, @DatadeNascimento, @Cpf)";
            SqlCommand comando = new SqlCommand();
            comando.Connection = (SqlConnection)conn.GetDbConnection();
            comando.CommandText = insertSql;
            comando.Parameters.AddWithValue("@Id", pessoa.Id);
            comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
            comando.Parameters.AddWithValue("@Cpf", pessoa.CPF);
            comando.Parameters.AddWithValue("@DatadeNascimento", pessoa.DataNascimento);
            comando.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
            comando.ExecuteNonQuery();
        }
    }
}
