using System;

namespace plactice201
{
    class Program
    {
        static void Main(string[] args)
        {
          // 演算子 ---------------------------
            Console.WriteLine("{0} + {1} = {2}", 5, 3, 5 + 3 );
            Console.WriteLine("{0} / {1} = {2}", 4, 2, 4 / 2);
            Console.WriteLine("{0} / {1} = {2} 余り{3}", 5, 2, 5 / 2, 5 % 2);

          // 変数 ----------------------------
            int a = 3;  // int型で整数を代入

            int b = 4, c = 5; // int型の変数を複数宣言して代入　※変数は一つずつ代入が必要である


            Console.WriteLine($"{a}{b}{c}" );

            // int a = 5;  使用している変数を再度、宣言して値を代入することは不可


          // キャスト(cast) 型変換について ------
            int d;  // 整数型
            double e, f, g;　// 浮動小数点型

            d = (int)1.25;    // int型に小数点は使用できないので、(int)で型変更を明示的に行う可読性向上（キャスト）
            e = 1.25;

            d = (int)e;
            f = 10;
            g = 10.0;
            
            Console.WriteLine($"{d} {e} {f} {g}");

        }
    }
}
