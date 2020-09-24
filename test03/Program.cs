using System;

namespace test03
{
    class Program
    {
        static void Main(string[] args) //第1-39頁範例
        {
            double val1 = 0801234567;
            Console.WriteLine("1." + val1.ToString("(0##) ###-####\n"));
            int val2 = -12345;
            Console.WriteLine("2." + val2.ToString("######\n") + val2.ToString("000000\n"));
            double val3 = -2.455;
            Console.WriteLine("3." + val3.ToString("#.##\n") + val3.ToString("0.00\n") + val3.ToString("00.000\n"));
            double val4 = 1234567890;
            Console.WriteLine("4." + val4.ToString("#,#\n") + val4.ToString("#,\n") + val4.ToString("#,,\n") 
                + val4.ToString("#,,,\n") + val4.ToString("#,##0,,\n"));
            double val5 = 0.08645;
            Console.WriteLine("5." + val5.ToString("#0.##%\n")); //特別注意是用小數點不是逗號
            double val6 = 16800;
            Console.WriteLine("6." + val6.ToString("0.###E+0\n") + val6.ToString("0.##E+000\n")
                + val6.ToString("0.###E0\n") + val6.ToString("0.##E-0\n")); //E的後面絕對要有一個0表示10的次方 E後的"-"會被吃掉
            double val7 = -1234;
            Console.WriteLine("7." + val7.ToString("####\n") + val7.ToString("##;##\n") 
                + val7.ToString(";#####'只是測試'\n")); //加入";"可以直接輸出絕對值 雙引號內必須使用單引號
        }
    }
}
