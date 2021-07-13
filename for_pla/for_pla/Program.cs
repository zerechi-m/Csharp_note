using System;

namespace for_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            // 問4 7の階乗
            int num = 1;
            for(int i = 2; i <= 7; i++)
            {
                num *= i;
                Console.WriteLine(num);
            }

            // 問5 整数を10回入力して平均値を求める
            Random n = new Random();
            int num1;
            int sum1 = 0;
            for (int i1 = 1; i1 <= 10; i1++)
            {
                num1 = n.Next(1, 100);
                sum1 += num1;
            }
            Console.WriteLine(sum1 / 10);

            // 問6 0 か 1 を 10 回入力する。これを対戦成績と考え、0 を負け、1 を勝ちとして、勝ちの総数、負けの総数を表示
            int win = 0, lose = 0;
            int n2;
            for(int i2 = 1; i2 <= 10; i2++)
            {
                n2 = n.Next(0, 2);
                if (n2 == 1)
                {
                    //勝ちの条件分岐
                    win += 1;
                }
                else
                {
                    lose += 1;
                }
            }
            Console.WriteLine($"勝ち{win}: + 負け{lose}");

            //問7 巨人、阪神戦で毎回の得点を入力する。（１回～９回）得点を入力し勝敗を表示
            int kyojin = 0;
            int hansin = 0;
            int point;
            for (int i3 = 1; i3 <= 9; i3++)
            {
                point = n.Next(0, 5);
                kyojin += point;
                Console.WriteLine($"{i3}回表 巨人の攻撃は{point}点");


                point = n.Next(0, 5);
                Console.WriteLine($"{i3}回表 阪神の攻撃は{point}点");
                hansin += point;

                if(i3 == 5)
                {
                    Console.WriteLine($"{i3}回が終了時点で");
                    Console.WriteLine($"巨人{ kyojin} - 阪神{hansin}");
                }
            }

            if (kyojin > hansin)
            {
                Console.WriteLine($"巨人:{kyojin}, 阪神{hansin} 巨人の勝ち");

            }
            else if (kyojin < hansin)
            {
                Console.WriteLine($"阪神{hansin}, 巨人:{kyojin} 阪神の勝ち");
            }
            else
            {
                Console.WriteLine($"巨人{kyojin} - 阪神{hansin} で同点");
            }

            // 問8 自然数（正の整数）を 10 回入力し、最大値を求めるプログラムを作成しなさい。
            int num2 = 0;
            int sum2 = 0;
            for (int i4 = 1; i4 <= 10; i4++)
            {
                num2 = n.Next(0, 100);
                if (sum2 < num2)
                {
                    sum2 = num2;
                }
            }
            Console.WriteLine("10回入力した整数の最大値は{0}", sum2);

            //問9 自然数（正の整数）を 10 回入力し、最大値と最小値を求めるプログラムを作成しなさい。
            int max = 0, min = 0;
            sum2 = 0;
            for(int i5 = 1; i5 <= 10; i5++)
            {

                sum2 = n.Next(0, 100);
                Console.WriteLine($"{i5}:{sum2}");
                if (i5 == 1)
                {
                    min = sum2;
                    max = sum2;
                }
                else
                {
                    //最大値の比較
                    if (max < sum2)
                    {
                        max = sum2;
                    }

                    //最小値の比較
                    if (min > sum2)
                    {
                        min = sum2;
                    }
                }
               
            }
            Console.WriteLine($"最大値{max}:最小値{min}");

            //問10 個数を示す数値を入力し、その個数分だけ‘*’を表示するプログラム
            int num3 = n.Next(1, 10);
            string z = "";
            for(int i6 = 1; i6 <= num3; i6++)
            {
                z += "*";
            }
            Console.WriteLine($"{num3}個の*");
            Console.WriteLine(z);
        }
    }
}
