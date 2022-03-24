using System;
using System.Collections.Generic;
using System.Text;

namespace bai_8
{
    class CD
    {
        private int maCD, sobaihat;
        private string tuaCD;
        private double giathanh;

        public CD()
        {
        }

        public CD(int maCD,  string tuaCD, int sobaihat, double giathanh)
        {
            this.maCD = maCD;
            this.sobaihat = sobaihat;
            this.tuaCD = tuaCD;
            this.giathanh = giathanh;
        }

      

        public void setMaCD(int NewMaCD) { if (NewMaCD > 0) this.maCD = NewMaCD; else NewMaCD = 9999999; }
        public void setTuaCD(string NewTuaCD) { if (NewTuaCD.Trim().Equals(" ")) this.tuaCD = NewTuaCD; else throw new Exception("chua xac dinh"); }
        public void setSobaihat(int NewSobaihat) { if (NewSobaihat > 0) this.sobaihat = NewSobaihat;  }
        public void setGiathanh(double NewGiathanh) { if (NewGiathanh > 0) this.giathanh = NewGiathanh; }
        public int getMaCD() { return maCD; }
        public string getTuaCD() { return tuaCD; }
        public int getSobaihat() { return sobaihat; }
        public double getGiathanh() { return giathanh; }
         public void printtitle()
        {
            Console.WriteLine("| {0,-15} | {1,-15} | {2, -18} | {3,-20} |", "MaCD", "TuaCD", "Sobaihat", "Giathanh");
        }
        public void toString(int stt)
        {
            Console.WriteLine("| {0,-15} | {1,-15} | {2, -18} | {3,-20} | {4,-20} |",stt, maCD, tuaCD, sobaihat, giathanh);
        }
        public void toString()
        {
            Console.WriteLine("| {0,-15} | {1,-15} | {2, -18} | {3,-20} |", maCD, tuaCD, sobaihat, giathanh);
        }
        public void input()
        {
            Console.Write("Nhap ma CD: ");
            maCD = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap so bai hat; ");
            sobaihat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap tua CD: ");
            tuaCD = Console.ReadLine();
            Console.Write("Nhap gia thanh: ");
            giathanh = Convert.ToDouble(Console.ReadLine());

        }
    }
    class SortByGiaThanh : IComparer<CD>
    {
        public int Compare(CD x, CD y)
        {
            return x.getGiathanh().CompareTo(y.getGiathanh());
        }
    }
    class SortByTuaCD : IComparer<CD>
    {
        public int Compare(CD x, CD y)
        {
            return y.getTuaCD().CompareTo(x.getTuaCD());
        }
    }
}
