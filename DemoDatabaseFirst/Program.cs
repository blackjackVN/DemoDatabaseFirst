using DemoDatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

class Program
{
    private static void Main(string[] args)
    {
       MyStore2Context myStore = new MyStore2Context();

        var products = from p in myStore.Products
                       select new {p.ProductName, p.CategoryId};
        foreach (var p in products)
        {
            Console.WriteLine($"ProductName: {p.ProductName}, CategoryID: {p.CategoryId}");
        }
        Console.WriteLine("----------------------------------");
        IQueryable<Category> cats = myStore.Categories.Include(c => c.Products);
        foreach (Category c in cats){

            Console.WriteLine($"CategoryId: {c.CategoryId} has {c.Products.Count} products.");
        }

        Console.ReadLine();
    }
}