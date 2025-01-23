using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.ExampleForBinding
{
    internal class TypeA
    {
            public int A { get; set; }

            // CONSTRUCTOR

            public TypeA(int _A)
            {
                A = _A;
            }


            public void myFunc1()
            {
                Console.WriteLine("i A parent");
            }

            public virtual void myFunc2()
            {
                Console.WriteLine($"Type A : A is: {A}");
            }

    }
}
