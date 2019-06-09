using System;

namespace cSharpBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            //tutoral by https://www.youtube.com/watch?v=GhQdlIFylQ8&t=264s
            // core data types
            string str = "this is a string";
            char c = 'c'; //only use single quotes for char double quotes for string
            int num = 4;//integer is whole number
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


            //pointers
            Console.WriteLine("Hello World!" + "this is how you add strings together");// how to print on the console
        }
    }
}
