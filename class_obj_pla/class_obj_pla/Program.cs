using System;

namespace class_obj_pla
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1, p2;　　　　　// p1・p2のインスタンス変数の宣言
            p1 = new Person();    // Personクラスのインスタンスの生成
            p2 = new Person();
            p1.name = "山田 太郎"; // フィールドname に値の代入
            p1.age = 19;          // フィールドage に値の代入

            p2.SetAgeAndName("山田 花子", 21);
            p1.ShowNameAndAge();
            p2.ShowNameAndAge();


            // --------------------------------------------------
            // Calcクラスにて計算プログラム作成

            Calc calc = new Calc();
            int a = 1, b = 2, c = 3;

            int ans1 = calc.Add(a, b);    // Add(2つの整数の和) ・・・引数2つ　// ブレークポイントのステップインでCalcクラスのメソッドに入る
            int ans2 = calc.Add(a, b, c); // Add(3つの整数の和) ・・・引数3つ

            Console.WriteLine($"{a} + {b} = {ans1}");
            Console.WriteLine($"{a} + {b} + {c} = {ans2}");


        }
    }
}
