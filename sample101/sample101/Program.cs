using System;

namespace sample101
{
    class Program
    {
        static void Main(string[] args)
        {
            // 数値の表示
            Console.Write(123);   // Write は改行しない
            Console.WriteLine(456);   // WriteLine は改行して表示

            // 文字列の表示
            Console.Write("EFG");
            Console.WriteLine("ABC");

            /* namespace :
               プログラムを分類する入れ物の名前を決める
               同一のnamespaceを持つプログラムは互いに関係性が深い
                ※基本的に namespace 名が違うと別のプログラムの可能性が高い
             */

            /* using :
                usingステートメントは利用する名前空間( namespace ) を指定する
                他所のプログラムを部品として使用する際に、using 〜（使用するnamespace）
                と指定することで利用可能になる。

             */

            /* class :
                 クラスとはプログラムのまとまった処理の単位のこと
                 同一名前空間内には同じクラスが存在してはならない。
                 名前空間が異なれば同じクラス名が存在しても構わない

            */

            /* エントリーポイント :
                 static void Main(string[] args) はエントリーポイントと呼ばれる
                 C#言語は原則的にこの中に処理を記述することでプログラムが実行される
             
             */

            Console.Write(1);
            Console.Write(2);
            Console.Write(3);
            Console.WriteLine(4);

        }
    }
}
