using System;

namespace class_pla1
{ 
    class Program
    {
        // 練習問題  class  start------------------------------------------
        class PiCalc 
        {
            int r; //メンバ変数の宣言

            public PiCalc(int r) //コンストラクタ：インスタンスの生成時に処理を行う
            {
                this.r = r;　// メンバ変数の初期化。
            }

            public void Cicle()
            {
                double pi = r * 2 * 3.14;
                double p_area = r * r * 3.14;
                Console.WriteLine($"半径：{r}, 円周:{Math.Round(pi, 2, MidpointRounding.AwayFromZero)}, 面積:{Math.Round(p_area, 3, MidpointRounding.AwayFromZero)}");
            }

        }
        // 練習問題  class end------------------------------------------

        //問1-4 Dog Class s　ーーーーーーーーーーーーーーーーーーー
        class Dog
        {
            string name;
            int age;     //問2 年齢を追加
            string breed; //問3　犬種の追加

            public Dog(string name, string breed, int age)
            {
                this.name = name;
                this.age = age;
                this.breed = breed;
            }

            public void ShowProfile()
            {
                Console.WriteLine($"この犬は{name}:犬種{breed}:年齢は{age}歳です");
            }
        }
        //問1-4 Dog Class e　ーーーーーーーーーーーーーーーーーーー

        //問5-7 CoinCaseクラスの作成 s ーーーーーーーーーーーーーーーーーーーーーーーーー
        class CoinCase
        {
            int Y500, Y100, Y50, Y10, Y5, Y1; //コインのメンバ変数を宣言
            int count; //コインの枚数
            int sheet; //コインの

            public void AddCoins(int kind, int count)
            {
                switch (kind)
                {
                    case 500:
                        Y500 += count;
                        break;
                    case 100:
                        Y100 += count;
                        break;
                    case 50:
                        Y50 += count;
                        break;
                    case 10:
                        Y10 += count;
                        break;
                    case 5:
                        Y5 += count;
                        break;
                    case 1:
                        Y1 += count;
                        break;
                }
            }

            public int GetCount(int kind)
            {
                switch (kind)
                {
                    case 500:
                        return Y500;
                    case 100:
                        return Y100;
                    case 50:
                        return Y50;
                    case 10:
                        return Y10;
                    case 5:
                        return Y5;
                    case 1:
                        return Y1;
                    default:
                        return 0;
                        break;
                }
            }

            public int GetAmount()
            {
                return (Y500 * 500) + (Y100 * 100) + (Y50 * 50) + (Y10 * 10) + (Y5 * 5) + (Y1 * 1);
            }

            

            public int GetAllCount()
            {
                return (Y500 + Y100 + Y50 + Y10 + Y5 + Y1);
            }
        }


        //問5-7 CoinCaseクラスの作成 e ーーーーーーーーーーーーーーーーーーーーーーーーー




        static void Main(string[] args)
        {
            //練習問題 インスタンス start ------------------------------
            PiCalc n = new PiCalc(5); // インスタンスの生成 【クラス名 インスタンス変数名】
            n.Cicle();　//クラスのメソッドを使用

            //練習問題 インスタンス end ------------------------------

            //問1-4　以下の Dog クラスを使用して、次のプログラムを作成しなさい
            Dog d1 = new Dog("ぽち","チワワ", 5 );
            Dog d2 = new Dog("ポッキー","ピンシャー", 15);
            d1.ShowProfile();
            d2.ShowProfile();


            //問5-7 CoinCase クラスを使用して次のプログラムを作成しなさい。
            int[] coin = new int[] { 1, 5, 10, 50, 100, 500 };

            CoinCase MyCase = new CoinCase();

            Random rand = new Random();

            for(int i = 1; i <= 10; i++) // 10回の財布にお金を入れる
            {
                Console.WriteLine("コインの種類");
                int kind = coin[rand.Next(0, 6)];  //硬貨の種類をcoin配列から選択

                Console.WriteLine("コインの枚数");
                int count = rand.Next(1, 11);

                MyCase.AddCoins(kind, count);
            }

            Console.WriteLine($"財布内の硬貨の総数は{MyCase.GetAllCount()}");

            Console.WriteLine("500円は" + MyCase.GetCount(500) + "枚");
            Console.WriteLine("100円は" + MyCase.GetCount(100) + "枚");
            Console.WriteLine("50円は" + MyCase.GetCount(50) + "枚");
            Console.WriteLine("10円は" + MyCase.GetCount(10) + "枚");
            Console.WriteLine("5円は" + MyCase.GetCount(5) + "枚");
            Console.WriteLine("1円は" + MyCase.GetCount(1) + "枚");
            Console.WriteLine($"財布内の総額{MyCase.GetAmount()}円");

        }
    }
}
