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

            //問3 ２つの整数の大きい方を選ぶメソッドを作成しなさい。２つの int 型引数を取り、大きい方の数値を戻り値として返すこと。
            //    また、このメソッドを使用して、int 型の変数 x、y、z にそれぞれ数値を入力し、最も大きい数値を表示するプログラムを作成しなさい。

            int n1 = rand.Next(1, 20);
            int n2 = rand.Next(1, 20);
            int n3 = rand.Next(1, 20);
            Console.WriteLine($"{n1}:{n2}:{n3} 最大値は{MaxValue(n1, MaxValue(n2, n3))}"); // 関数の引数にメソッドの返り値を指定

            //問4 サイズを示す数値（ int 型）を引数とし、何等かの文字で例のような三角形を表示するメソッドを作成しなさい。
            //    また、このメソッドを使用してサイズ 3、4、5 の３つの三角形を表示するプログラムを作成しなさい。

            int n4 = rand.Next(3, 6); // 3,4,5のランダム
            string kigou = "@";
            Triangle(n4, kigou);

            //問5　サイズを示す数値と、表示する文字を引数とし、三角形を表示するメソッドを作成しなさい。
            //　　　このメソッドを使用して、サイズと文字の異なる３つの三角形を表示しなさい。
            char[] k = new char[] { '%', '&', '|', '~', '$'};
            Console.WriteLine();
            int x = rand.Next(1, 4);
            Triangle_2(x,  k[rand.Next(0, k.Length)]); // 配列の中からランダムに記号を取得

            int y = rand.Next(4, 7);
            Triangle_2(y, k[rand.Next(0, k.Length)]);

            int z = rand.Next(7, 10);
            Triangle_2(z, k[rand.Next(0, k.Length)]);


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

        //問3メソッド start -------------------
        static int MaxValue(int n1, int n2)
        {
            if (n1 > n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }
        //問3メソッド end -------------------

        //問4メソッド start -------------------
        static void Triangle(int x, string y)  // void　は引数を返さないメソッド
        {
            string s = y;

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"{s}" );
                s += y;　　　　　　　　　　　　　// 文字列の結合を行い、再代入している。
            }
        }

        //問5メソッド start -------------------
        static void Triangle_2(int a, char b)
        {
            
            for (int i = 0; i <= a; i++)
            {
                for (int j = 0; j <= i; j++) //char型のため、文字列の結合は使用できない。
                {
                    Console.Write(b);
                }
                Console.WriteLine();
                
            }
        }
        //問5メソッド end -------------------

    }
}
