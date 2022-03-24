using System;
using System.Collections.Generic;
using System.Text;

namespace bai_8
{
    class ListCD  :CD
    {
        List<CD> listcd = new List<CD>();
        public void themvaodanhsach()
        {
            CD b = new CD();
            b.input();
            int dem = 0;
            for (int i = 0; i < listcd.Count; i++)
            {
                if (b.getMaCD() == listcd[i].getMaCD())
                {
                    dem++;
                    ///Console.WriteLine("CD ban vua nhap trung trong danh sach.");
                }
                
            }if (dem == 0) listcd.Add(b);
            else Console.WriteLine("CD ban vua nhap trung trong danh sach.");



        }
        public void soluongCD()
        {
            Console.WriteLine($"Số lượng CD {listcd.Count}");

        }
        public void tongGiathanh()
        {
            double tong = 0;
            for (int i = 0; i < listcd.Count; i++)
            {
                
                tong +=  listcd[i].getGiathanh();
            }
            Console.WriteLine("Tong gia thanh: {0}", tong);
        }
        public void trathongtin()
        {
            for (int i = 0; i < listcd.Count; i++)
            {
                listcd[i].printtitle();
                listcd[i].toString();
            }
        }
        public void sapxeptheoGiaThanh()///sắp xếp giam dần theo giá thành
        {
            listcd.Sort(new SortByGiaThanh());
            System.Console.WriteLine("Danh sach da duoc sap xe giam dan theo gia thánh");
        }
        public void sapxeptheoTuaCD()///sắp xếp tăng dần theo Tua CD
        {
            listcd.Sort(new SortByTuaCD());
            System.Console.WriteLine("Danh sach da duoc sap xep giam dan theo TuaCD");
        }
    }
    
}
