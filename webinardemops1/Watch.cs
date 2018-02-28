using System;
using System.Collections.Generic;
using System.Text;

namespace webinardemops1
{
    class Watch:Iwatch,IwatchDetails
    {
        public DateTime setTime(DateTime dt)
        {
            return dt;
      
        }
        public DateTime getTime()
        {
            return DateTime.Now;
        }

    }
}
