//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Demo_3_OOP.Builtin_Interface
//{
//    internal class EmpIComparer : IComparer
//    {
//        //بتاعتها methoud هقف عليها عشان انزل ال
//        // هنا نا بقارن كلاس ب كلاس
//        public int Compare(object? x, object? y)
//        {
//            Emp? empX = (Emp?)x;
//            Emp? empY = (Emp?)y;
//            return empX?.Id.CompareTo(empY?.Id)??(empY is null?0 : -1);
//        }
//    }
//}
