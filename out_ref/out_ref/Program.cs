using System;

namespace out_ref
{
    class Program
    {
        static void Main(string[] args)
        {
            // out修飾子について
            Calc(2, 3, out int ans); // outパラメータに変数を渡すと同時に変数宣言
                                     // バージョンに引数内の宣言方法が変わる
            Console.WriteLine(ans);

            // ------------------------------


            // ref 修飾子について
            int num = 0;   // ref修飾子は必ずメソッド呼出元で値の割り当てが必要

            Add(ref num);
            Console.WriteLine($"1回目のAdd: {num}");
            Add(ref num);
            Console.WriteLine($"2回目のAdd: {num}");

        }

        // out修飾子でメソッドの引数を参照渡し
        static void Calc(int a, int b, out int ans)
        {
            ans = a + b;　// out修飾子の引数は必ず呼出元のメソッド内で値の割り当てが必要になる。
                         // コメントアウトするとエラーになる
        }


        // ref修飾子でメソッドの引数を参照渡し
        static void Add(ref int num)
        {
            //num = num + 5;  //outと違いコメントアウトでもエラーにならない。

        }

    }
}
