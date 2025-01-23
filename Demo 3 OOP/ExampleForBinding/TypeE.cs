using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.ExampleForBinding
{
    internal class TypeE:TypeD
    {
        public int E { get; set; }

        public TypeE(int _A, int _B, int _C, int _D , int _E) : base(_A, _B, _C , _D)
        {
            E = _E;
        }

        public new void myFunc1()
        {
            Console.WriteLine("i E Grand Grand Grand Parent");
        }

        public override void myFunc2()
        {
            Console.WriteLine($"Type E : A is: {A} , B is: {B} , C is: {C} , D is: {D} , E is: {E}");

        }
    }
}
