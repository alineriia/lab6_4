using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Створіть інтерфейс "Room". Реалізуйте його в класах «ClassRoom», «MyRoom». Реалізуйте інтерфейс
"IComparable". В якості параметра для сортування використовуйте площу кімнати. Реалізуйте інтерфейс
"IComparer", в якості порівняння використовуйте поле «Кількість вікон».
*/
namespace lab6_4
{
    interface IRoom
    {
        void Output();
        double Square();

    }
    
    
   /* */
}
