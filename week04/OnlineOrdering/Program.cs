class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("111 Mom Lane", "Des Moines", "IA", "USA");
        Customer c1 = new Customer("Emily Bennion", a1);

        Order order1 = new Order(c1);
        order1.AddProduct(new Product("Water Bottle", "A1A", 15.00, 1));
        order1.AddProduct(new Product("Straw Brush", "B1B", 5.50, 1));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: {order1.GetTotalCost()}\n");

        Address a2 = new Address("222 Dad Blvd", "North Liberty", "IA", "USA");
        Customer c2 = new Customer("Paul Walker", a2);

        Order order2 = new Order(c2);
        order2.AddProduct(new Product("Tennis Racket","A2AB", 25.75, 2));
        order2.AddProduct(new Product("Tennis Balls", "B2BC", 9.00, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}\n");
    }
}