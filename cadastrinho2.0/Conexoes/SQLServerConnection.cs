using cadastrinho2._0.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Conexoes
{
    public class SQLServerConnection : IConnection
    {
        string strConn = "Data Source=DESKTOP-2KT82C9\\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private readonly SqlConnection conn;

        public SQLServerConnection()
        {
            conn = new SqlConnection(strConn);
        }

        public void Close()
        {
            conn.Close();  
        }

        public void Open()
        {
            conn.Open();
        }

        public IDbConnection GetDbConnection()
        {
            return conn;
        }
    }
}
