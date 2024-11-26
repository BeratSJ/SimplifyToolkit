using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamp_process
{
    internal class Date
    {
        public void DateManager(int Day,int Month,int Year)
        {
            if (Month == 0)
            {
                Month = 1;
            }
            if (Year == 0)
            {
                Year = 1;
            }
            if (Day == 28 && Month == 2 || Year == Year*100/400 || Year == Year/4)
            {

            }
        }
    }
}
