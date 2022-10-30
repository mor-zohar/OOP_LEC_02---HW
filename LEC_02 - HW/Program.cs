// See https://aka.ms/new-console-template for more information

using LEC_02___HW;

Console.WriteLine("----------------------------------------------------------------------------------------------");
Console.WriteLine("---------------------------------------- LEC_02 - HW: ----------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------------------------\n\n");

Console.WriteLine("________________________________________________________     ___________________________________________________________");
Console.WriteLine("|  new class:                                          |     |                                                         |");
Console.WriteLine("|  Products.cs:                                        |     |  main:                                                  |");
Console.WriteLine("|  ---------------                                     |     | ----------                                              |");
Console.WriteLine("|                                                      |     |                                                         |");
Console.WriteLine("|  internal class Products                             |     | Products product1 = new Products(\"Apple\",1,\"Yes\");      |");
Console.WriteLine("|  {                                                   |     | Products product2 = new Products(\"Banana\", 2, \"No\");    |");
Console.WriteLine("|     public string Name { get; set; }                 |     | Products product3 = new Products(\"Kiwi\", 3, \"Yes\");     |");
Console.WriteLine("|     public int Number { get; set; }                  |     |                                                         |");
Console.WriteLine("|     public string Stock { get; set; }                |     |    Console.WriteLine(                                   |");
Console.WriteLine("|                                                      |     |        $\"Product Number: {product1.Number}              |");
Console.WriteLine("|                                                      |     |           Product Name: {product1.Name}                 |");
Console.WriteLine("|     public Products (                                |     |           Product In Stock: {product1.Stock}\");         |");
Console.WriteLine("|     string name, int number, string stock)           |     |                                                         |");
Console.WriteLine("|     {                                                |     |    Console.WriteLine(                                   |");
Console.WriteLine("|       Name = name;                                   |     |        $\"Product Number: {product2.Number}              |");
Console.WriteLine("|       Number = number;                               |     |           Product Name: {product2.Name}                 |");
Console.WriteLine("|       Stock = stock;                                 |     |           Product In Stock: {product2.Stock}\");         |");
Console.WriteLine("|     }                                                |     |                                                         |");
Console.WriteLine("|   }                                                  |     |    Console.WriteLine(                                   |");
Console.WriteLine("|                                                      |     |        $\"Product Number: {product3.Number}              |");
Console.WriteLine("|                                                      |     |           Product Name: {product3.Name}                 |");
Console.WriteLine("|                                                      |     |           Product In Stock: {product3.Stock}\");         |");
Console.WriteLine("|______________________________________________________|     |_________________________________________________________|\n");

Console.WriteLine("\nRESULT:\n--------\n");

Products product1 = new Products("Apple",1,"Yes");
Products product2 = new Products("Banana", 2, "No");
Products product3 = new Products("Kiwi", 3, "Yes");

Console.WriteLine($"Product Number: {product1.Number}\nProduct Name: {product1.Name}\nProduct In Stock: {product1.Stock}\n");
Console.WriteLine($"Product Number: {product2.Number}\nProduct Name: {product2.Name}\nProduct In Stock: {product2.Stock}\n");
Console.WriteLine($"Product Number: {product3.Number}\nProduct Name: {product3.Name}\nProduct In Stock: {product3.Stock}\n");

Console.WriteLine("\n----------------------------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------- LEC_02 - HW END: --------------------------------------");
Console.WriteLine("----------------------------------------------------------------------------------------------\n");
