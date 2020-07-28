using System;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // value type variables

            int myFirstInteger;
            myFirstInteger = 12;

            decimal money = 12.50m;
            double moreDecimalStuff = 12.50; // these are kinda the default
            float floatingPoint = 12.50f;

            bool myFirstBoolean = true;

            var myFirstString = "This is a string...";

            char oneCharacter = 'c';

            DateTime today = DateTime.Today;

            var poem = @"Roses are red,
                       violets are blue,
                       csharp is great,
                       and so are you.";

            var name = "John";
            var age = 29;
            var greeting = $"My name is {name} and I'm {age} years old.";
            

            // reference type variables

            // this is bad code 
            object myNumber = 1;
            myNumber = "stuff";

            // Creating an anonymous type
            var steve = new { name = "Steve" };

            greeting = $"My name is {steve.name} and I'm {age} years old.";

            var names = new string[3] { "John", "Anca", "Todd" }; // with arrays you have to specify the number of items in it and it can't be updated

            Console.WriteLine(greeting);

            var shouldExecute = true;

            if (!string.IsNullOrEmpty(name))
            {
                Console.WriteLine($"{name} was in the name variable.");
            }
            
            switch (oneCharacter)
            {
                case 'a' :
                    Console.WriteLine("its the letter a");
                    break;
                case 'c' :
                    Console.WriteLine("its the letter c");
                    break;
                default :
                    Console.WriteLine("It wasn't a or c");
                    break;
            }

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"The current name is {names[i]}");
            }

            foreach (var n in names)
            {
                Console.WriteLine($"The current name is {n}");
            }

            Console.WriteLine("Please enter your name.");
            var input = Console.ReadLine();

            Console.WriteLine($"Hello, {input}");

            Console.WriteLine("Please enter a comma separated list of numbers.");
            input = Console.ReadLine();

            var numbers = input.Split(',');

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

        }
    }
}
