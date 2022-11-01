using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Example 1
            //Console.WriteLine("     /|");
            //Console.WriteLine("    / |");
            //Console.WriteLine("   /  |");
            //Console.WriteLine("  /   |");
            //Console.WriteLine(" /    |");
            //Console.WriteLine("/_____|");

            //// Example 2
            //// creating, using and updating variable
            //string characterName = "Uzair";
            //int characterAge = 22;
            //Console.WriteLine("There once was a man named " + characterName + "!");
            //Console.WriteLine("He was " + characterAge + " years old!");
            //characterName = "John";
            //Console.WriteLine("He really liked his name " + characterName + "!");
            //Console.WriteLine("But definatly wasn't " + characterAge + "!");

            //// Example 3
            //// Types of variables
            //string phrase = "Jack of all trades!";
            //char grade = 'A';
            //int age = 22;
            //// (least accurate) float, double, decimal (super accurate ) - 3 different ways to work with decimals 
            //double mileTime = 14.35;
            //bool isOfAge = true;

            //Console.WriteLine(grade);
            //Console.WriteLine(age);
            //Console.WriteLine(mileTime);
            //Console.WriteLine(isOfAge);

            //// Example 4
            //// working with strings
            //Console.WriteLine("Uzair\nVawda");
            //Console.WriteLine("Uzair\"Vawda");
            //Console.WriteLine(phrase.Length);
            //Console.WriteLine(phrase.ToUpper());
            //Console.WriteLine(phrase.ToCharArray()); 
            //Console.WriteLine(phrase.Contains("Jake"));
            //Console.WriteLine(phrase[0]);
            //Console.WriteLine(phrase.IndexOf("all")); 
            //Console.WriteLine(phrase.IndexOf("a")); 
            //Console.WriteLine(phrase.IndexOf("y")); 
            //Console.WriteLine(phrase.Substring(8)); 
            //Console.WriteLine(phrase.Substring(8, 3));

            //// Example 5
            //// working with numbers
            //Console.WriteLine(5 + 8); // 13
            //Console.WriteLine(8 / 8); // 1
            //Console.WriteLine(5 * 8); // 40
            //Console.WriteLine(5 - 8); // -3
            //Console.WriteLine(8 % 5); // finds remainder (3)

            //Console.WriteLine(5.0 - 8); // -3.0
            //Console.WriteLine(5 / 2); // -3
            //Console.WriteLine(5.0 / 2); // -3

            //Console.WriteLine(Math.Abs(-4000));
            //Console.WriteLine(Math.Pow(3,3));
            //Console.WriteLine(Math.Sqrt(81));
            //Console.WriteLine(Math.Max(4, 9));
            //Console.WriteLine(Math.Min(4, 9));
            //Console.WriteLine(Math.Round(4.457619));

            //// Example 6
            //// getting input from use
            //Console.Write("Enter your name: "); // write vs write line (write does NOT creat a new line)
            //string userName = Console.ReadLine();
            //Console.Write("Enter your Age: "); // write vs write line (write does NOT creat a new line)
            //string userAge = Console.ReadLine();
            //Console.WriteLine("Hey, " + userName + "!");
            //Console.WriteLine("You are "  + userAge + "!");

            //// Example 7: Calculator
            //int num = Convert.ToInt32("45");
            //Console.Write("Enter Number: ");
            //int numberOne = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter Anothr Nnumber: ");
            //int numberTwo = Convert.ToInt32(Console.ReadLine());

            //int total = numberOne + numberTwo;
            //Console.WriteLine("Total: " +  total);

            //// Example 8
            //string color, pluralNoun, celebrity;
            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();
            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();
            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();
            //Console.WriteLine("Roses are " + color);
            //Console.WriteLine(pluralNoun  + " are " + color);
            //Console.WriteLine("I love " + celebrity);

            //// Example 9 -> Arrays
            //int[] luckyNum = { 4, 8, 15, 4 };
            //Console.WriteLine(luckyNum[1]);

            //string[] friends = new string[5];
            //friends[0] = "Uzair";
            //friends[1] = "Nike";

            SayHello("Uzair", 32); // function call
        }

        static void SayHello(string name, int age) //void because it doesnt return anything
        {
            Console.WriteLine("Hello User");
            Console.WriteLine("Hello " + name + "!");
            Console.WriteLine("You are " + age);
        }
    }
}
