using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.ExampleForBinding
{
    internal class TypeC : TypeB
    {
        public int C { get; set; }

        public TypeC(int _A, int _B, int _C) : base(_A, _B)
        {
            C = _C;
        }

        public new void myFunc1()
        {
            Console.WriteLine("i C Grand Parent");
        }

        public override void myFunc2()
        {
            Console.WriteLine($"Type C : A is: {A} , B is: {B}, C is: {C}");

        }
    }
}
