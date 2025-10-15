// Set Danish culture for the application
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("da-DK");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("da-DK");

//create a class Product with name and price. Use init. Not set
public class Product
{
    public string Name { get; init; }
    public decimal Price { get; init; }

    // Add method ToString
    public override string ToString()
    {
        return $"Product: {Name}, Price: {Price:C}";
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

// Create a class ProductCatalog with lists of ElectronicProduct and BookProduct

