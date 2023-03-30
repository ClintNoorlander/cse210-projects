using System;
class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");
            Customer customer1 = new Customer("Alice", address1);

            List<Product> products1 = new List<Product>();
            products1.Add(new Product("Widget", 1, 2.5, 3));
            products1.Add(new Product("Gizmo", 2, 1.0, 4));
            Order order1 = new Order(products1, customer1);

            Console.WriteLine("Order 1 Packing Label:\n" + order1.PackingLabel());
            Console.WriteLine("Order 1 Shipping Label:\n" + order1.ShippingLabel());
            Console.WriteLine("Order 1 Total Cost: $" + order1.TotalCost());

            Address address2 = new Address("456 Elm St", "Anytown", "ON", "Canada");
            Customer customer2 = new Customer("Bob", address2);

            List<Product> products2 = new List<Product>();
            products2.Add(new Product("Doodad", 3, 1.5, 2));
            products2.Add(new Product("Thingamajig", 4, 3.0, 1));
            products2.Add(new Product("Whatchamacallit", 5, 2.0, 2));
            Order order2 = new Order(products2, customer2);

            Console.WriteLine("Order 2 Packing Label:\n" + order2.PackingLabel());
            Console.WriteLine("Order 2 Shipping Label:\n" + order2.ShippingLabel());
            Console.WriteLine("Order 2 Total Cost: $" + order2.TotalCost());

            Console.ReadLine();
        }
    }