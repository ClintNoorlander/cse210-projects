using System;
class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(List<Product> products, Customer customer)
    {
        this.products = products;
        this.customer = customer;
    }

    public List<Product> Products
    {
        get { return products; }
        set { products = value; }
    }

    public Customer Customer
    {
        get { return customer; }
        set { customer = value; }
    }

    public double TotalCost()
    {
        double total = 0.0;

        foreach (Product p in products)
        {
            total += p.TotalPrice;
        }

        if (customer.IsInUSA())
        {
            total += 5.0;
        }
        else
        {
            total += 35.0;
        }

        return total;
    }

    public string PackingLabel()
    {
        string label = "";

        foreach (Product p in products)
        {
            label += p.Name + " (id: " + p.ProductId + ")\n";
        }

        return label;
    }

    public string ShippingLabel()
    {
        return customer.Name + "\n" + customer.Address.ToString();
    }
}
