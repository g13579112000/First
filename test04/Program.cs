using System;

namespace test04
{
    class Program
    {
        static void Main(string[] args) //第1-42頁範例
        {
            string val1 = "Everyone say:\"Hello world\"";
            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.Write("\t" + val1);
            Console.WriteLine("\t" + "Wonderful\n");
            Console.Write("\nWelcome To vs 2017\n\n");
            Console.WriteLine("C:\\CS\\HWL.CS");
            Console.WriteLine(@"C:\CS\HWL.CS"); //加入"@"使得逃脫字元失效,只能對倒斜線有用
            Console.WriteLine(@"C:\\CS\\HWL.CS\n");
            Console.WriteLine("\"C# 2017 is Cool!\"");
        }
    }
}
