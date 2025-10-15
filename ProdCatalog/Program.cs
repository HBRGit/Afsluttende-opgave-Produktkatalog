// Set Danish culture for the application
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("da-DK");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("da-DK");

//Add some sample products to the catalog and display them
var catalog = new ProductCatalog();
catalog.AddElectronicProduct(new ElectronicProduct { Name = "Laptop", Price = 5000m, WarrantyPeriod = 24 });  //  The m suffix after a number means the value is a decimal literal.
catalog.AddElectronicProduct(new ElectronicProduct { Name = "Smartphone", Price = 3000m, WarrantyPeriod = 12 });
catalog.AddElectronicProduct(new ElectronicProduct { Name = "Tablet", Price = 2500m, WarrantyPeriod = 18 });
catalog.AddBookProduct(new BookProduct { Name = "C# Programming", Price = 300m, Author = "John Doe" });
catalog.AddBookProduct(new BookProduct { Name = "Object-Oriented Design", Price = 400m, Author = "Jane Smith" });
catalog.AddBookProduct(new BookProduct { Name = "Advanced Algorithms", Price = 600m, Author = "Alan Turing" });
catalog.ListAllProducts();

// All type declarations below top-level statements (C# 9. Code direct in file without eksplicit to declare a namespace, a class and a Main-metode).
// Create a class Product with name and price. Use init. Not set
public class Product
{
    public string Name { get; init; }
    public decimal Price { get; init; }

    // Add method ToString
    public override string ToString()
    {
        return $"Product: {Name}, Price: {Price:C}";  //  :C tells the C# runtime to format the numeric value (Price, which is a decimal) as a currency amount. Like 1.234,56 kr. in Danish
    }

}

// Create sub-class ElectronicProduct with the int property WarrantyPeriod [months]
public class ElectronicProduct : Product
{
    public int WarrantyPeriod { get; init; } // in months

    public override string ToString()
    {
        return $"{base.ToString()}, Warranty: {WarrantyPeriod} months";
    }
}

// Create sub-class BookProduct with the string property Author
public class BookProduct : Product
{
    public string Author { get; init; }

    public override string ToString()
    {
        return $"{base.ToString()}, Author: {Author}";
    }
}

// Create a class ProductCatalog with lists List<T> for ElectronicProduct and BookProduct
public class ProductCatalog
{
    public List<ElectronicProduct> ElectronicProducts { get; } = new List<ElectronicProduct>();
    public List<BookProduct> BookProducts { get; } = new List<BookProduct>();
    // Add method to add electronic product
    public void AddElectronicProduct(ElectronicProduct product)
    {
        ElectronicProducts.Add(product);
    }
    // Add method to add book product
    public void AddBookProduct(BookProduct product)
    {
        BookProducts.Add(product);
    }
    // Add method to display all products
    public void ListAllProducts()
    {
        Console.WriteLine("Electronic Products:");
        foreach (var product in ElectronicProducts)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("\nBook Products:");
        foreach (var product in BookProducts)
        {
            Console.WriteLine(product);
        }
    }
}
