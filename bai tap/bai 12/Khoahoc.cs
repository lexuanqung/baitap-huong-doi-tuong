using System;
using System.Collections.Generic;
using System.Text;

namespace bai_12
{
    class Khoahoc
    {
        
        private string tenKhoa;
        private DateTime ngayMo;
        private DateTime tgHoc;
        private Student[] listStudent;
        List<Student> listStudents;
        private byte top = 0;

        public Khoahoc(string tenKhoa, DateTime ngayMo, DateTime tgHoc)
        {
            this.tenKhoa = tenKhoa;
            this.ngayMo = ngayMo;
            this.tgHoc = tgHoc;
            this.listStudent = new Student[20];
        }

        public void addSTudent(Student student)
        {
            
            if(top < 20)
            {
                listStudent[top] = student;
                top++;
            }else
            {
                throw new Exception("Not add!");
            }
        }
        public Student[] getStudent()
        {
            Student[] students = new Student[top];
            for (int i = 0; i < top; i++)
            {
                students[i] = listStudent[i];
            }return students;
        }
        public List<Student> getStudentlist()
        {
            return listStudents;
        }
        public string getTenKhoa()
        {
            return tenKhoa;
        }
        public DateTime getNgayMo()
        {
            return ngayMo;
        }

        public DateTime getTGHoc() { return tgHoc; }
    }
}
