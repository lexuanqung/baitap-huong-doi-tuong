using System;
using System.Collections.Generic;
using System.Text;

namespace bai_1
{
    class chuyenxe
    {
        private int maSochuyen;
        private string hoTaixe = "";
        private byte soXe;
        private double doanhthu;
        public void setMaSochuyen(int newMasochuyen) { if (newMasochuyen > 0) this.maSochuyen = newMasochuyen; else newMasochuyen = 1; }
        public void setHoTaixe(string NewHoTaixe) { if (!NewHoTaixe.Trim().Equals("")) this.hoTaixe = NewHoTaixe; else throw new Exception("!Default"); }
        public void setSoxe(byte newSoxe) { this.soXe = newSoxe; }
        public void setDoanhthu(double NewDoanhthu) { this.doanhthu = NewDoanhthu; }
        public int getMaSochuyen() { return maSochuyen; }
        public string getHoTaixe() { return hoTaixe; }
        public byte getSoxe() { return soXe; }
        public double getDoanhthu() { return doanhthu; }

        public chuyenxe(int maSochuyen, string hoTaixe, byte soXe)
        {
            this.maSochuyen = maSochuyen;
            this.hoTaixe = hoTaixe;
            this.soXe = soXe;
        }
    }
}
