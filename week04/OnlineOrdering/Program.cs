using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address("123 Main Stree", "New York", "NY", "USA");
        Customer customer1 = new Customer("Jose Koth", address1);

        Address address2 = new Address("749 Paple Ave", "Tokne", "ON", "Canada");
        Customer customer2 = new Customer("Maria Villa", address2);


        Product prodc1 = new Product("Laptop Aus", "N89", 3000, 4);
        Product prodc2 = new Product("Phone", "N90", 550, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(prodc1);
        order1.AddProduct(prodc2);

        Product prodc3 = new Product("Tv", "P003", 800, 3);
        Product prodc4 = new Product("Control", "P004", 50, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(prodc3);
        order2.AddProduct(prodc4);

        List<Order> orders = new List<Order> { order1, order2 };

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total Price: ${order.GetTotalPrice()}");
            
        }

    }
}