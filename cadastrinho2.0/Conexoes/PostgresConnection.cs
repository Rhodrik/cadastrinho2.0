using cadastrinho2._0.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Conexoes
{
    public class PostgresConnection : IConnection
    {
        private string strConn = "Host....";
        private NpgsqlConnection conn;

        public PostgresConnection()
        {
            conn = new NpgsqlConnection(strConn);
        }
        public void Close()
        {
            conn.Close();   
        }

        public IDbConnection GetDbConnection()
        {
            return conn;
        }

        public void Open()
        {
            conn.Open();
        }
    }
}
