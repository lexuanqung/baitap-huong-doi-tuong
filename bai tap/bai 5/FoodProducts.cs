using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace bai_5
{
    class FoodProducts
    {
        string mahang;
        string tenhang;
        double dongia;
        DateTime NSX , NHH;

        public FoodProducts(string mahang, string tenhang, double dongia, DateTime nSX, DateTime nHH)
        {
            this.mahang = mahang;
            this.tenhang = tenhang;
            this.dongia = dongia;
            NSX = nSX;
            NHH = nHH;
        }

        public FoodProducts()
        {
        }

        public void set_Mahang(String NewMahang) 
        {
            if (!NewMahang.Trim().Equals(" ")) { this.mahang = NewMahang; }
            else throw new Exception("Dafult!");
        } 
        public void set_Tenhang(string NewTenhang)
        {
            if (!NewTenhang.Trim().Equals(" ")) this.tenhang = NewTenhang;
            else throw new Exception("xxx");
        }
        public void set_Dongia(double NewDongia) { if (NewDongia > 0) this.dongia = NewDongia; else NewDongia = 0; }
        public void setNSX(DateTime newNSX)
        {
            if (DateTime.Compare(newNSX, DateTime.Today) < 0) NSX = newNSX;
            else NSX = DateTime.Today;
        }
        public void setNHH(DateTime newEXP)
        {
            if (DateTime.Compare(newEXP, NSX) > 0) NHH = newEXP;
            else NHH = NSX;
        }
        public string get_Mahang() { return mahang; }
        public string get_Tenhang() { return tenhang; }
        public double get_Dongia() { return dongia; }
        public DateTime get_NSX() { return NSX; }
        public DateTime get_NHH() { return NHH; }

        public bool Ghichu()
        {
            return (DateTime.Compare(NHH, DateTime.Today) < 0);
        }

        public static void printtitile()
        {
            Console.WriteLine("| {0,-15} | {1,-10} | {2,-12} | {3,-20} | {4,-20} | {5,-25} |", "MA_HANG", "TEN_HANG", "DON_GIA", "NGAY_SAN_XUAT", "NGAY_HET_HAN", "GHI_CHU");
        }
        public void Tostring()
        {
            Console.WriteLine("| {0,-15} | {1,-10} | {2,-12} | {3,-20} | {4,-20} | {5,-25} |", mahang, tenhang, dongia, NSX, NHH, Ghichu());
        }
    }
}
