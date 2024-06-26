using Task1;

Product product= new Product();
Console.WriteLine($"Price: {product.Price}");

Product product2= new Product(117000.45);
Console.WriteLine($"Price: {product2.Price}");

Product product3= new Product(117000.45,"IPhone"," premium smartphone by Apple","MidNight");
Console.WriteLine($"Price: {product3.Price}, Name: {product3.Name}, Description: {product3.Description}, Color: {product3.Color}");


