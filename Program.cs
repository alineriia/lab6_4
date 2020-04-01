using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyRoom p1 = new MyRoom (3,10,12,3,3,1);
            MyRoom p2 = new MyRoom(4, 15, 9, 2, 4, 2);
            MyRoom p3 = new MyRoom(1, 8, 7, 4, 6, 2); 
            MyRoom [] rooms = new MyRoom[] { p1, p2, p3 };
            Array.Sort(rooms, new MyRoomComparer());
            Console.WriteLine("AFTER SORTING USING ICOMPARER");
            foreach (MyRoom p in rooms)
            { 
                Console.WriteLine("{0}",p.windows);
            }
            ClassRoom c1 = new ClassRoom(3, 10, 12, 3, 3, 1);
            ClassRoom c2 = new ClassRoom(4, 15, 9, 2, 4, 2);
            ClassRoom c3 = new ClassRoom(1, 8, 7, 4, 6, 2);
            ClassRoom[] classrooms = new ClassRoom[] { c1, c2, c3 };
            Array.Sort(classrooms);
            Console.WriteLine("AFTER SORTING USING ICOMPARABLE");
            foreach (ClassRoom c in classrooms)
            {
                Console.WriteLine("{0}", c.Square());
            }
            Console.ReadKey();

        }
    }
}
