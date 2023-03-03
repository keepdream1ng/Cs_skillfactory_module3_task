namespace Cs_skillfactory_module3_task
{
    using System;

    class MainClass
    {
        //I decided to write my own enum, and error messages helped me figure out those shouldnt be a strings.
        public enum MyDaysOfWeek
        {
            Mournday = 1,
            Tearsday,
            Wasteday,
            Thirstday,
            Fightday,
            Shatterday,
            Sinday
        }

        public static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write($"And your age, dear {name}? ");
            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week number? ");

            var day = (MyDaysOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("So, your favorite day is {0} ;)", day);

            Console.ReadKey();

        }
    }
}