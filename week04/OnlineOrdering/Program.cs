using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: USA Customer
        Address addr1 = new Address("123 Maple St", "Rexburg", "ID", "USA");
        Customer cust1 = new Customer("Rex Tusk", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Laptop", "TECH001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "TECH002", 25.50, 2));

        // Order 2: International Customer
        Address addr2 = new Address("2380 Kapenda Street", "Lubumbashi", "Katanga", "Democratic Republic of the Congo");
        Customer cust2 = new Customer("Madji Kayombo", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Coffee Mug", "HOME05", 12.00, 4));
        order2.AddProduct(new Product("Journal", "OFFICE09", 8.50, 1));
        order2.AddProduct(new Product("Pen Set", "OFFICE10", 15.00, 1));

        // Display Order 1
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():F2}");
        Console.WriteLine("\n-------------------------------------------\n");

        // Display Order 2
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():F2}");
    }
}