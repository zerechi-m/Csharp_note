using System;
namespace proparty2
{
    public class Person2
    {
        public void SetNameAndAge(string name, int age)
        {
            Name = name;
            Age = age;

        }

        //情報の表示（メソッド）
        public void ShowNameandAge()
        {
            Console.WriteLine($"名前:{Name}: 年齢:{Age}");
        }

        //情報の設定( プロパティ )
        public string Name
        {
            private set;  get; //setにprivateのアクセス修飾子があるので set のみクラス内からしかアクセスできない
                               // またプロパティには setter もしくは getter 片方のみしか使用できない
        }

        public int Age
        {
            set; get;　　// アクセス修飾子がないので public と同義
        }


        //----- 上記のプロパティは下記の省略形
        //
        //public int age
        //{
        //    set { age = value; }
        //    get { return age;}
        //}
    }
}
