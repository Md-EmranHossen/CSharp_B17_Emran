using Task2;

Lock key = new Lock();

key.LockStatus = "Others";
Console.WriteLine(key.LockStatus);

key.LockStatus = "Open";
Console.WriteLine(key.LockStatus);