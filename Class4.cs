using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_4
{
    class MyRoomComparer : IComparer<MyRoom>
    {
        public int Compare(MyRoom p1, MyRoom p2)
        {
            if (p1.windows > p2.windows)
                return 1;
            else if (p1.windows < p2.windows)
                return -1;
            else
                return 0;
        }
    }
}
