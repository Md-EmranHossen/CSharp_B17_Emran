using AttendanceSystem;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

var dbContext = new AttendanceDbContext();
dbContext.Database.Migrate();
Console.WriteLine("*** Welcome To Attendance System ***");

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

void HandleAdmin(AttendanceDbContext dbContext, Admin admin)
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

void HandleTeacher(AttendanceDbContext dbContext, Teacher teacher)
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

void HandleStudent(AttendanceDbContext dbContext, Student student)
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

void CreateTeacher(AttendanceDbContext dbContext)
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

void CreateStudent(AttendanceDbContext dbContext)
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

void CreateCourse(AttendanceDbContext dbContext)
{
    Console.Write("Enter course name: ");
    var name = Console.ReadLine();
    Console.Write("Enter course fees: ");
    var fees = decimal.Parse(Console.ReadLine());

    Console.Write("Enter teacher username: ");
    var username = Console.ReadLine();
    var teacher = dbContext.Teachers.FirstOrDefault(t => t.Username == username);
    if (teacher == null)
    {
        Console.WriteLine("Teacher not found.");
        return;
    }

    var course = new Course { Name = name, Fees = fees, Teacher = teacher };
    dbContext.Courses.Add(course);
    dbContext.SaveChanges();
    Console.WriteLine("Course created successfully.");
}

void AssignTeacherToCourse(AttendanceDbContext dbContext)
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

    course.Teacher = teacher;
    course.TeacherId = teacher.Id;
    dbContext.SaveChanges();
    Console.WriteLine("Teacher assigned to course successfully.");
}

void AssignStudentToCourse(AttendanceDbContext dbContext)
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

    if (course.Students.Contains(student))
    {
        Console.WriteLine("Student already enrolled in this course.");
        return;
    }

    course.Students.Add(student);
    dbContext.SaveChanges();
    Console.WriteLine("Student assigned to course successfully.");
}

void SetClassSchedule(AttendanceDbContext dbContext)
{
    Console.Write("Enter course name: ");
    var courseName = Console.ReadLine();
    var course = dbContext.Courses.FirstOrDefault(c => c.Name == courseName);
    if (course == null)
    {
        Console.WriteLine("Course not found.");
        return;
    }

    Console.Write("Enter day of week (e.g., Sunday): ");
    var day = Enum.Parse<DayOfWeek>(Console.ReadLine(), true);
    Console.Write("Enter class time (e.g., 8PM - 10PM): ");
    var time = Console.ReadLine();
    Console.Write("Enter total number of classes: ");
    var totalClasses = int.Parse(Console.ReadLine());

    var schedule = new Schedule
    {
        Day = day,
        Time = time,
        TotalClasses = totalClasses,
        Course = course
    };
    dbContext.Schedules.Add(schedule);
    dbContext.SaveChanges();
    Console.WriteLine("Class schedule set successfully.");
}

void ViewAttendanceReport(AttendanceDbContext dbContext, Teacher teacher)
{
    Console.Write("Enter course name: ");
    var courseName = Console.ReadLine();
    var course = dbContext.Courses
        .Include(c => c.Students)
        .Include(c => c.Attendances) 
        .ThenInclude(a => a.Student)
        .FirstOrDefault(c => c.Name == courseName);
    if (course == null)
    {
        Console.WriteLine("Course not found.");
        return;
    }

    var students = course.Students;
    Console.WriteLine($"Attendance Report for {courseName}");
    foreach (var student in students)
    {
        Console.Write($"{student.Name}: ");
        var studentAttendances = course.Attendances
            .Where(a => a.StudentId == student.Id)
            .ToList();
        foreach (var schedule in course.Schedules)
        {
            var attendance = studentAttendances
                .FirstOrDefault(a => a.Date.DayOfWeek == schedule.Day);
            if (attendance != null && attendance.IsPresent)
            {
                Console.Write("✔ ");
            }
            else
            {
                Console.Write("✘ ");
            }
        }
        Console.WriteLine();
    }
}


void GiveAttendance(AttendanceDbContext dbContext, Student student)
{
    var enrolledCourses = dbContext.Courses.Where(c => c.Students.Contains(student)).ToList();
    if (!enrolledCourses.Any())
    {
        Console.WriteLine("You are not enrolled in any courses.");
        return;
    }

    Console.WriteLine("Your enrolled courses:");
    for (int i = 0; i < enrolledCourses.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {enrolledCourses[i].Name}");
    }

    Console.Write("Select course number: ");
    int courseIndex = int.Parse(Console.ReadLine()) - 1;
    if (courseIndex < 0 || courseIndex >= enrolledCourses.Count)
    {
        Console.WriteLine("Invalid selection.");
        return;
    }

    var course = enrolledCourses[courseIndex];
    Console.Write("Enter class day (e.g., Sunday): ");
    var day = Enum.Parse<DayOfWeek>(Console.ReadLine(), true);
    Console.Write("Enter class time (e.g., 8PM - 10PM): ");
    var time = Console.ReadLine();

    var attendance = new Attendance
    {
        Student = student,
        Course = course,
        Date = DateTime.Now,
        IsPresent = true
    };

    dbContext.Attendances.Add(attendance);
    dbContext.SaveChanges();
    Console.WriteLine("Attendance recorded successfully.");
}
