using Task9;

ShoppingCart cart = new ShoppingCart(3);


cart.Items[0] = new CartItem { ItemId = 1, Price = 10.5, Quantity = 2 };
cart.Items[1] = new CartItem { ItemId = 2, Price = 5.75, Quantity = 3 };
cart.Items[2] = new CartItem { ItemId = 3, Price = 8.0, Quantity = 1 };

var totalCost = cart.CalculateTotal();

Console.WriteLine(totalCost);

