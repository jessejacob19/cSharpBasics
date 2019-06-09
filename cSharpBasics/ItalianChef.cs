using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpBasics
{
    class ItalianChef : Chef
    {
        // this is the subclass
        public void MakePasta()
        {
            Console.WriteLine(" the chef makes pasta");
        }

        public override void MakeSpecialDish() // virtual means that this method can be overwritten in any subclasses
        {
            Console.WriteLine("The Chef makes pizza");
        }
    }
}
