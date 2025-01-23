using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Binding
{
    internal class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set; }

    
        public void func1 ()
        {
            Console.WriteLine("Iam Employee");
        }
        public virtual void func2()
        {
            Console.WriteLine($"Employee Id is {Id}\nEmployee Name is {Name}\nEmployee Age is {Age}");
        }

        //FullTimeEmployee هعمل بقا كلاس لل
        //Id, Name, Ageهيورث منه ال
        //Salary هزود علي ال
    }
}
