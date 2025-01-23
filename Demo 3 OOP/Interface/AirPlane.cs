using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Interface
{
    internal class AirPlane : Vichal, IFlyable, IMoveable
    {
        //دي تبع الطيارهولا الربيه مالاتنين عندهم نفس الحاجه methoud طب هو لما يجي يحدد هي ال
        //explicit casting هحتاج اعمل
        //بس عشان في حاجتين بيمشو ع الارض IMoveable هعملو ف ال
        //ده خاص ب الطياره بس IFlyable انما ال

        //alt+enter>>Impliment explicity الاول واختار IMoveable هقف ع 
        //IFlyable وبعدين اعمل ال
        void IMoveable.Backward()
        {
            Console.WriteLine("AirPlane Move Backward");
        }

        void IFlyable.Backward()
        {
            Console.WriteLine("AirPlane Fly Backward");
        }

        void IMoveable.Forward()
        {
            Console.WriteLine("AirPlane Move Forward");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane Fly Forward");
        }

        void IMoveable.Left()
        {
            Console.WriteLine("AirPlane Move Left");
        }

        void IFlyable.Left()
        {
            Console.WriteLine("AirPlane Fly Left");
        }

        void IMoveable.Right()
        {
            Console.WriteLine("AirPlane Move Right");
        }

        void IFlyable.Right()
        {
            Console.WriteLine("AirPlane Fly Right");
        }
    }
}
