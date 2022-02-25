using System;

namespace bai_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var h1 = new FoodProducts("1", "Mì tôm", 5000, new DateTime(2022/01/17), new DateTime(2023/01/17));
            var h2 = new FoodProducts("2", "Bánh mì", 4000, new DateTime(2022 / 01 / 17), new DateTime(2023 / 03 / 17));
            var h3 = new FoodProducts("3", "Nước", 10000, new DateTime(2022 / 01 / 17), new DateTime(2025 / 09 / 17));
            FoodProducts.printtitile();
            h1.Tostring();
            h2.Tostring();
            h3.Tostring();
            Console.WriteLine("--------------------------------------");


        }
    }
}
