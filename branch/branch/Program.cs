using System;


namespace branch
{
    class Program
    {
        static void Main(string[] args)
        {
            // 問1 xとyの条件分岐
            int x = 3, y = 4;
            if (x < y)
            {
                Console.WriteLine($"{y}は{x}より大きい");
            }

            // 問2 大きい数を出力
            if (x < y)
            {
                Console.WriteLine("y");
            }
            else
            {
                Console.WriteLine("x");
            }

            // 問3 xを基準としてyの数の大小を出力
            if (x < y)
            {
                Console.WriteLine("xはyより小さい");
            }
            else if (x > y)
            {
                Console.WriteLine("xはyより大きい");
            }

            // 問4 xがyと等しい際の出力
            x = y;

            if (x < y)
            {
                Console.WriteLine("xはyより小さい");
            }
            else if (x == y)
            {
                Console.WriteLine("xはyと等しい");
            }
            else
            {
                Console.WriteLine("xはyより大きい");
            }

            //問5 奇数か偶数かの処理
            Random r1 = new System.Random();
            
            if (r1.Next(1, 10) % 2 == 0)
            {
                Console.WriteLine("r1は偶数です");
            }
            else
            {
                Console.WriteLine("r1は奇数です");
            }

            // 問6 テストの成績に対しての基準点で処理

            Random p = new System.Random();
            int point = p.Next(0, 100);

            if (point >= 80)
            {
                Console.WriteLine("大変良く出来ました");
            }
            else if (point >= 60)
            {
                Console.WriteLine("良く出来ました");
            }
            else
            {
                Console.WriteLine("この点数を糧にして精進せよ");
            }

            // 問6 二教科のテスト結果に対しての基準点で処理
            // 上記のランダム関数を応用

            int p1 = p.Next(50, 100), p2 = p.Next(0, 100);

            if (p1 >= 60 && 60 <= p2)
            {
                Console.WriteLine("合格しました");
            }
            else if (p1 + p2 >= 130)
            {
                Console.WriteLine("合格だ");
            }
            else if ( p1 + p2 >= 100 && (p1 >= 90 || 90 <= p2))
            {
                Console.WriteLine("合格だ！得意な部分を伸ばしなさい");
            }
            else
            {
                Console.WriteLine("不合格");
            }

            // 問7　日付から診療時間と休診日を出力
            DateTime dt = new DateTime(p.Next(1990, 2021), p.Next(1, 12), p.Next(1, 29));
            Console.WriteLine(dt);

            
        }   

    }
}
