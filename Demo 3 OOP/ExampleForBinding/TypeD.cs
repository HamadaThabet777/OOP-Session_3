using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.ExampleForBinding
{
    internal class TypeD: TypeC
    {
        public int D { get; set; }

        public TypeD(int _A, int _B, int _C , int _D) : base(_A, _B, _C)
        {
            D = _D;
        }

        public new void myFunc1()
        {
            Console.WriteLine("i D Grand Grand Parent");
        }

        //public new virtual عشان اكسر السلسله اللي كانت بتححصل وابدا انا سلسله خاصه بيا هستخدم
        // virual يعني وارثها من مكان تاني,  new يعني اخفي السلسه القديمه 
        // D او كلاس وارث من كلاس D دي مش هشتغل غير عند كلاس
        public new virtual void myFunc2()
        {
            Console.WriteLine($"Type D : A is: {A} , B is: {B} , C is: {C} , D is: {D}");

        }
    }
}
