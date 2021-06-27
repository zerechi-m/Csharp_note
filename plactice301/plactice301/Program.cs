using System;

namespace plactice301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力してください: ");
            int a = int.Parse(Console.ReadLine());  // int.parse　で標準入力を数値型に変換
            Console.WriteLine("a= " + a);    // "a=" + 整数型でも結合できる

            // 条件分岐 if文
            if (a > 0)
            {
                // true 真の場合の処理
                Console.WriteLine($"a {a} は正の数です");
            }
            else if (a == -5 || a == -3)
            {
                Console.WriteLine("a は5もしくは3です");
            }
            else
            {
                // false　偽の場合の処理
                Console.WriteLine("a は正の数ではありません");
            }

        }
    }
}
