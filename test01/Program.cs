using System;

namespace test01
{
    class Program
    {
        static void Main(string[] args) //第1-32頁 範例
        {
            string ProductName;
            int price;
            Console.WriteLine("輸入品名");
            ProductName = Console.ReadLine();
            Console.WriteLine("輸入金額");
            price = int.Parse(Console.ReadLine());
            Console.WriteLine("品名:{0} 單價:{1}", ProductName, price);

        }
    }
}
