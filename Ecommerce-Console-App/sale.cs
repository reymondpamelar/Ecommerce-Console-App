namespace Ecommerce_Console_App;

public interface ISale
{
    string User{ get; set; }
    string Product { get; set; }
    string Date { get; set; }
}

class Sale : ISale
{
    private string user = "";
    private string product = "";
    private string date = "";
    public string User { get; set; }
    public string Product { get; set; }
    public string Date { get; set; }

    public void DisplayUser()
    {
        Console.WriteLine(User);
    }
    
    public void DisplayProduct()
    {
        Console.WriteLine(product);
    }
    
    public void DisplayDate()
    {
        Console.WriteLine(date);
    }
    
}