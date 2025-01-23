using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Binding
{
    internal class FullTimeEmployee : Employee
    //Id, Name, Ageهيورث منه ال
    //Salary هزود علي ال
    {
        public decimal Salary { get; set; }

        //الفنكشن بتوعها Employee عايز بقا اورث من 
        //new بتاعها هستخدم behavior لو عايز اخفي ال
        public new void func1()
        {
            Console.WriteLine("i Full Time Employee");
        }
        //ف الفنكشن الااساسيه مش ف دي public virtual بتاعها هستخدم behavior لا يعم انا مش هخفي ال 

        public override void func2()
        {
           Console.WriteLine($"Employee Id is {Id}\nEmployee Name is {Name}\nEmployee Age is {Age}\nEmployee Salary is {Salary}");

        }
        //main هطلع لل
    }

}