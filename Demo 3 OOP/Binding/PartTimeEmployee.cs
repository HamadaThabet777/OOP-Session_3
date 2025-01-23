using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Binding
{
    internal class PartTimeEmployee:Employee
    {
        public decimal HoureRate { get; set; }

        //func 1,2 كده وارث منه  emplpyee انا وارث م ال
        //بس func2 واستخدم func1 هخفي 

        public new void func1()
        {
            Console.WriteLine("i Part Time Employee");
        }
        public override void func2()
        {
            Console.WriteLine($"Employee Id is {Id}\nEmployee Name is {Name}\nEmployee Age is {Age}\nEmployee Houre Rate is {HoureRate}");

        }
        //main هطلع لل


    }
}
