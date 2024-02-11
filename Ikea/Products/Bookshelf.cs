namespace Ikea.Products;

public class Bookshelf: Product, ILivingroom, IOffice, IBedroom
{
    public Bookshelf(string name, float price = 68.33F) : base(name, price)
    {
        Description = "A big bookshelf";
       
    }

    public override float GetPrice()
    {
        return Price;
    }

    public override string GetShelf()
    {
        return "Shelf 3C";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public string Livingroom()
    {
        return "Could be in living room";
    }

    public string Office()
    {
        return "Great bookshelf for an office";
    }

    public string Bedroom()
    {
        return "Will fit in a bedroom";
    }
}