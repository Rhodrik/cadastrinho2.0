using cadastrinho2._0.Entities;
using cadastrinho2._0.Interfaces;
using cadastrinho2._0.Repository;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Services
{
    public class InserirPessoaServico
    {        
        private IConnection conexao;
        private readonly IRepositoryPessoa repository;

        public InserirPessoaServico(IConnection conexao, IRepositoryPessoa repository)
        {
            this.conexao = conexao;
            this.repository = repository;
        }

        public void Inserir(Pessoa pessoa)
        {
            conexao.Open();
            try
            {
                repository.Insert(pessoa);  
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
