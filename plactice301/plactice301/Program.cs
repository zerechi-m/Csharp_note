using System;

namespace plactice301
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("整数値を入力してください: ");
            //int a = int.Parse(Console.ReadLine());  // int.parse　で標準入力を数値型に変換
            int a = 3;
            Console.WriteLine("a= " + a);    // "a=" + 整数型でも結合できる

            // 条件分岐 if文
            if (a > 0)
            {
                // true 真の場合の処理
                Console.WriteLine($"a {a} は正の数です");
            }
            else if (a == -5 || a == -3)
            {
                Console.WriteLine("a は-5もしくは -3です");
            }
            else
            {
                // false　偽の場合の処理
                Console.WriteLine("a は正の数ではありません");
            }


            // if文の論理式 と if文のネスト
            //Console.Write("サイコロの目を入力: 1 ~ 6: ");

            int dice = int.Parse(Console.ReadLine());

            if (1 <= dice && 6 >= dice)
            {
                if (dice == 2 || dice == 4 || dice == 6)
                {
                    Console.WriteLine("サイコロの目は’丁'です");
                }
                else if (dice == 2 || dice == 4 || dice == 6)
                {
                    Console.WriteLine("サイコロの目は’半'です");
                }
            }
            else
            {
                Console.WriteLine("1〜6で入力してください");
            }


            // switch文について
            Console.Write("1から3を入力してください");
            int num = int.Parse(Console.ReadLine());

            switch(num){
                case 1:
                    Console.WriteLine("one");
                    break;

                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;

                // case文は下記のようにまとめることができるß
                case 4:
                case 5:
                    Console.WriteLine("バカたれ1〜3で入力してくださいな");
                    break;
                
                default:
                    Console.WriteLine("1~3を入力してください");
                    break;

            }
            

        }
    }
}
