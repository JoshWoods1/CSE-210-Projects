// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

DVD dvd1 = new DVD("Finding Nemo");
dvd1.CheckOut();
dvd1.Display();

Book findingDory = new Book("Finding Dory", "876-1567813", 123456789);
findingDory.Display();