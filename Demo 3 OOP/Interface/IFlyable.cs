using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Interface
{
    internal interface IFlyable
    {
        //دي تبع الطيارهولا الربيه مالاتنين عندهم نفس الحاجه methoud طب هو لما يجي يحدد هي ال
        //explicit casting هحتاج اعمل
        //بس عشان في حاجتين بيمشو ع الارض IMoveable هعملو ف ال
        //ده خاص ب الطياره بس IFlyable انما ال
        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
