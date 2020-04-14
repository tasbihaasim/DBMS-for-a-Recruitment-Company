using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;


namespace Manager
{
    class DBconnectioncs
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=47250FOSJ2ACO\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True");
        public SqlCommand cmd = new SqlCommand();

        public DBconnectioncs()
        { }
        public void Inserts(string query) // insert / update / delete
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();


        }
        public DataTable Select(string query) // select query
        {
            conn.Open();
            cmd.CommandText = query;
            cmd.Connection = conn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Close();
            return dt;
        }

    }
}