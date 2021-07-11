using System;
using System.Collections;

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

            var week = new Hashtable(); //ハッシュテーブルの作成
            week["0"] = "日曜日";
            week.Add("1", "月曜日");
            week.Add("2", "火曜日");
            week.Add("3", "水曜日");
            week.Add("4", "木曜日");
            week.Add("5", "金曜日");
            week.Add("6", "土曜日");

            var times = new Hashtable();
            times["0"] = "午前中";
            times["1"] = "午後";
            times["2"] = "夜間";

            int w = p.Next(0, 6);
            int t = p.Next(0, 2);

            Console.Write($"曜日{w}:時間帯{t}:");
            if (w == 0 )
            {
                Console.WriteLine("休診です");
            }
            else if (w == 6 && t == 0)
            {
                Console.WriteLine("休診です");
            }
            else if ( (w == 2 || w == 5) && t == 0)
            {
                Console.WriteLine("休診です");
            }
            else if (w == 3 && t == 2)
            {
                Console.WriteLine("休診です");
            }
            else
            {
                Console.WriteLine("バリバリ診療中");
            }

            // 問8 switch文を使用した寿司占い

            Random s = new Random();

            Console.WriteLine("へいらっしゃい！何を握ります？");
            int sushi = s.Next(1, 5);

            switch (sushi)
            {
                case 1:
                    Console.WriteLine("へいお待ち！！江戸から続くハンバーグ寿司だよ");
                    break;

                case 2:
                    Console.WriteLine("へいお待ち！！代々受け継がれたエビフライ寿司だよ");
                    break;

                case 3:
                    Console.WriteLine("へいお待ち！！将軍様も御用達のサーモンアボガド握りだよ");
                    break;

                default:
                    Console.WriteLine("ガリしかないよ");
                    break;
            }


        }   

    }
}
