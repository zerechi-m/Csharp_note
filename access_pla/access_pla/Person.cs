using System;
namespace access_pla
{
    public class Person
    {
        //名前 (フィールド)
        private string name = "";
        //年齢 (フィールド)
        private int age = 0;

        //プロフィール情報の設定
        public void SetNameAndAge(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //情報の表示
        public void ShowNameandAge()
        {
            Console.WriteLine($"名前：{name}, 年齢：{age}");
        }

        //情報の設定 (プロパティ)
        public string Name
        {
            set { name = value; } // フィールドの　name に対して値の設定 *value は外から与えられた値
            get { return name; }　// 値の取得
        }

        public int Age
        {
            set { age = value; }　// フィールドの　age に対して値の設定
            get { return age; }   // 値の取得
        }
    }
}
