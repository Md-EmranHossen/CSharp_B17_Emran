using Task4;

Admin admin = new Admin { FirstName = "Emran", LastName = "Hossen", Email = "emranhossen3075@gmail.com"};
admin.GenerateId();
Console.WriteLine(admin.FullName);
Console.WriteLine(admin.id);


Student student = new Student { FirstName = "Rakib", LastName = "Hossen", Email = "rakibossen3075@gmail.com" };
student.GenerateId();
Console.WriteLine(student.FullName);
Console.WriteLine(student.id);



Teacher teacher = new Teacher { FirstName = "Md.Jalal", LastName = "Uddin", Email = "jalaluddin@gmail.com" };
teacher.GenerateId();
Console.WriteLine(teacher.FullName);
Console.WriteLine(teacher.id);


