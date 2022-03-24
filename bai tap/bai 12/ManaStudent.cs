using System;
using System.Collections.Generic;
using System.Text;

namespace bai_12
{
    class ManaStudent
    {
        private List<Khoahoc> khoahocs;
        public ManaStudent()
        {
            khoahocs = new List<Khoahoc>();
            Khoahoc java = new Khoahoc("java",
                                new DateTime(2022,01,15), new DateTime(2022,01,20));

            java.addSTudent(new Student("Le Xuan Quang", "Quan 7", "023928435"));
            java.addSTudent(new Student("Ly Vi Phong", "Quan 10", "013886565"));
            java.addSTudent((new Student("Luu Khoa Hoc", "Quan 8", "012848564")));
            khoahocs.Add(java);

            Khoahoc csharp = new Khoahoc("csharp",
                                new DateTime(2022,05, 01), new DateTime(2022,06,01));
            csharp.addSTudent(new Student("Banh Thi Loi Le", "Quan 1", "01285476"));
            csharp.addSTudent(new Student("Nguyen Thi Thanh Thao", "Quan 2", "0129183232"));
            csharp.addSTudent(new Student("Le Xuan Quang", "Quan 7", "023928435"));
            csharp.addSTudent(new Student("Hong Binh Hoanh", "Quan 11", "0238237437"));
            khoahocs.Add(csharp);

            Khoahoc js = new Khoahoc("javascript",
                                new DateTime(2022,10,30), new DateTime(2022, 12, 01));
            js.addSTudent(new Student("Le Xuan Quang", "Quan 7", "023928435"));
            js.addSTudent(new Student("Ly Vi Phong", "Quan 10", "013886565"));
            js.addSTudent(new Student("Nguyen Thi Thanh Thao", "Quan 2", "0129183232"));
            js.addSTudent(new Student("Nguyen Thao My", "Quan 1", "0123456789"));
            khoahocs.Add(js);


        }
    }
}
