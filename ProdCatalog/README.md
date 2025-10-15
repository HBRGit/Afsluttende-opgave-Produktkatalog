# Afsluttende-opgave-Produktkatalog
Opgave fra Bogen om C#

## Opgavebeskrivelse
Du skal udvikle en konsolapplikation i .NET 8 (eller h�jere), der giver brugeren mulighed for at oprette og vise et katalog af produkter. Programmet skal underst�tte to typer produkter:

- elektroniske produkter
- b�ger

Hvert produkt skal have et navn og en pris, og derudover skal der v�re specifikke egenskaber for hver produkttype (se kravene nedenfor). Programmet skal ogs� indeholde en klasse til at administrere produkterne i et katalog.

## Krav
### Product og underklasser
- Opret en klasse Product med f�lgende egenskaber (automatiske egenskaber er tilladt - dog skal der benyttes init og ikke set):
  - Name
  - Price
  - En ToString()-metode, der returnerer produktets information (fx Laptop - Price: $500.00).
- Opret to underklasser (automatiske egenskaber er tilladt - dog skal der benyttes init og ikke set):
  - ElectronicProduct med en ekstra egenskab: WarrantyPeriod (int, i m�neder).
  - BookProduct med en ekstra egenskab: Author (string).
- Overskriv ToString() i begge underklasser for at inkludere deres specifikke information:
  - For ElectronicProduct: Laptop - Price: $500.00 - Warranty: 24 months.
  - For BookProduct: C# Programming - Price: $30.00 - Author: John Doe.
### Produktkatalog
- Opret en klasse ProductCatalog til at administrere produkterne. Denne klasse skal:
  - Holde separate lister (```List<T>```) for ```ElectronicProduct``` og ```BookProduct```.
  - Tilf�j metoder til at tilf�je produkter til kataloget (AddElectronicProduct og AddBookProduct).
  - Tilf�j en metode til at vise alle produkter (```ListAllProducts```).

Note

Bem�rk, at din l�sning skal v�re ret simpel og ikke indeholde validering af data eller brug af konstrukt�rer.

## Test af din l�sning
Din opgave er skabe klasserne Product, ElectronicProduct, BookProduct og ProductCatalog samt en konsolapplikation, der demonstrerer funktionaliteten.

Din kode i Program.cs skal best�r af f�lgende:

```
var catalog = new ProductCatalog();

// Add electronic products
catalog.AddElectronicProduct(new ElectronicProduct
{
    Name = "Laptop",
    Price = 5000,
    WarrantyPeriod = 24
});

catalog.AddElectronicProduct(new ElectronicProduct
{
    Name = "Smartphone",
    Price = 3000,
    WarrantyPeriod = 12
});

catalog.AddElectronicProduct(new ElectronicProduct
{
    Name = "Tablet",
    Price = 2500,
    WarrantyPeriod = 18
});

// Add book products
catalog.AddBookProduct(new BookProduct
{
    Name = "C# Programming",
    Price = 300,
    Author = "John Doe"
});

catalog.AddBookProduct(new BookProduct
{
    Name = "Object-Oriented Design",
    Price = 450,
    Author = "Jane Smith"
});

catalog.AddBookProduct(new BookProduct
{
    Name = "Advanced Algorithms",
    Price = 600,
    Author = "Alan Turing"
});

// List all products
catalog.ListAllProducts();
```

N�r programmet k�res, skal det vise f�lgende output:

```
Electronic Products:
Laptop - Price: $5000.00 - Warranty: 24 months
Smartphone - Price: $3000.00 - Warranty: 12 months
Tablet - Price: $2500.00 - Warranty: 18 months

Book Products:
C# Programming - Price: $300.00 - Author: John Doe
Object-Oriented Design - Price: $450.00 - Author: Jane Smith
Advanced Algorithms - Price: $600.00 - Author: Alan Turing
```