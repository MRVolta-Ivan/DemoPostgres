using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace DemoPostgres
{
    class DBConnection
    {
        public static DBConnection instance = new DBConnection();

        private NpgsqlConnection con;

        private DBConnection()
        {
        }

        public void Init(string login, string password)
        {
            var cs = "Host=25.83.26.128;" +
                   "Username=" + login + ";" +
                   "Password=" + password + ";" +
                   "Database=postgres";

            con = new NpgsqlConnection(cs);
            con.Open();
        }

        public void CloseCon()
        {
            con.Close();
        }

        public List<List<string>> ExecuteSQL(string sql)
        {
            var cmd = new NpgsqlCommand(sql, con);

            var reader = cmd.ExecuteReader();

            List<List<string>> result = new List<List<string>>();

            while(reader.Read())
            {
                List<string> listString = new List<string>();

                for (int i = 0; i < reader.FieldCount; i++)
                    listString.Add(reader[i].ToString());

                result.Add(listString);
            }

            reader.Close();

            return result;
        }
    }
}
