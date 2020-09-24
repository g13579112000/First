using System;

namespace test07
{
    class Program
    {
        public enum WeekDays : int  //第1-49頁範例 , 只能使用數字
        {
        Monday=1,Tuesday=2,Wednesday=3,Thursday=4,Friday=5,Saturday=6,Sunday=7
        };


        static void Main(string[] args)
        {
            Console.WriteLine("星期三的列舉常數:{0}", (int)WeekDays.Wednesday);
            Console.WriteLine("星期天的列舉常數:{0}", (int)WeekDays.Sunday);

        }

    }
}
