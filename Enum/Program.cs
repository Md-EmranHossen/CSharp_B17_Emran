using Enum;

Student student = new Student();
student.Name = "Emran Hossen";
student.Result = ResultOptions.Fail;
Console.WriteLine(student.Result);
Console.WriteLine((int)student.Result);