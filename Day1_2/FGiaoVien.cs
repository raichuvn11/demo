using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1_2
{
    public partial class FGiaoVien : Form
    {
        SqlConnection conn= new SqlConnection(Properties.Settings.Default.cnnStr);
        public FGiaoVien()
        {
            InitializeComponent();
        }

        private void FGiaoVien_Load(object sender, EventArgs e)
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO();
            gvGiaoVien.DataSource = giaoVienDAO.Load();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO(txtHoVaTen.Text, txtDiachi.Text, datNgayThang.Value, txtCMND.Text);
            giaoVienDAO.Sua();
            FGiaoVien_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO(txtHoVaTen.Text, txtDiachi.Text, datNgayThang.Value, txtCMND.Text);
            giaoVienDAO.Them();
            FGiaoVien_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        { 
            GiaoVienDAO giaoVienDAO = new GiaoVienDAO(txtHoVaTen.Text, txtDiachi.Text, datNgayThang.Value, txtCMND.Text);
            giaoVienDAO.Xoa();
            FGiaoVien_Load(sender, e);
        }

        private void gvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gvGiaoVien.Rows[e.RowIndex];
            txtHoVaTen.Text = Convert.ToString(row.Cells[0].Value);
            txtDiachi.Text = Convert.ToString(row.Cells[1].Value);
            txtCMND.Text = Convert.ToString(row.Cells[3].Value);
        }
    }
}
