using Ikea;
using Ikea.Products;

class Program
{
    static void Main(string[] args)
    {
        var shoppingList = new List<Product>();
        shoppingList.Add(new Sofa("Benson sofa"));
        shoppingList.Add(new OfficeChair("Backsupporter 9000", 222.55F));
        shoppingList.Add(new Bookshelf("Ss"));

        var bbed = new BunkBed("test");
        Console.Write(bbed.Assemble());
        
        

        float sum = 0;
        foreach (Product item in shoppingList)
        {
            Console.WriteLine($"Adding {item.GetDescription()} to total! price: {item.GetPrice()}");
            sum += item.GetPrice();
            Console.WriteLine($"Total is now: {sum}");
        }
    }
}