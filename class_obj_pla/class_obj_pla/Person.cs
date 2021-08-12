using System;
namespace class_obj_pla
{
    public class Person
    {

        //名前(フィールド)
        public string name = "";

        // 年齢( フィールド )
        public int age = 0;

        // 情報の表示 (メソッド)
        public void ShowNameAndAge()
        {
            Console.WriteLine("名前:{0}  年齢:{1}", name, age);
        }

        // 情報の設定
        public void SetAgeAndName(string name, int age)
        {
            this.name = name;
            this.age = age;

        }


    }
}
