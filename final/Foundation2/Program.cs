using System;

class Program
{
    static void Main(string[] args)
    {
        Product order1Product1 = new Product("Mouse", "A01", 15.00, 2);
        Product order1Product2 = new Product("Keyboard", "A02", 25.00, 2);
        Product order1Product3 = new Product("Panel", "A03", 40.00, 2);
        List<Product> products1 = new List<Product>();
        products1.Add(order1Product1);
        products1.Add(order1Product2);
        products1.Add(order1Product3);

        Address address1 = new Address("Street One", "Kingston", "NY", "USA");

        Customer customer1 = new Customer("CC Hsiao", address1);
        
        Order order1 = new Order(products1, customer1);

        Product order2Product1 = new Product("MiniMouse", "A04", 20.00, 4);
        Product order2Product2 = new Product("MiniKeyboard", "A05", 30.00, 4);
        Product order2Product3 = new Product("MiniPanel", "A06", 50.00, 4);
        List<Product> products2 = new List<Product>();
        products2.Add(order2Product1);
        products2.Add(order2Product2);
        products2.Add(order2Product3);

        Address address2 = new Address("Street Zhongxing", "Zhudong", "Hsinchu", "Taiwan");        

        Customer customer2 = new Customer("CH Hsieh", address2);
        
        Order order2 = new Order(products2, customer2);

        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);

        for (int i=0; i < orders.Count(); i++)
        {
            Console.WriteLine($"{orders[i]}{i+1}");
            Console.WriteLine($"Total Cost: ${orders[i].GetTotalCost()}");
            Console.WriteLine("Packing Label:");
            orders[i].GetPackingLabel(orders[i].GetProducts());
            Console.WriteLine("Shipping Label:");
            orders[i].GetShippingLable(orders[i].GetCustomer());
            Console.WriteLine();
        }
    }
}