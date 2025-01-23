using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3_OOP.Interface
{
    internal class SeriesBy2 : ISeries
    {
        public int current {  get; set; }
        public void GrtNext()
        {
            current += 2; 
        }

        public void Reset()
        {
            current = 0;
        }

        //خلصت هنا بقا هروح اعمل فنكش برا تخليه يطبعلي ال 10 مرات
    }
}
