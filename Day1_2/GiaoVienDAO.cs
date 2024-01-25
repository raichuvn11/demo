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
    internal class GiaoVienDAO:PerSonClass
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        DBconnect dbc = new DBconnect();
        public GiaoVienDAO() { }
        public GiaoVienDAO(string ten, string diachi, DateTime ngaysinh, string cmnd) : base(ten, diachi, ngaysinh, cmnd) { } 
        public void Them()
        {
            string sqlStr = string.Format("INSERT INTO GiaoVien(Ten ,Diachi ,Cmnd ,NgaySinh) VALUES('{0}','{1}','{2}','{3}')", Ten, Diachi, Cmnd, Ngaysinh.ToString("dd/MM/yyyy"));
            dbc.thucthi(sqlStr);

        }
        public void Sua()
        {
            string sqlStr = string.Format("UPDATE GiaoVien SET Ten= '{0}', DiaChi = '{1}',NgaySinh = '{2}' WHERE Cmnd = '{3}'", Ten, Diachi, Ngaysinh.ToString("dd/MM/yyyy"), Cmnd);
            dbc.thucthi(sqlStr) ;
        }
        public void Xoa()
        {
            string sqlStr = string.Format("DELETE FROM GiaoVien WHERE Cmnd = '{0}'", Cmnd);
            dbc.thucthi(sqlStr);
        }
        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM GiaoVien");
            return dbc.Load(sqlStr);
        }
    }
}
