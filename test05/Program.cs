using System;

namespace test05
{
    class Program
    {
        static void Main(string[] args)  //第1-46頁範例 使用cast對資料型別轉換影響
        {
            int i;
            double d = 234.9;
            i = (int)d;
            Console.WriteLine(i + "\n");

            byte b;
            i = 255;
            b = (byte)i;
            Console.WriteLine(b);
            i = 257;
            b = (byte)i;
            Console.WriteLine(b + "\n");

            char ch;
            b = 41;
            ch = (char)b;
            Console.WriteLine("{0,0:X}",ch);
        }
    }
}
