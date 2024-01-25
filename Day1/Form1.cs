using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Day1
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FHocSinh()
        {
            InitializeComponent();
        }

        private void FHocSinh_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM HocSinh");

                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtSinhVien= new DataTable();
                adapter.Fill(dtSinhVien);
                gvHocSinh.DataSource = dtSinhVien;
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
            finally { conn.Close(); }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string sqlStr = string.Format("INSERT INTO HocSinh(Ten, Diachi) VALUE('{0}','{1}')", txtHoVaTen.Text, txtDiachi.Text);
                SqlCommand cmd = new SqlCommand(sqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("them thanh cong");
            }
            catch (Exception exe)
            {
                MessageBox.Show("them that bai " + exe);
            }
            finally { conn.Close(); }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string SqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = '{0}'", txtCMND.Text);
                SqlCommand cmd = new SqlCommand(SqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("xoa thanh cong");
            }
            catch (Exception ex)
            {
                MessageBox.Show("xoa that bai " + ex);
            }
            finally { conn.Close(); }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string SqlStr = string.Format("UPDATE HocSinh SET Ten= '{0}', DiaChi = '{1}' WHERE Cmnd = '{2}'", txtHoVaTen.Text, txtDiachi.Text, txtCMND.Text);
                SqlCommand cmd = new SqlCommand(SqlStr, conn);
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("Sua Thanh Cong");
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sua that bai " + ex);
            }
            finally { conn.Close(); }
        }
    }
}
