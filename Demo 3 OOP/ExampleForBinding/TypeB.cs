using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.ExampleForBinding
{
    internal class TypeB: TypeA
    {
        public int B { get; set; }

        public TypeB(int _A, int _B) : base(_A)
        {
            B = _B;
        }

        public new void myFunc1()
        {
            Console.WriteLine("i B child");
        }

        public override void myFunc2()
        {
            Console.WriteLine($"Type B :  A is: {A} , B is: {B}");
        }
    }
}
