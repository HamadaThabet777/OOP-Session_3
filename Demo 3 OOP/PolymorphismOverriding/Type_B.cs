using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2_OOP.PolymorphismOverriding
{
    internal class Type_B : Type_A
    {
        public int B { get; set; }

        public Type_B(int _A, int _B) : base(_A)
        {
            B = _B;
        }

        //main هروح لل
        //-----
        // طب انا كده عملت اي فين البصمه بتعتي
        //overriding هستخدم بقا ال

        // 1- اول طريقه هخفي الفنكن الاساسيه اللي وارثها واعدل انا براحتي
        //هخفي الاصل new عن طريق استخدام كلمه  

        //public بعد new هعمل فنكشن عاديه بس هحط 

        public new void myFunc1()
        {
            Console.WriteLine("i child");
        }
        //i child
        // Type A is: 15


        // 2- تاني طريقه هسيب الفنكن الاساسيه اللي وارثها واعدل انا براحتي
        //في الفنكشن الاساسيه virtual عن طريق استخدام كلمه

        //public بعد virtual هعدل ف الفنكشن الاساسيه  بس هحط 

        //to string ع ال override هجيبيها زي م كنت بعمل 


        public override void myFunc2()
        {
            Console.WriteLine($"Type A is: {A} , Type B is: {B}");
        }
        // i child
        //Type A is: 15 , Type B is: 14

    }
}
