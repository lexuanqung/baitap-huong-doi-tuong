using System;

namespace bai_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var o = new HinhTron(new ToaDo(5,5), 10.5);
            Console.WriteLine("Hinh tron co tam: ");
            Console.WriteLine("Tinh chu vi: " + o.tinhChuvi()); 
            Console.WriteLine("Tinh dien tich: " + o.tinhDientich()); 
            Console.WriteLine();
        }
    }
}
