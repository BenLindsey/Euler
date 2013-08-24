using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = new DateTime(1901, 1, 1);
            var end = new DateTime(2000, 12, 31);

            var sundayCount = Enumerable.Range(0, (end - start).Days)
                                        .Select(i => start.AddDays(i))
                                        .Where(day => day.DayOfWeek == DayOfWeek.Sunday
                                                   && day.Day == 1)
                                        .Count();

            Console.WriteLine(sundayCount);
            Console.ReadLine();
        }
    }
}
