using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    static class UsefulTools //makes it so that you can't make an instance of the class
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}
