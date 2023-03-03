namespace Cs_skillfactory_module3_task
{
    using System;

    class MainClass
    {
        public static void Main(string[] args)
        {

            var name = "Jane";

            var age = checked((byte)int.Parse(Console.ReadLine()));
            Console.WriteLine("Your name is {0} and age is {1} ", name, age);

            Console.Write("What is your favorite day of week? ");

            var day = (DayOfWeek)int.Parse(Console.ReadLine());
            Console.WriteLine("Your favorite day is {0}", day);

        }
    }
}