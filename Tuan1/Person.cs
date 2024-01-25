using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan1
{
    public abstract class Person
    {
        private string hoten;
        private string diachi;
        private string cmnd;
        private string birthdate;
        public string Hoten { get => hoten; set => hoten = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public Person(string hoten, string diachi, string cmnd, string birthdate)
        {
            Hoten = hoten;
            Diachi = diachi;
            Cmnd = cmnd;
            Birthdate = birthdate;
        }
    }
}
