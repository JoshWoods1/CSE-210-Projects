

Product prod1 = new Product("Massage Gun", 1234, 87.98, 1);
Product prod2 = new Product("Floor Mat", 1254, 58.38, 1);

Address add = new Address("1234 State street", "Rexburg", "Idaho", "USA");
Customer cust1 = new Customer("John Brown", add);
Order order1 = new Order(cust1);

order1.AddProduct(prod1);
order1.AddProduct(prod2);

Product prod3 = new Product("Water Bottle", 5432, 10.21, 1);
Product prod4 = new Product("Almond Milk", 9876, 3.25, 1);
Product prod5 = new Product("Backpack", 0293, 35.00, 1);

Address add1 = new Address("7263 Road Street", "Madison", "Wisconsin", "USA");
Customer cust2 = new Customer("Stacy Adams", add1);
Order order2 = new Order(cust2);

order2.AddProduct(prod3);
order2.AddProduct(prod4);
order2.AddProduct(prod5);


Console.WriteLine("Order 1\n-------------------");
Console.WriteLine($"Total: ${order1.CalculateTotalCost(5.00, 35.00)}");
order1.PackingLabel();
order1.ShippingLabel(cust1, add);
Console.WriteLine("-------------------");
Console.WriteLine();

Console.WriteLine("Order 2\n -------------------");
Console.WriteLine($"Total: ${order2.CalculateTotalCost(5.00, 35.00)}");
order2.PackingLabel();
order2.ShippingLabel(cust2, add1);
Console.WriteLine("-------------------");

