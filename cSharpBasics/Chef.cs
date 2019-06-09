using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    class Chef
    {
        //this is the super class
        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chiken");
        }

        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }

        public virtual void MakeSpecialDish() // virtual means that this method can be overwritten in any subclasses
        {
            Console.WriteLine("The Chef makes bbq ribs");
        }
    }
}
