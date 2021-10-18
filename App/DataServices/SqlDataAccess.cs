using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Interface;

namespace App.DataServices
{
    class SqlDataAccess : IDataAccess
    {
        DataSet _data;
        string _connection;
        public SqlDataAccess(string connection)
        {
            _connection = connection;
        }
        public void Load()
        {
            
        }
    }
}
