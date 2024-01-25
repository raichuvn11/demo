using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1_2
{
    internal class DBconnect
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public DBconnect() { }
        public void thucthi(string sqlStr)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("thanh cong");
            }
            catch (Exception exe)
            {
                MessageBox.Show("that bai " + exe);
            }
            finally { conn.Close(); }

        }
        public DataTable Load(string sqlStr)
        {
            DataTable dtSinhVien = new DataTable();
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                adapter.Fill(dtSinhVien);
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            finally { conn.Close(); }
            return dtSinhVien;
        }
    }
}
