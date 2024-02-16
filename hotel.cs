using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac1
{
    public class hotel
    {
        public static int lakewoodWeekday { set; get; }
        public static int lakewoodWeekend { set; get; }

        public static int lakewoodRating { set; get; }

        public static int bridgewoodWeekday { set; get; }
        public static int bridgewoodWeekend { set; get; }

        public static int bridgewoodRating { set; get; }

        public static int ridgewoodWeekday { set; get; }
        public static int ridgewoodWeekend { set; get; }

        public static int ridgewoodRating { set; get; }

        public hotel(int a, int b, int c,int d, int e, int f, int g,int h,int i)
        {
            lakewoodWeekday = a;
            lakewoodWeekend = b;
            lakewoodRating = c;
            bridgewoodWeekday = d;
            bridgewoodWeekend = e;
            bridgewoodRating = f;
            ridgewoodWeekday = g;
            ridgewoodWeekend = h;
            ridgewoodRating = i;

        }

    }
}
