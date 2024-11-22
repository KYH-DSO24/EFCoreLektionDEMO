// See https://aka.ms/new-console-template for more information

using EFCoreLektion.Models;

Console.WriteLine("Hello, World!");

InsertProduct();

Console.Write("Tryck på en tangent för att stänga fönstret ...");
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

