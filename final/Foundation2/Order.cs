using System.ComponentModel;
using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public double GetTotalCost()
    {
        
        double productCost = 0.0;
        double shipCost = 0.0;
        double totalCost = 0.0;

        if (_customer.GetAddress().IsInUSA())
        {
            shipCost = 5.0;
        }
        else 
        {
            shipCost = 35.0;
        }

        foreach (Product product in _products)
        {          
            productCost += product.GetProductCost();
        }

        totalCost = productCost + shipCost;

        return totalCost;
    }

    public void GetPackingLabel(List<Product> products)
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"Product ID: {product.GetProductId()}; Product Name: {product.GetProductName()}.");
        }
    }

    public void GetShippingLable(Customer customer)
    {
        Console.WriteLine($"Customer name: {customer.GetName()}\nAddress: {customer.GetFullAddress(customer.GetAddress())}");
    }

    
}