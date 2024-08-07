using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class Schedule
    {
        public int Id { get; set; }
        public DayOfWeek Day { get; set; }
        public string Time { get; set; }
        public int TotalClasses { get; set; }

        public Course Course { get; set; }
    }
}
