using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tuan1
{
    public static class HocSinhDAO
    {
        public static DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            ppConnection ppcon = new ppConnection();
            return ppcon.Load(sqlStr);
        }
        public static void Them(string hoten, string diachi, string cmnd, string birthdate)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, Ngaysinh) VALUES ('{0}', '{1}', {2}, {3})", hoten, diachi, cmnd, birthdate);
            ppConnection ppcon = new ppConnection();
            ppcon.ThucThi(sqlStr);
        }
        public static void Sua(string hoten,string diachi,string cmnd,string birthdate)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten ='{0}', Diachi='{1}', Ngaysinh = '{2}' WHERE Cmnd={3}", hoten, diachi, birthdate, cmnd);
            ppConnection ppcon = new ppConnection();
            ppcon.ThucThi(sqlStr);
        }
        public static void Xoa(string cmnd)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd={0}", cmnd);
            ppConnection ppcon = new ppConnection();
            ppcon.ThucThi(sqlStr);
        }
    }
}
