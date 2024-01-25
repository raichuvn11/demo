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

namespace Tuan1
{
    public partial class GiaovienForm : Form
    {
        public GiaovienForm()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(textBox1.Text,textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            GiaoVienDAO.Them(gv.Hoten, gv.Diachi, gv.Cmnd, gv.Birthdate);
            Form2_Load(sender, e);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                gvGiaovien.DataSource = GiaoVienDAO.Load();
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                textBox1.DataBindings.Add("text", gvGiaovien.DataSource, "Ten");
                textBox2.DataBindings.Add("text", gvGiaovien.DataSource, "Diachi");
                textBox3.DataBindings.Add("text", gvGiaovien.DataSource, "Cmnd");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            GiaoVienDAO.Xoa(gv.Cmnd);
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            GiaoVienDAO.Sua(gv.Hoten, gv.Diachi, gv.Cmnd, gv.Birthdate);
            Form2_Load(sender, e);
        }
    }
}
