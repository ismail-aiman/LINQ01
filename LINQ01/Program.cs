using static LINQ01.Source;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //01
            //var SeaFood = ProductList.Where(p => p.Category == "Seafood");
            //foreach (var product in SeaFood)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice:C2}");
            //}
            //02
            //var NameOnly = ProductList.Select(p=>p.ProductName);
            //foreach (var name in NameOnly)
            //{
            //    Console.WriteLine($"Product Name: {name}");
            //}
            //03
            //var SortPrice = ProductList.OrderBy(p => p.UnitPrice);
            //foreach (var product in SortPrice)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice:C2}");
            //}
            //04
            //var GetProducts = ProductList.Where(p => p.UnitPrice > 10 && p.UnitPrice < 30);
            //foreach (var product in GetProducts)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}, Unit Price: {product.UnitPrice:C2}");
            //}
            //05
            //var result = ProductList.Where(p => p.Category== "Spices & Condiments" && p.UnitsInStock>0);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //06
            //var result = ProductList.Select(p => new
            //{ Name = p.ProductName, Price = p.UnitPrice, stockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock" });
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.Name}, Unit Price: {product.Price}, Stock Status: {product.stockStatus}");
            //}
            //07
            //var result = ProductList.Select(p => p.ProductName);
            //for (int i = 0; i < result.Count(); i++)
            //{
            //    Console.WriteLine($"Product {i+1}: {result.ElementAt(i)}");
            //}
            //08
            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}, Category: {product.Category}, Unit Price: {product.UnitPrice:C2}");
            //}
            //09
            //var result = ProductList.Where(p => p.Category == "Beverages").OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in result)
            //{
            //    Console.WriteLine($"Product Name: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //}
            //10
            //var result = from c in CustomerList
            //             from o in c.Orders
            //             where o.OrderDate.Year >= 1997
            //             select new { c.CustomerID, o.OrderDate };
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Customer ID: {item.CustomerID}, Order Date: {item.OrderDate:d}");
            //}
            //11
            //var result = ProductList.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    ProductName = p.ProductName
            //});

            //foreach (var p in result)
            //    Console.WriteLine($"{p.Position}. {p.ProductName}");
            //12
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(p=>p.Length).ThenBy(p=>p, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //13
            var result = Arr.Where(p => p.Length > 1 && char.ToLower(p[1]) == 'i').Reverse();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}
