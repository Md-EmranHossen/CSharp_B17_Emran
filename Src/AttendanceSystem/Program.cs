using AttendanceSystem;
using Microsoft.EntityFrameworkCore;

var dbContext = new AttendanceDbContext();
dbContext.Database.Migrate();

Console.Write("Enter username: ");
var username = Console.ReadLine();
Console.Write("Enter password: ");
var password = Console.ReadLine();

var admin = dbContext.Admins.FirstOrDefault(u => u.Username == username && u.Password == password);
if (admin != null)
{
    HandleAdmin(dbContext, admin);
}
else
{
    var teacher = dbContext.Teachers.FirstOrDefault(u => u.Username == username && u.Password == password);
    if (teacher != null)
    {
        HandleTeacher(dbContext, teacher);
    }
    else
    {
        var student = dbContext.Students.FirstOrDefault(u => u.Username == username && u.Password == password);
        if (student != null)
        {
            HandleStudent(dbContext, student);
        }
        else
        {
            Console.WriteLine("Invalid username or password.");
        }
    }
}

static void HandleAdmin(AttendanceDbContext dbContext, Admin admin)
{
    while (true)
    {
        Console.WriteLine("Admin Menu:");
        Console.WriteLine("1. Create Teacher");
        Console.WriteLine("2. Create Student");
        Console.WriteLine("3. Create Course");
        Console.WriteLine("4. Assign Teacher to Course");
        Console.WriteLine("5. Assign Student to Course");
        Console.WriteLine("6. Set Class Schedule");
        Console.WriteLine("7. Exit");
        Console.Write("Choose an option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                CreateTeacher(dbContext);
                break;
            case "2":
                CreateStudent(dbContext);
                break;
            case "3":
                CreateCourse(dbContext);
                break;
            case "4":
                AssignTeacherToCourse(dbContext);
                break;
            case "5":
                AssignStudentToCourse(dbContext);
                break;
            case "6":
                SetClassSchedule(dbContext);
                break;
            case "7":
                return;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}

static void CreateTeacher(AttendanceDbContext dbContext)
{
    Console.Write("Enter teacher name: ");
    var name = Console.ReadLine();
    Console.Write("Enter username: ");
    var username = Console.ReadLine();
    Console.Write("Enter password: ");
    var password = Console.ReadLine();

    var teacher = new Teacher { Name = name, Username = username, Password = password };
    dbContext.Teachers.Add(teacher);
    dbContext.SaveChanges();
    Console.WriteLine("Teacher created successfully.");
}

static void CreateStudent(AttendanceDbContext dbContext)
{
    Console.Write("Enter student name: ");
    var name = Console.ReadLine();
    Console.Write("Enter username: ");
    var username = Console.ReadLine();
    Console.Write("Enter password: ");
    var password = Console.ReadLine();

    var student = new Student { Name = name, Username = username, Password = password };
    dbContext.Students.Add(student);
    dbContext.SaveChanges();
    Console.WriteLine("Student created successfully.");
}

static void CreateCourse(AttendanceDbContext dbContext)
{
    Console.Write("Enter course name: ");
    var name = Console.ReadLine();
    Console.Write("Enter course fees: ");
    var fees = decimal.Parse(Console.ReadLine());

    var course = new Course { Name = name, Fees = fees };
    dbContext.Courses.Add(course);
    dbContext.SaveChanges();
    Console.WriteLine("Course created successfully.");
}

static void AssignTeacherToCourse(AttendanceDbContext dbContext)
{
    Console.Write("Enter teacher username: ");
    var username = Console.ReadLine();
    var teacher = dbContext.Teachers.FirstOrDefault(t => t.Username == username);
    if (teacher == null)
    {
        Console.WriteLine("Teacher not found.");
        return;
    }

    Console.Write("Enter course name: ");
    var courseName = Console.ReadLine();
    var course = dbContext.Courses.FirstOrDefault(c => c.Name == courseName);
    if (course == null)
    {
        Console.WriteLine("Course not found.");
        return;
    }

    teacher.Courses.Add(course);
    dbContext.SaveChanges();
    Console.WriteLine("Teacher assigned to course successfully.");
}

static void AssignStudentToCourse(AttendanceDbContext dbContext)
{
    Console.Write("Enter student username: ");
    var username = Console.ReadLine();
    var student = dbContext.Students.FirstOrDefault(s => s.Username == username);
    if (student == null)
    {
        Console.WriteLine("Student not found.");
        return;
    }

    Console.Write("Enter course name: ");
    var courseName = Console.ReadLine();
    var course = dbContext.Courses.FirstOrDefault(c => c.Name == courseName);
    if (course == null)
    {
        Console.WriteLine("Course not found.");
        return;
    }

    student.EnrolledCourses.Add(course);
    dbContext.SaveChanges();
    Console.WriteLine("Student assigned to course successfully.");
}

static void SetClassSchedule(AttendanceDbContext dbContext)
{
    Console.Write("Enter course name: ");
    var courseName = Console.ReadLine();
    var course = dbContext.Courses.FirstOrDefault(c => c.Name == courseName);
    if (course == null)
    {
        Console.WriteLine("Course not found.");
        return;
    }

    Console.Write("Enter day (e.g., Sunday, Monday, etc.): ");
    var dayInput = Console.ReadLine();
    DayOfWeek day;
    if (!Enum.TryParse(dayInput, true, out day))
    {
        Console.WriteLine("Invalid day entered.");
        return;
    }

    Console.Write("Enter time: ");
    var time = Console.ReadLine();
    Console.Write("Enter total number of classes: ");
    var totalClasses = int.Parse(Console.ReadLine());

    var schedule = new Schedule { Course = course, Day = day, Time = time, TotalClasses = totalClasses };
    course.Schedules.Add(schedule);
    dbContext.SaveChanges();
    Console.WriteLine("Class schedule set successfully.");
}

static void HandleTeacher(AttendanceDbContext dbContext, Teacher teacher)
{
    while (true)
    {
        Console.WriteLine("Teacher Menu:");
        Console.WriteLine("1. View Attendance Report");
        Console.WriteLine("2. Exit");
        Console.Write("Choose an option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                ViewAttendanceReport(dbContext, teacher);
                break;
            case "2":
                return;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}

static void ViewAttendanceReport(AttendanceDbContext dbContext, Teacher teacher)
{
    foreach (var course in teacher.Courses)
    {
        Console.WriteLine($"Attendance report for {course.Name}:");
        foreach (var student in course.Students)
        {
            Console.Write($"{student.Name}: ");
            foreach (var schedule in course.Schedules)
            {
                var attendance = dbContext.Attendances.FirstOrDefault(a =>
                    a.Student.Id == student.Id &&
                    a.Course.Id == course.Id &&
                    a.Date.DayOfWeek == schedule.Day); // Compare DayOfWeek
                Console.Write(attendance != null && attendance.IsPresent ? "[✓]" : "[✗]");
            }
            Console.WriteLine();
        }
    }
}

static void HandleStudent(AttendanceDbContext dbContext, Student student)
{
    while (true)
    {
        Console.WriteLine("Student Menu:");
        Console.WriteLine("1. Give Attendance");
        Console.WriteLine("2. Exit");
        Console.Write("Choose an option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                GiveAttendance(dbContext, student);
                break;
            case "2":
                return;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}

static void GiveAttendance(AttendanceDbContext dbContext, Student student)
{
    Console.Write("Enter course name: ");
    var courseName = Console.ReadLine();
    var course = student.EnrolledCourses.FirstOrDefault(c => c.Name == courseName);
    if (course == null)
    {
        Console.WriteLine("Course not found.");
        return;
    }

    Console.Write("Enter class day (e.g., Sunday, Monday): ");
    var dayInput = Console.ReadLine();
    DayOfWeek day;
    if (!Enum.TryParse(dayInput, true, out day))
    {
        Console.WriteLine("Invalid day entered.");
        return;
    }

    var schedule = course.Schedules.FirstOrDefault(s => s.Day == day);
    if (schedule == null)
    {
        Console.WriteLine("Class schedule not found for this day.");
        return;
    }

    var attendance = new Attendance
    {
        Date = DateTime.Now,
        IsPresent = true,
        Course = course,
        Student = student
    };

    dbContext.Attendances.Add(attendance);
    dbContext.SaveChanges();
    Console.WriteLine("Attendance recorded successfully.");
}
