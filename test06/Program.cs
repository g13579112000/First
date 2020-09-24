using System;

namespace test06
{
    class Program
    {
        static void Main(string[] args) //第1-47頁莫名其妙的範例
        {
            int n = 10;
            n = n << 4;  //是"二進位"移動 10的二進位=1010 左移一格=10100 十進位下就是20
            Console.WriteLine(n);

            n = 10;
            n <<= 4;  //懶人寫法
            Console.WriteLine(n + "\n");

            char c1 = '9', c2 = '2', c3 = '1';
            Console.WriteLine("原編碼訊息=" + c1 + c2 + c3);
            int key = 11;
            c1 = (char)(c1 ^ key);
            c2 = (char)(c2 ^ key);
            c3 = (char)(c3 ^ key);
            Console.WriteLine("編碼後訊息=" + c1 + c2 + c3); //c ^ key進行位原運算
            c1 = (char)(c1 ^ key);
            c2 = (char)(c2 ^ key);
            c3 = (char)(c3 ^ key);
            Console.WriteLine("解碼後訊息=" + c1 + c2 + c3);
            char a = '2', b = '9', c = ':';
            c1 = (char)(a ^ key);
            c2 = (char)(b ^ key);
            c3 = (char)(c ^ key);
            Console.WriteLine("直接輸入邊碼後訊息解碼=" + c1 + c2 + c3); //也可以直接輸入編碼後數字還原


        }
    }
}
