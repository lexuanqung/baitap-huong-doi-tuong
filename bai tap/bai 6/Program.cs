using System;

namespace bai_6
{
    class Program
    {
        static void Main(string[] args)
        {
            /// xuat thông tin 3 acc
            var acc1 = new Account( "Ted Murphy", 72354, 102.56);
            var acc2 = new Account("Jane Smith", 69713, 40.00);
            var acc3 = new Account("Edward Demsey", 93757, 759.32);
            
            acc1.deposit(25.85); /// Thêm tiền cho acc1
            acc2.deposit(500.00); /// thêm tiền cho acc2
            acc2.withdraw(430.75, 1.50); ///trừ tiền vào acc2 và mức phí
            Account.printtitle();
            acc3.toString(); /// xuất thông tin và tiền lãi của acc3
            Console.WriteLine("-----------------------------------------------------------------");

            ///xuất thông tin acc1, acc2
            Account.printtitle();
            acc1.toString();
            acc2.toString();
            Console.WriteLine("----------------------------------------------------------------");
            /// chuyển tiền acc2 qua cho acc 1 và xuất thông tin
            acc2.withdraw(100.00, 0);
            acc1.deposit(100.00);
            Account.printtitle();
            acc1.toString();
            acc2.toString();
        }
    }
}
