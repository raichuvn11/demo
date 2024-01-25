using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1_2
{
    internal class HocSinhClass:PerSonClass
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);

        public HocSinhClass() { }
        public HocSinhClass(string ten, string diachi, DateTime ngaysinh, string cmnd):base(ten,diachi, ngaysinh, cmnd) { }
        
    }
}
