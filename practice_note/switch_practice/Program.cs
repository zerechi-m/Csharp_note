using System;

namespace switch_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("誕生日を入力してください");
            var birth = int.Parse(Console.ReadLine());

            switch (birth)
            {
                case 1:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 2:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 3:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 4:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 5:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 6:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 7:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 8:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 9:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 10:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 11:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                case 12:
                    Console.WriteLine("{0}月は最高の日になるでしょう", birth);
                    break;

                default:
                    Console.WriteLine("誕生日を入力してよーー！");
                    break;

            }

            Console.ReadLine();

        }
    }
}
