using System;

namespace while_pla
{
    class Program
    {
        static void Main(string[] args)
        {

            //while文の基本文法
            int i = 0;

            while ( i <= 5)　// for文と違い、条件式内で変数宣言は行わないためwhile文の前で変数宣言が必要
            {
                Console.Write($"{i,2}");
                i++;
            }
            Console.WriteLine();

            // do - while文について

            int i2 = 8;

            do   //まず先にdo内の処理を行ってから、while文の判定に入る。
            {
                Console.Write("{0, 2}", i2);
                i2++;
            } while (i2 < 6);

            Console.WriteLine();

            // サイコロの目が6が出るまで処理を続ける
            Random rand = new Random();
            Console.WriteLine("サイコロの目「6」が出たら終了");

            int i3 = 0;

            while (true) //無限ループの処理
            {
                int dice = rand.Next(1, 7);
                i++;
                if (dice == 6)
                {
                    Console.WriteLine($"{i}回目");
                    break;　　　　　　　　　　　　　　// break でwhileの無限ループから抜ける
                }

            }
            Console.WriteLine("終了");
        }
    }
}
