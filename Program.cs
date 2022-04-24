using System;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            string name;
            string age;
            int A = 2022;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Привет путник! Я смотрю ты здесь новенький ;)");
            Console.WriteLine("Давай познакомимся по ближе, введи своё Имя...");
            name = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(name + ", Рад знакомству! Меня зовут - Александр.");
            Console.WriteLine("Сколько тебе лет?, " + name);
            age = Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            int convertedAge = Convert.ToInt32(age);
            int B = int.Parse(age);
            if (B < 25)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ты младше меня, " + name + ", мне - 25 :)");
                Console.Write("И твой год рождения это - ");
                Console.WriteLine(A - B);
                Console.WriteLine("Нажми ENTER для продолжения...");
                Console.ReadLine();
                Console.Clear();
            }
            else if (B > 25)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Ты старше меня, " + name + ", мне - 25 :)");
                Console.Write("И твой год рождения это - ");
                Console.WriteLine(A - B);
                Console.WriteLine("Нажми ENTER для продолжения...");
                Console.ReadLine();
                Console.Clear();
            }
            else if (B == 25)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Так тебе так-же как и мне, 25 лет :)");
                Console.Write("И твой год рождения это - ");
                Console.WriteLine(A - B);
                Console.WriteLine("Нажми ENTER для продолжения...");
                Console.ReadLine();
                Console.Clear();
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Вот мы и стали ближе с тобой :)");
            Console.Write("Теперь я знаю что тебя зовут - " + name);
            Console.Write(", тебе - " + age + " лет");
            Console.WriteLine(", и твой г-р. - " + (A-B));
            Console.WriteLine("Нажми ENTER для продолжения...");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(name + ", спорим, я сейчас угадаю какая у тебя дата,время, и час времени? :)");
            Console.WriteLine("Нажми ENTER для продолжения...");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("===>> " + date + " <<===");
            Console.WriteLine("Прикольно, не правда ли? :)");
            Console.WriteLine("Нажми ENTER для продолжения...");
            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            Console.WriteLine("Спасибо за уделенное время, " + name);
            Console.WriteLine("Это была моя первая консольная программа, я надеюсь тебе понравилось! :)");
            Console.ReadLine();
        }
    }
}
