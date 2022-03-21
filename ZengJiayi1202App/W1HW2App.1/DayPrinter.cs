using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1HW2App._1
{
    internal class DayPrinter
    {
        static void Main(string[] args)
        {
            String[] days = { "Manday,Tuesday", "Wednesday", "Thursday", "Friday", "Saturday","Sunday" };
            for (int i = 0; i < days.Length; i++) 
            { Console.WriteLine(days[i]); }
        }
    }
}
