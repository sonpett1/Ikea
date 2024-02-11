namespace Ikea.Products;

public class OfficeChair: Product, IOffice, IAssemblable
{
    public OfficeChair(string name, float price = 399.99F) : base(name, price)
    {
        Description = "Gaming chair";
        
    }

    public override float GetPrice()
    {
        return Price;
    }

    public override string GetShelf()
    {
        return "Shelf 5G";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public string Office()
    {
        return "Computer chair";
    }

    public string Assemble()
    {
        return "self assembled";
    }
}