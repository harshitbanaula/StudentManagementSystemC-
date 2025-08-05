using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Database
{
    public static class DB
    {
        private static readonly string connectionString = "Server=.\\SQLEXPRESS;Database=StudentDatabase;Trusted_Connection=True;Encrypt= False;";

        public static SqlConnection GetConnection() {
            return new SqlConnection(connectionString);
        
        }


    }
}
