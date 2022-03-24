using System;

namespace bai_8
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCD a = new ListCD();
            int n;
            do
            {
                Console.WriteLine(
                    "1. Them 1 CD vao danh sach. \n" + 
                    "2. So luong CD co trong danh sach. \n" + 
                    "3. Tong gia thanh cua cac CD. \n" +
                    "4. Sap xep danh sach theo gia thanh giam dan.\n"+
                    "5. Sap xep danh sach theo Tua Cd tang dan.\n" +
                    "6. Tra thong tin.");
                Console.Write("Moi nhap chon: ");
                n = Convert.ToInt32(Console.ReadLine());
                CD b = new CD();
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ban muon 1 CD vao danh sach. Moi ban nhap thong tin CD: ");
                        
                        a.themvaodanhsach();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("So luong CD co trong danh sach: ");
                        a.soluongCD();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Tong gia thanh cua CD:");
                        a.tongGiathanh();
                        break;
                    case 4:
                        Console.Clear();
                        a.sapxeptheoGiaThanh();
                        a.trathongtin();
                        break;
                    case 5:
                        Console.Clear();
                        a.sapxeptheoTuaCD();
                        a.trathongtin();
                        break;
                    case 6:
                        Console.Clear();
                        a.trathongtin();
                        break;
                    default:
                        Console.WriteLine("Vui long chon 1-5:");
                        break;

                }

            } while (n != 0);
        }
    }
}
