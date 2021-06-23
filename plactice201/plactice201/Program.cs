using System;

namespace plactice201
{
    class Program
    {
        static void Main(string[] args)
        {
          // 演算子
            Console.WriteLine("{0} + {1} = {2}", 5, 3, 5 + 3 );
            Console.WriteLine("{0} / {1} = {2}", 4, 2, 4 / 2);
            Console.WriteLine("{0} / {1} = {2} 余り{3}", 5, 2, 5 / 2, 5 % 2);

            // 変数
            int a = 3;  // int型で整数を代入

            int b = 4, c = 5; // int型の変数を複数宣言 ※複数の代入はできない


            Console.WriteLine($"{a}{b}{c}" );
            

        }
    }
}
