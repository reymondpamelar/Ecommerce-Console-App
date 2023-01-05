// See https://aka.ms/new-console-template for more information

namespace Ecommerce_Console_App
{
    class Program
    {
        
        static User GetUserInfo()
        {
            Console.WriteLine("Please enter first name: ");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter last name: ");
            string last = Console.ReadLine();
            Console.WriteLine("Please enter location: ");
            string loc = Console.ReadLine();

            return new User(first, last, loc);
        }
        

        /*
        Product GetUserProduct()
        {
            
        }
        */
        
        /*
        Sale UpdateSales(User person, Product item)
        {
            Sale log = new Sale();
            log.User = person.FirstName + person.LastName;
            log.Product.name
        }
        */

        
        static void Main(String[] args)
        {
            User temp = GetUserInfo();
        }
        
    }
}
