using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTraCSDL
{
    internal class DatabaseRun
    {
        String connectionString = "Data Source=DESKTOP-I7HF24F\\SQLEXPRESS;Initial Catalog=QLXeMay;Integrated Security=True";
        SqlConnection connection = null;
        private void KetNoi()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }
        private void Dong()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
            connection.Dispose();
        }
        public DataTable DocData(String sql)
        {
            DataTable tb = new DataTable();
            KetNoi();
            SqlDataAdapter ad = new SqlDataAdapter(sql, connection);
            ad.Fill(tb);
            Dong();
            return tb;
        }
        public void CapNhat(String sql)
        {
            KetNoi();
            SqlCommand cmd = new SqlCommand(sql, connection);
            cmd.ExecuteNonQuery();
            Dong();
        }
    }
}
