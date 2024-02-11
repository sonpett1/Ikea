using System.Diagnostics;

namespace Ikea.Products;

public abstract class Product
{
    protected string Name { get; set; }
    protected float Price { get; set; }
    protected string Description { get; set; }


    protected Product(string name, float price)
    {
        Name = name;
        Price = price;
    }

    public abstract float GetPrice();
    public abstract string GetShelf();
    public abstract string GetDescription();
    
    
    
    
}
