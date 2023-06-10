using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ITP4915_group3_project.database
{
    class dbConnect 
    {
        public string connStr = "server = localhost; user = root; database = 4523_g1_project_db; port = 3308; password = 123123";
        public MySqlConnection conn;
        public dbConnect()
        {
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public MySqlConnection getConn()
        {
            return conn;
        }

    }
    
}
