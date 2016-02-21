using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace WindowsFormsApplication1
{
    class DbTableCreation
    {
        private static string DbCreate = "CREATE DATABASE league; ";
        private static string connectionStr = String.Format("Server=127.0.0.1;Port=5432;" +
                    "User Id=postgres;Password=admin;database=postgres;");
        static public  void databaseCreation()
        {
            NpgsqlConnection conn = new NpgsqlConnection(connectionStr);
            conn.Open();
            NpgsqlCommand command = new NpgsqlCommand(DbCreate, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }
        static public bool checkIfExists()
        {
           
          
                NpgsqlConnection conn = new NpgsqlConnection(connectionStr);
                conn.Open();
                
                NpgsqlCommand command = new NpgsqlCommand("select count(*) from pg_catalog.pg_database where datname = 'league';", conn);
                object temp = command.ExecuteScalar();
                conn.Close();
                if (Convert.ToInt32(temp) == 0)
                {
                    return false;
                }
                
                
                return true;

        }
     


    }
}
