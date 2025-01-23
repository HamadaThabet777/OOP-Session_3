//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo_3_OOP.Builtin_Interface
//{
//    internal class Emp : ICloneable, IComparable
//    {
//        //بتاعتها methoud هقف عليها عشان انزل ال
//        public int Id { get; set; }

//        public string? Name { get; set; }

//        public int Salary { get; set; }

//        //copy with constructor

//        //parametarless هعمل ال
//        public Emp()
//        {

//        }

//        public Emp(Emp employeeCopy)
//        {
//            this.Id = employeeCopy.Id;
//            this.Name = employeeCopy.Name;
//            this.Salary = employeeCopy.Salary;

//            // this >> for caller employee01 بتاع ال

//        }
//        // copy with deep copy
//        public object Clone()
//        {
//            return new Emp()
//            {
//                Id = this.Id,
//                Name = this.Name,
//                Salary = this.Salary,

//                // this >> for caller employee01 بتاع ال

//            };
//        }

//        public override string ToString()
//        {
//            return $"Employee Id is {Id}\nEmployee Name is {Name}\nEmployee Salary is {Salary}";

//        }

//        //انا هقارن ع اساس السالري
//        public int CompareTo(object? obj)
//        {
//            Emp? CompareEmp = (Emp?) obj;// explicit casting
//            if (this.Salary > CompareEmp?.Salary)
//                return 1;
//            else
//            if (this.Salary < CompareEmp?.Salary)
//                return -1;
//            else
//                return 0;

//        }
//    }
//}
