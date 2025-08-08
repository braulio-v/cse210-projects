using System;
using System.Security.Cryptography.X509Certificates;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double total = 0;
        foreach (Product p in _products)
        {
            total += p.GetTotalCost();
        }

        if (_customer.LivesInUsa())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:";
        foreach (Product p in _products)
        {
            label += $" {p.GetName()}, ID: {p.GetProductId()} ;";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label: {_customer.GetName()}, {_customer.GetAddressString()}";
    }
}