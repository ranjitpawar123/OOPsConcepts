using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    public enum Days
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday
    }
    public class Class1
    {
        public static Days MeetingDay { get; set; } = 0;
        static void Main()
        {
            MeetingDay = Days.Thursday;
            Console.WriteLine(MeetingDay);
            Console.ReadLine();
        }
    }
}
