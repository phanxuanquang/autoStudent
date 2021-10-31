using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using App.Interface;
using App.Models;

namespace App.DataServices
{
    class SoftwareReponsitory : ISoftwareRepository
    {
        protected readonly IDataAccess _context;
        public SoftwareReponsitory(IDataAccess context)
        {
            _context = context;
        }
        public List<Software> GetAll()
        {
            List<Software> result = new List<Software>();
            string query = "SELECT [Id_Software], [Name], [Link], [Type] FROM Application";
            using(var connection=new SQLiteConnection())
            {
                connection.ConnectionString = _context.GetConnectionString();
                connection.Open();
                using(var command=new SQLiteCommand(query, connection))
                {
                    SQLiteDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Enum.TryParse<TypeOfFileInstall>(reader.GetString(3), out var types);
                        result.Add(new Software() { 
                            Id = reader.GetInt32(0), 
                            Name = reader.GetString(1), 
                            LinkDownload = reader.GetString(2), 
                            Types = types, 
                            InstallControlHanders = null 
                        });
                    }
                }
                connection.Close();
            }
            return result;
        }
        public List<Software> GetAllByTypeOfSoftware(TypeOfSoftware type)
        {
            List<Software> result = new List<Software>();
            using (var connection = new SQLiteConnection())
            {
                connection.ConnectionString = _context.GetConnectionString();
                connection.Open();
                string queryApplication = "SELECT [Id_Software], [Name], [Link], Application.[Type] FROM Application, Type WHERE Application.Id_Type=Type.Id_Type AND Type.Type=@select";
                using (var command = new SQLiteCommand(queryApplication, connection))
                {
                    command.Parameters.AddWithValue("@select", type.ToString());
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Enum.TryParse<TypeOfFileInstall>(reader["Type"].ToString(), out var types);
                            result.Add(new Software()
                            {
                                Id = int.Parse(reader["Id_Software"].ToString()), 
                                Name = reader["Name"].ToString(),
                                LinkDownload = reader["Link"].ToString(),
                                Types = types,
                                InstallControlHanders = null
                            });
                        }
                    }
                }
                for(int index = 0; index < result.Count; index++)
                {
                    List<InstallControlHander> installControlHanders = new List<InstallControlHander>();
                    string queryInstall = "SELECT [Control_Class], [Control_Text], [Control_ID], [Mouse_Position], [Thread_Sleep] FROM Install WHERE [Id_Software] = " + result[index].Id + " ORDER BY [Id] ASC";
                    using (var command = new SQLiteCommand(queryInstall, connection))
                    {
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                installControlHanders.Add(new InstallControlHander(reader["Control_Class"].ToString(), reader["Control_Text"].ToString(), reader["Control_ID"].ToString(), reader["Mouse_Position"].ToString(), reader["Thread_Sleep"].ToString()));
                            }
                        }
                    }
                    result[index].InstallControlHanders = installControlHanders;
                }
                connection.Close();
                return result;
            }
        }
    }
}
