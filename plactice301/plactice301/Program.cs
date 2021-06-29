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
            Console.Write("サイコロの目を入力: 1 ~ 6: ");
            //int dice = int.Parse(Console.ReadLine());
            int dice = 4;

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
            //int num = int.Parse(Console.ReadLine());
            int num = 1;

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

            // 例題1 double型の変数tempを宣言して標準入力で数値を入力し条件式にそった出力

            Console.WriteLine("数字を入力してください");
            double temp = 1.2;

            if (temp == 0.0)
            {
                Console.WriteLine("ゼロォ");
            }
            else if (temp >= 0)
            {
                Console.WriteLine("正の数");
            }
            else if (temp <= 0)
            {
                Console.WriteLine("負の数 ");
            }
            else
            {
                Console.WriteLine("数字を入力してください");

            }

            // 例題2　文字列型 s1, s2を標準入力して, s1がHello s2がworldの際の条件式

            Console.Write("s1の文字入力をしてください");
            string s1 = Console.ReadLine();

            Console.Write("s2の文字入力をしてください");
            string s2 = Console.ReadLine();

            if (s1 == "hello" && s2 == "world")
            {
                Console.WriteLine($"{s1 + s2} please!!");
            }
            else
            {
                Console.WriteLine("s1にhelloをs2にworldを入力してちょ");
            }

            // 例題3　信号機の処理を赤青黄で処理しなさい
            Console.Write("信号の色は");
            string color = Console.ReadLine();

            switch (color)
            {
                case "赤":
                    Console.Write("赤は止まれ！");
                    break;

                case "青":
                    Console.Write("青は進め");
                    break;

                case "黄色":
                    Console.Write("黄色まだまだ赤勝負");
                    break;
                default:
                    Console.Write($"{color}は信号の色にはありません");
                    break;
            }
                

        }
    }
}
