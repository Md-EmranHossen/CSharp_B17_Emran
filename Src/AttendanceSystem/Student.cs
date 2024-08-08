using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceSystem
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Attendance> Attendances { get; set; } = new List<Attendance>();
    }



}
