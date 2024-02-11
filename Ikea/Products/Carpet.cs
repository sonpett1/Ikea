namespace Ikea.Products;

public class Carpet: Product, ILivingroom, IKitchen, IOffice, IBedroom
{
    public Carpet(string name, float price = 55) : base(name, price)
    {
        Description = "A medium brown carpet";
        
    }

    public override float GetPrice()
    {
        return Price;
    }

    public override string GetShelf()
    {
        return "Shelf 2A";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public string Livingroom()
    {
        return "Fits in the whole house";
    }

    public string Kitchen()
    {
        return "Fits in the whole house";
    }

    public string Office()
    {
        return "Fits in the whole house";
    }

    public string Bedroom()
    {
        return "Fits in the whole house";
    }
}