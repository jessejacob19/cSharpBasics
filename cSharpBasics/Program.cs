using System;

namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //tutoral by https://www.youtube.com/watch?v=GhQdlIFylQ8&t=264s
            // core data types
            string str = "this is a string";
            char c = 'c'; //only use single quotes for char double quotes for string
            int n = 4;//integer is whole number
            // float double decimal other examples of numbers least specific to most specific
            double d = 1.3345; // has to have the point
            bool isCorrect = true; // basic boolean

            //strings in c#
            Console.WriteLine("hello\nworld");//\n is the newline character
            string concat = "hi" + " sup";
            Console.WriteLine(concat.Length);//prints the length
            Console.WriteLine(concat.ToUpper());//makes all the letters uppercase
            Console.WriteLine(concat.Contains("hi"));//returns boolean
            Console.WriteLine(concat[0]);//indexing the character
            Console.WriteLine(concat.IndexOf("hi"));//pos where it first starts
            Console.WriteLine(concat.IndexOf("z");// if its not in there
            Console.WriteLine(concat.Substring(4, 2));// pos 4 onwards with a length of two
                                                      //c# string methods

            //numbers

            Console.WriteLine(5 % 2);//how to use modulus

            //when int / int you only get an int
            Console.WriteLine(5/2);//

            //when int / float you get a float
            Console.WriteLine(5/2.0);//
            int num = 6;
            num++;//increments num--
            Console.WriteLine(num);//

            //Math methods

            Console.WriteLine(Math.Abs(-40));//Pow,Sqrt,Max,Min,Round


           
            Console.WriteLine("Hello World!" + "this is how you add strings together");// how to print on the console
            */
            //******* USER input
            /*
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age);//
            */

            //int num = Convert.ToInt32("45");
            /*Console.WriteLine("this is a calculator that adds two numbers together");
            Console.Write("Write first number!!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write second number!!");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num1 + num2);*/

            //madlibs game
            /*
            string color, pluralNoun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();
            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();


            Console.WriteLine("Roses Are " + color);
            Console.WriteLine(pluralNoun + " Are Blue");
            Console.WriteLine("I Love " + celebrity);
            */

            //arrays
            /*
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42 };
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = new string[3];//have to tell how many elements
            friends[0] = "Jim";
            friends[1] = "Kelly";
            friends[2] = "Gilbert";
            */

            //Methods - functions are called methods in c#
            //SayHi("jesse");
            //Console.WriteLine(cube(5));

            //if statements
            //statements();

            //switch statements
            //Console.WriteLine(GetDay(5));

            //While loops
            /*int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            */

            //guessing game
            string secretWord = "giraffe";
            string guess = "";

            while(guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
            }
            Console.Write("You Win!");
            Console.ReadLine();
        }
        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static void statements()
        {
            bool isMale = false;
            bool isFemale = false;
            //use && or ||, !isMale, ==, >, >=
            if (isMale)
            {
                Console.WriteLine("you are a male");
            } else if (isFemale)
            {
                Console.WriteLine("you are a female");
            } else
            {
                Console.WriteLine("You are Neither");
            }
            Console.WriteLine(true == true);
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
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
                    dayName = "Invalid Number";
                    break;
            }
            return dayName;
        }
    }
}
