
namespace TemplateTestConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ModelsNorthWind.NorthwindContext context = new ModelsNorthWind.NorthwindContext();
            var y = context.Customers.Take(3).ToList();
            Console.WriteLine($"First few customers {y.Count}");


            Console.WriteLine("Hello, World!");
        }
    }
}
