using cadastrinho2._0.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Services
{
    public class UpdatePessoaServico
    {
        private const string updateSql = "update sql";
        private SqlConnection conexao;

        public UpdatePessoaServico(SqlConnection conexao)
        {
            this.conexao = conexao;
        }

        public void Inserir(Pessoa pessoa)
        {
            conexao.Open();
            try
            {
                var comando = conexao.CreateCommand();
                comando.CommandText = updateSql;
                comando.Parameters.AddWithValue("@Id", pessoa.Id);
                comando.Parameters.AddWithValue("@Nome", pessoa.Nome);
                comando.Parameters.AddWithValue("@Cpf", pessoa.CPF);
                comando.Parameters.AddWithValue("@DatadeNascimento", pessoa.DataNascimento);
                comando.Parameters.AddWithValue("@Telefone", pessoa.Telefone);
                comando.ExecuteNonQuery();
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
