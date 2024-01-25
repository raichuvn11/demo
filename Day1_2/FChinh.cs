using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1_2
{
    public partial class FChinh : Form
    {
        public FChinh()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenForm(Form form)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panel1.Controls.Add(form);
            panel1.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            OpenForm(new FHocSinh());
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            OpenForm(new FGiaoVien());
        }
    }
}
