using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Interface
{
    internal interface ISeries
    {
        public int current { get; set; }// بتاخد الرقم الحالي

        public void GrtNext(); // بتحسب الرقم اللي بعدو

        public void Reset(); //بترجع بقا مالاول> تصفير القيمة.

        //ده interface خلصت ؟ اروح اعمل كلاس انفذ فيه ال
        // Series هعمل كلاس اسمو
    }
}
