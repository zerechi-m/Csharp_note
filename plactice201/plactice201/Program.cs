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
                              // double型をint型に変換する際には、小数点以下は切り捨てる
            e = 1.25;
            f = 10;
            g = 10.0;
            
            Console.WriteLine($"{d} {e} {f} {g}");

          // 文字列の結合について
            string  str1, str2;

            Console.Write("str1の値を入力");
            //str1 = Console.ReadLine();　//str1の入力
            str1 = "文字列";
           
            Console.WriteLine("str2の値を入力してください");
            //str2 = Console.ReadLine();
            str2 = "最高";
            Console.WriteLine($"{str1} + {str2} = {str1 + str2}");　//文字列の結合

        　// 定数について

            const int num = 100;      // const 型　変数名 で定数を定める
            const string str = "哲学";
            Console.WriteLine($"{str} + {num} = {str + num}");
            /* string型 + int型 = int型を文字列型として結合することができる。（ruby や pythonとはちがう)
               キャストを用いて数値型をstring型に変換する必要があると思ったが必要はない */


            /* 主な型について

               string型 = 文字列
               int型 = 整数
            　　double型 = 小数点
               char型 = 単一文字
            　　bool型 = true か false
             */


            // 例題1
            int x = 2, y = 3, z;
            Console.WriteLine($"{x + y}");
            z = x - y;
            Console.WriteLine("{0}", z);

            // 例題2
            string s1 = "あいう", s2 = "えお", s3;
            s3 = s1 + s2;
            Console.WriteLine($"{s3}");

            // 例題3

            int nn1 = 2, nn3;
            double nn2 = 3.5 + 10;
            nn3 = (int)nn2;
            Console.WriteLine("{0} + {1} = {2} : int型に変更したnn3:{3}", nn1, nn2, nn1 + nn2, nn3);


        }
    }
}
