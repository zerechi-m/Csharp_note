using System;

namespace proparty_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            Access a = new Access();

            //a.Data1 = 12; // Data1 はプロパティでget(読込専用)のみのため、値の代入はできない

            a.Data2 = 3;  

            a.ShowData();
            Console.WriteLine($"data1 = {a.Data1}");
            //Console.WriteLine($"data2 = {a.Data2}");// Data2 はset(書込専用)のみのため、値の読込ができない
        }
    }
}
