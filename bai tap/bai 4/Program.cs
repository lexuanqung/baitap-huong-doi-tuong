using System;

namespace bai_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Vehicle("Le Xuan Quang", "Sirus", 50, 20000000);
            var car2 = new Vehicle("Nguyen Thanh Nha", "exciel", 150, 60000000);
            var car3 = new Vehicle("Le Thi Thanh Nhan", "vario", 230, 80000000);

            Vehicle.Printtitle();
            Console.WriteLine("----------------------------------");
            car1.ToString();
            car2.ToString();
            car3.ToString();
            Console.WriteLine("----------------------------------");
        }
    }
}
