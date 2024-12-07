using System;

class Program
{
    static void Main(string[] args)
    {
        // Address and Customer 1
        Address address1 = new Address("101 E Vikings Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Cameron Samson", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Soap", "AXGK65", 5, 7),
            new Product("Hand Soap", "AXGK65GH78", 7, 3)
        };
        Order order1 = new Order(products1, customer1);

        // Address and Customer 2
        Address address2 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer2 = new Customer("Homer Simpson", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Donut", "DNT123", 2, 12),
            new Product("Duff Beer", "DUFF456", 3.5f, 6)
        };
        Order order2 = new Order(products2, customer2);

        // Address and Customer 3
        Address address3 = new Address("221B Baker Street", "London", "London", "UK");
        Customer customer3 = new Customer("Sherlock Holmes", address3);
        List<Product> products3 = new List<Product>
        {
            new Product("Magnifying Glass", "MG789", 15, 1),
            new Product("Deerstalker Hat", "HAT101", 20, 1)
        };
        Order order3 = new Order(products3, customer3);

        // Print order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();

        Console.WriteLine("Order 3:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order3.CalculateTotalCost()}");
        Console.WriteLine(order3.GetShippingLabel());

        
    }
}