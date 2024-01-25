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

namespace Tuan1
{
    public partial class HocsinhForm : Form
    {
        public HocsinhForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { 
                gvHocsinh.DataSource = HocSinhDAO.Load();
                textBox1.DataBindings.Clear();
                textBox2.DataBindings.Clear();
                textBox3.DataBindings.Clear();
                textBox1.DataBindings.Add("text", gvHocsinh.DataSource, "Ten");
                textBox2.DataBindings.Add("text", gvHocsinh.DataSource, "Diachi");
                textBox3.DataBindings.Add("text", gvHocsinh.DataSource, "Cmnd");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            HocSinhDAO.Them(hs.Hoten, hs.Diachi, hs.Cmnd, hs.Birthdate);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            HocSinhDAO.Xoa(hs.Cmnd);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh(textBox1.Text, textBox2.Text, textBox3.Text, dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            HocSinhDAO.Sua(hs.Hoten,hs.Diachi,hs.Cmnd, hs.Birthdate);
            Form1_Load(sender, e);
        }

        private void btnOpenForm_Click(object sender, EventArgs e)
        {
            GiaovienForm form2 = new GiaovienForm();
            form2.ShowDialog();
        }
    }
}
