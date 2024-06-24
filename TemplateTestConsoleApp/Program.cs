using TemplateTestConsoleApp.ModelsNorthWind;

namespace TemplateTestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext context = new NorthwindContext();
            var y = context.Customers.Take(3).ToList () ;
            Console.WriteLine($"First few customers {y.Count }");
            Console.WriteLine("Hello, World!");
        }
    }
}
