using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class AddValues : Queries
    {
        public void addMatchResults(string sqlString)
        {
            try
            {
                string connstring = String.Format("Server=127.0.0.1;Port=5432;" +
                    "User Id=postgres;Password=admin;Database=league;");
                NpgsqlConnection conn = new NpgsqlConnection(connstring);
                conn.Open();
                NpgsqlTransaction tran = conn.BeginTransaction();
                NpgsqlCommand da = new NpgsqlCommand(sqlString, conn);

                da.ExecuteNonQuery();
                tran.Commit();
                conn.Close();
            }
            catch (Exception msg)
            {
                // something went wrong, and you wanna know why
                MessageBox.Show(msg.ToString());
                throw;
            }
        }
    }
}
