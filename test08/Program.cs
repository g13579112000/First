using System;

namespace test08
{
    class Program
    {
        struct Product  //第1-52頁的範例
        {
            public string No, Name;
            public int Price;
        }

        static void Main(string[] args)
        {
            Product xbox;
            xbox.No = "TVGame001";
            xbox.Name = "Xbox one";
            xbox.Price = 17200;
            Product PS4;
            Console.WriteLine("請輸入產品編號:");
            PS4.No = Console.ReadLine();
            Console.WriteLine("請輸入產品名稱:");
            PS4.Name = Console.ReadLine();
            Console.WriteLine("請輸入產品單價:");
            PS4.Price = int.Parse(Console.ReadLine());
            Console.WriteLine("產品單價清單:\n");
            Console.WriteLine("產品編號:{0}", xbox.No);
            Console.WriteLine("產品名字:{0}", xbox.Name);
            Console.WriteLine("產品單價:{0}", xbox.Price);
            Console.WriteLine("產品編號:{0}", PS4.No);
            Console.WriteLine("產品名字:{0}", PS4.Name);
            Console.WriteLine("產品單價:{0}", PS4.Price);

        }
    }
}
