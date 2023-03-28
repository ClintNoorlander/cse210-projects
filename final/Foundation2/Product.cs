using System;
class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int ProductId
    {
        get { return productId; }
        set { productId = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        set { quantity = value; }
    }

    public double TotalPrice
    {
        get { return price * quantity; }
    }
}
