using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2_OOP.PolymorphismOverriding
{
    class Type_A
    {
        public int A { get; set; }

        // CONSTRUCTOR

        public Type_A(int _A)
        {
            A = _A;
        }


        public void myFunc1()
        {
            Console.WriteLine("i parent");
        }

        public virtual void myFunc2()
        {
            Console.WriteLine($"Type A is: {A}");
        }

        //type A هطلع برا اعمل اوبجكت من 













    }
}
