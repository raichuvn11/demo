using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan1
{
    public class ppConnection
    {
        public void ThucThi(string sqlString)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            try
            {
                conn.Open();
                string sqlStr = sqlString;
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("That bai" + ex);
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable Load(string sqlString)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
            conn.Open();
            string sqlStr = sqlString;
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dtSinhVien = new DataTable();
            adapter.Fill(dtSinhVien);
            conn.Close();
            return dtSinhVien;
        }
    }
}
