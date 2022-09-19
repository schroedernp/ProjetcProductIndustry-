
using System.Globalization;
using ProductIndustry.Entities;
List<Product> listProduct = new List<Product>();
Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Product #{i} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    char ch = char.Parse(Console.ReadLine());
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(ch == 'c' || ch == 'C')
    {
        listProduct.Add(new Product(name, price));

    } else if(ch == 'u' || ch == 'U')
    {
        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manufactedDate = DateTime.Parse(Console.ReadLine());
        //DateTime manufactedDate =DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
        listProduct.Add(new UsedProduct(name, price, manufactedDate));
    }
    else if(ch == 'i' || ch =='I')
    {
        Console.Write("Customs fee: ");
        double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        listProduct.Add( new ImportedProduct(name, price, customFee));
    }

}
Console.WriteLine();
Console.WriteLine("PRICE TAGS: ");
foreach(Product product in listProduct)
{
    Console.WriteLine(product.PriceTag());
}
