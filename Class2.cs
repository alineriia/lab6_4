using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_4
{
    class ClassRoom : IRoom, IComparable
    {
        public int windows;
        int tables;
        int chairs;
        float shirina;
        float dlina;
        float vysota;
        public int CompareTo(object obj)
        {
           ClassRoom b = (ClassRoom)obj;
            if (this.Square() == b.Square()) return 0;
            else if (this.Square() > b.Square()) return 1;
            else return -1;
        }

        public ClassRoom(int w, int t, int c, float s, float d, float v)
        {
            windows = w;
            shirina = s;
            dlina = d;
            vysota = v;
            tables = t;
            chairs = c;
        }
        public void Output()
        {
            Console.WriteLine("Одна стена = {0} \nВторая стена = {1} \nВысота = {2}  \nКоличество окон = {3}\nКоличество парт = {4}\nКоличество стульев = {5}", shirina, dlina, vysota, windows,tables,chairs);
        }

        public double Square()
        {
            return shirina * dlina;
        }
        /*public int CompareTo(object obj)
         {
            IRoom b = (IRoom)obj;
             if (this.Square() == b.Square()) return 0;
             else if (this.Square() > b.Square()) return 1;
             else return -1;

         }*/
    }
}
