using System;

namespace class_pla2
{
    class Program
    {
        //問1 Animal クラスを継承したクラス（派生クラス）、Cat を作成しなさい。
        class Animal
        {
            protected string name;  //public で指定することでCatクラス(継承先)でも変数を利用できる
            protected int age;

            public Animal(string nae, int age) //問2 コンストラクタを設定して子クラスで使用
            {
                this.name = nae;
                this.age = age;
            }

            public void ShowProfile()
            {
                Console.WriteLine(name + "," + age + "歳");
            }

            //問4 Animal クラスに以下の仮想メソッドを追加しなさい

            public virtual void Speak()
            {
                Console.WriteLine($"・・・・・・・");
            }
        }

        class Cat : Animal
        {
            public Cat(string name, int age) :base(name, age) //baseとすることで継承元のコンストラクタを使用する
            {

            }

            public void Sleep()
            {
                Console.WriteLine($"{name}はスースーと眠っている");
            }

            public override void Speak()
            {
                Console.WriteLine($"{name}はにゃーと鳴きます");
            }
        }

        class Dog : Animal
        {
            public Dog(string name, int age) : base(name, age)
            {
                //親クラスのコンストラクタで名前と年齢を初期化
            }

            public void Run()
            {
                Console.WriteLine($"{name}はトコトコと走ります");
            }

            public override void Speak()
            {
                Console.WriteLine($"{name}はワンワンと鳴きます");
            }
        }


        static void Main(string[] args)
        {
            //問1  Animal クラスを継承したクラス（派生クラス）、Cat を作成しなさい。
            Cat MyCat = new Cat("たま", 10);
            MyCat.ShowProfile();
            MyCat.Sleep();
            MyCat.Speak();

            //問3 Animalクラスを継承したクラス（派生クラス)、Dogを作成する
            Dog MyDog = new Dog("ぽち", 8);
            MyDog.ShowProfile();
            MyDog.Run();
            MyDog.Speak();

            Animal[] MyPets = new Animal[4];

            MyPets[0] = new Cat("たま", 10);
            MyPets[1] = new Dog("ぽち", 2);
            MyPets[2] = new Cat("どら", 8);
            MyPets[3] = new Dog("おさむ", 3);

            foreach (Animal Pet in MyPets)
            {
                Pet.ShowProfile();
                Pet.Speak();
            }

        }
    }
}
