// Rekommenderad läsning: https://www.tektutorialshub.com/asp-net-core-tutorial/
// Även https://www.learnentityframeworkcore.com/ är bra
// Och så förstås Microsofts dokumentation med början på https://learn.microsoft.com/en-us/ef/core/


using EFCoreLektion.Models;

//Console.WriteLine("Hello, World!");

//InsertProduct();
ReadProduct();
UpdateProduct();
ReadProduct();
DeleteProduct();
ReadProduct();


Console.Write("\n\nTryck på en tangent för att stänga fönstret ...");
Console.ReadKey();


void InsertProduct()
{
	using (var db = new EFContext())
	{
		Product product = new Product();
		product.Name = "Pen Drive";
		db.Add(product);

		product = new Product() { Name = "Memory Card"};
		db.Add(product);

		db.SaveChanges();
	}
	return;
}

static void ReadProduct()
{
	using (var db = new EFContext())
	{
		List<Product> products = db.Products.ToList();
		foreach (var product in products)
		{
            Console.WriteLine("{0} {1}", product.Id, product.Name);
		}
	}
	return;
}

static void UpdateProduct()
{
	using (var db = new EFContext())
	{
		var product = db.Products.Find(1);
		product.Name = "Better Pen Drive";

		db.SaveChanges();
	}
}

static void DeleteProduct()
{
	using (var db = new EFContext())
	{
		var product = db.Products.Find(1);
		db.Products.Remove(product);

		db.SaveChanges();
	}
}

