using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_4
{
    class MyRoom : IRoom//, IComparable
    {
        public int windows;
        int shelf;
        float shirina;
        float dlina;
        float vysota;
        int computer;
        public MyRoom(int w, float s, float d, float v, int sh, int c)
        {
            windows = w;
            shirina = s;
            dlina = d;
            vysota = v;
            shelf = sh;
            computer = c;
        }
        public void Output()
        {
            Console.WriteLine("Одна стена = {0} \nВторая стена = {1} \nВысота = {2}  \nКоличество окон = {3}\nКоличество полок = {4}\nКоличество компьютеров = {5}", shirina, dlina, vysota, windows, shelf, computer);
        }

        public double Square()
        {
            return shirina * dlina;
        }
    }
}
