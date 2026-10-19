using static LINQ01.Source;
namespace LINQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            //var result = ProductList.OrderByDescending(p=>p.UnitPrice).Take(3);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            //2
            //var result = ProductList.Skip(5).Take(5);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            //3
            //var result = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p=>p.UnitPrice<25);
            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            //4
            //var result = ProductList.Where(p=>p.Category == "SeaFood").Any(p=>p.UnitsInStock==0);
            //Console.WriteLine($"do any SeaFood have 0 units in stock: {result}");
            //5
            //int[] ids = { 3, 9, 13, 18 };
            //var result = ids.Contains(9);
            //Console.WriteLine($"does the array contain 9: {result}");
            //6
            //var result = ProductList.GroupBy(p => p.Category);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key} Count: {group.Count()}");
            //}
            //7
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  {product.ProductName}");
            //    }
            //}
            //8
            //var result = ProductList.GroupBy(p => p.Category).Where(g => g.Count() > 3);

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Key);
            //}
            //9
            //var result = from c in CustomerList
            //             group c by c.Country into g
            //             select new { Country = g.Key, Count = g.Count(), TotalOrder = g.Sum(c => c.Orders.Sum(o => o.Total)) };
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Country: {group.Country} Count: {group.Count} Total: {group.TotalOrder}");
            //}
            //10
            //var result = ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine($"Total units in stock: {result}");
            //11
            //var cheapest = ProductList.Min(p => p.UnitPrice);
            //var expensive = ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine($"Cheapest product: {cheapest}");
            //Console.WriteLine($"Most expensive product: {expensive}");
            //12
            //var result = ProductList.Select(p=>p.Category).Distinct();
            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}
            //13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var result = setA.Except(setB);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };
            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //15
            //Dictionary<int, Product> result = ProductList
            //.ToDictionary(p => p.ProductID);

            //if (result.TryGetValue(18, out Product product))
            //    Console.WriteLine(product.ProductName);
            //16
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice < 50);
            //Console.WriteLine(result);
            //17
            //var result = ProductList.FirstOrDefault(p => p.UnitPrice > 500);
            //Console.WriteLine(result);
            //18
            //var result = Enumerable.Range(1, 10)
            //.Select(i => $"7 x {i} = {7 * i}");

            //foreach (var item in result)
            //    Console.WriteLine(item);
            //19
            //var result = Enumerable.Range(1, 30).Where(s => s % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //20
            //var result = ProductList.Take(3).Select(p => p.ProductName).Concat(CustomerList.Take(3).Select(c => c.CustomerName));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //21
            var result = ProductList
            .Zip(CustomerList, (p, c) =>
            $"{p.ProductName} sold to {c.CustomerName}");

            foreach (var item in result)
                Console.WriteLine(item);

        }
    }
}
