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

            //Console.Write("Enter Number One: ");
            //double numOne = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter operator: ");
            //string op = Console.ReadLine();

            //Console.Write("Enter Number Two: ");

            //double numTwo = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(numOne + numTwo);
            //} else if (op == "-")
            //{
            //    Console.WriteLine(numOne - numTwo);
            //} else if (op == "/")
            //{
            //    Console.WriteLine(numOne / numTwo);
            //} else if (op == "*")
            //{
            //    Console.WriteLine(numOne * numTwo);
            //} else
            //{
            //    Console.WriteLine("Invalid Opertor");
            //}
            //Console.WriteLine(GetDay(0));
            //Console.WriteLine(GetDay(4));
            //Console.WriteLine(GetDay(80));

            //int index = 1;
            //while(index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            ////excutes once before checking condition
            //do
            //{
            //    Console.WriteLine(index);
            //    index++;
            //} while (index <= 5) ;

            //string secretWord = "switch";
            //string guess = "";
            //int numOfGuess = 1;
            //int guessLimit = 4;
            //bool canGuess = true;

            //do
            //{
            //    if (numOfGuess < guessLimit)
            //    {
            //        Console.Write("Guess # " + numOfGuess + ": ");
            //        guess = Console.ReadLine();
            //        numOfGuess++;
            //    }
            //    else
            //    {
            //        canGuess = false;
            //    }
            //} while (guess != secretWord && canGuess);

            //if (!canGuess)
            //{
            //    Console.WriteLine("You Lose!");
            //} else
            //{
            //    Console.WriteLine("Guess was Correct!");
            //}

            //int[] luckyNums = {4,6,15,79,1};
            //for (int i = 0; i<luckyNums.Length; i++)
            //{
            //    Console.WriteLine(luckyNums[i]);
            //}

            //Console.WriteLine(Power(2, 3));


            // 2D Arrays
            int[,] numberGrid =
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };
            //Console.WriteLine(numberGrid[0, 0]);
            //Console.WriteLine(numberGrid[2, 2]);
            //Console.WriteLine(numberGrid[1, 1]);

            try
            {
                Console.Write("Enter a number: ");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int numTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numOne / numTwo);
            } catch(DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            } catch (FormatException error)
            {
                Console.WriteLine(error.Message);
            } finally
            {
                Console.WriteLine("Done");
            }
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            switch(dayNum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;

                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Invalid Day Number";
                    break;
            }
            return dayName;
        }

        static int Power(int baseNum, int expoNum)
        {
            int res = 1;

            for (int i = 0; i<expoNum; i++)
            {
                res = res * baseNum;
            }

            return res;
        }
    }
}
