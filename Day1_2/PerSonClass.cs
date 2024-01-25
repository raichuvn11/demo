using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day1_2
{
    abstract class PerSonClass
    {
        private string _ten;
        private string _diachi;
        private DateTime _ngaysinh;
        private string _cmnd;
        public PerSonClass() { }
        public PerSonClass(string ten, string diachi, DateTime ngaysinh, string cmnd)
        {
            Ten = ten;
            Diachi = diachi;
            Ngaysinh = ngaysinh;
            Cmnd = cmnd;
        }

        public string Ten { get => _ten; set => _ten = value; }
        public string Diachi { get => _diachi; set => _diachi = value; }
        public DateTime Ngaysinh { get => _ngaysinh; set => _ngaysinh = value; }
        public string Cmnd { get => _cmnd; set => _cmnd = value; }

        

    }
}
