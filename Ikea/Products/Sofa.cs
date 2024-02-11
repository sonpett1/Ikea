namespace Ikea.Products;

public class Sofa: Product, ILivingroom
{
    public Sofa(string name, float price = 155) : base(name, price)
    {
        Description = "A cozy sofa";
    }
    
    public override float GetPrice()
    {
        return Price;
    }

    public override string GetShelf()
    {
        return "Shelf 12E";
    }

    public override string GetDescription()
    {
        return Description;
    }

    public string Livingroom()
    {
        return "Belongs in the living room";
    }
}