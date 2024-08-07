using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Fees { get; set; }

        public Teacher Teacher { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Schedule> Schedules { get; set; } = new List<Schedule>();
    }
}
