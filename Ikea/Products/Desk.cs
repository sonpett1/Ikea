namespace Ikea.Products;

public class Desk: Product, IAssemblable, IOffice
{
    public Desk(string name, float price = 199.99F) : base(name, price)
    {
        Description = "Large adjustable dest";
        
    }

    public override float GetPrice()
    {
        return Price;
    }

    public override string GetShelf()
    {
        return "Shelf 1E";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public string Assemble()
    {
        return "put the legs on the plate";
    }

    public string Office()
    {
        return "Great fit for an office!!!";
    }
}