using Task2;

Lock key = new Lock();

key.LockStatus = "ABCD";
Console.WriteLine(key.LockStatus);

key.LockStatus = "Open";
Console.WriteLine(key.LockStatus);



key.LockStatus = "Close";
Console.WriteLine(key.LockStatus);