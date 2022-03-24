using System;
using System.Collections.Generic;
using System.Text;

namespace bai_12
{
    class Student
    {
        private string hoTen;
        private string diaChi;
        private String sDT;
        public string HoTen { 
            get { return hoTen; }
            set { hoTen = value; }
        }
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public string SDT
        {
            get { return sDT; }
            set { sDT = value; }
        }

        public Student(string hoTen, string diaChi, string sDT)
        {
            this.hoTen = hoTen;
            this.diaChi = diaChi;
            SDT = sDT;
        }
    }
}
