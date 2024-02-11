namespace Ikea.Products;

public class BunkBed: Product, IAssemblable, IBedroom
{
    public BunkBed(string name, float price = 299.99F) : base(name,price)
    {
        Description = "A bunk bed";
        
    }

    public string Bedroom()
    {
        return $"{Name} is a good fit for a bedroom";
    }

    public string Assemble()
    {
        return "insert assemble instuctions for bunk bed here <---";
    }

    public override float GetPrice()
    {
        return Price;
    }

    public override string GetDescription()
    {
        return Description;
    }

    public override string GetShelf()
    {
        return "Shelf 2A";
    }
}