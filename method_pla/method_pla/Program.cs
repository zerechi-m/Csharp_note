using System;

namespace method_pla
{
    class Program
    {

        static void Main(string[] args)
        {
            //乱数の宣言
            Random rand = new Random();

            //問1　整数の 2 乗を計算するメソッドを作成しなさい。
            //    １つの int 型引数を取り、結果を int 型の戻り値として返すこと

            int num = rand.Next(1, 10);
            
            Console.WriteLine($"問1：{num}の二乗は{Square(num)}");


            //問2 ２つの整数の平均を計算するメソッドを作成しなさい。
            //    2つの int 型引数を取り、結果を int 型の戻り値として返すこと。

            int a = rand.Next(1, 21);
            int b = rand.Next(30, 51);

            Console.WriteLine($"問2：{a}と{b}の平均値は{Average(a, b)}");
        }

        //問1のメソッド　startーーーーーーーーーーーーーーー
        static int Square(int n)
        {
            int a = n * n;
            return a;
        }
        //問1メソッド end ーーーーーーーーーーーーーーー

        //問2メソッド start ーーーーーーーーーーーーーー
        static double Average(double n1, int n2)// return値にdouble型の場合は、static 型　メソッド名を double型
                                                // return値を浮動小数点で返すときは引数をdouble型で示す。
        {
            double ave = (n1 + n2) / 2;
            return ave;                 // return値をint型で返す際には (int)ave　と明示的なキャストが必要               
        }
        //問2メソッド end -------------------
    }
}
