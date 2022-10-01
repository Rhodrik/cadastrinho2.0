using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cadastrinho2._0.Interfaces
{
    public interface IConnection
    {
        void Open();
        void Close();
        IDbConnection GetDbConnection();
    }
}
