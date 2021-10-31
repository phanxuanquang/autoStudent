using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using App.Interface;

namespace App.DataServices
{
    class SqlDataAccess : IDataAccess
    {
        //DataSet _data;
        string _connectionString;
        public SqlDataAccess(string pathDatabase)
        {
            if (!File.Exists(pathDatabase))
            {
                throw new ArgumentOutOfRangeException("Not found database");
            }
            _connectionString = "Data Source=" + pathDatabase + ";Version=3;";
        }
        public string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
