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
using System.Xml.Linq;

namespace Day1_2
{
    public partial class FHocSinh : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public FHocSinh()
        {
            InitializeComponent();
        }
        private void FHocSinh_Load_1(object sender, EventArgs e)
        {
            
            HocSinhDAO hsdao = new HocSinhDAO();
            gvHocSinh.DataSource = hsdao.Load();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsdao = new HocSinhDAO(txtHoVaTen.Text, txtDiachi.Text, datNgayThang.Value, txtCMND.Text);
            hsdao.Them();
            FHocSinh_Load_1(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsdao = new HocSinhDAO(txtHoVaTen.Text, txtDiachi.Text, datNgayThang.Value, txtCMND.Text);
            hsdao.Xoa();
            FHocSinh_Load_1(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinhDAO hsdao = new HocSinhDAO(txtHoVaTen.Text, txtDiachi.Text, datNgayThang.Value, txtCMND.Text);
            hsdao.Sua();
            FHocSinh_Load_1(sender, e);
        }

        private void gvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = gvHocSinh.Rows[e.RowIndex];
            txtHoVaTen.Text = Convert.ToString(row.Cells[0].Value);
            txtDiachi.Text = Convert.ToString(row.Cells[1].Value);
            txtCMND.Text = Convert.ToString(row.Cells[3].Value);

        }
    }
}
