namespace ProductsShop.ConsoleClient
{
    using Data;
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
    public class ProductsShopMain
    {
        static void Main()
        {
            var context = new ProductsShopContext();

            var serializer = new JavaScriptSerializer();

            // Problem 3
            // Query 1
            // ProductsInRange(context, serializer);

            // Query 2
            // SuccessfullySoldProducts(context, serializer);

            // Query 3
            //CategoriesByProductsCount(context, serializer);
        }

        private static void CategoriesByProductsCount(ProductsShopContext context, JavaScriptSerializer serializer)
        {
            var categories = context.Categories
                .Select(c => new
                {
                    Name = c.Name,
                    ProductsCount = c.Products.Count,
                    AveragePrice = c.Products.Average(p => (decimal?)p.Price) ?? 0,
                    TotalPrice = c.Products.Sum(p => (decimal?)p.Price) ?? 0
                })
                .OrderByDescending(c => c.ProductsCount);
            
            var categoriesJson = serializer.Serialize(categories);

            File.WriteAllText("../../../Query-3.CategoriesByProductsCount.json", categoriesJson);
        }

        private static void SuccessfullySoldProducts(ProductsShopContext context, JavaScriptSerializer serializer)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    ProductsSold = u.ProductsSold
                                   .Where(ps => ps.Buyer != null)
                                   .Select(ps => new
                                   {
                                       Name = ps.Name,
                                       Price = ps.Price,
                                       buyerFirstName = ps.Buyer.FirstName,
                                       buyerLastName = ps.Buyer.LastName
                                   })
                })
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName);

            var usersJson = serializer.Serialize(users);

            File.WriteAllText("../../../Query-2.SuccessfullySoldProducts.json", usersJson);
        }

        public static void ProductsInRange(ProductsShopContext context, JavaScriptSerializer serializer)
        {
            var products = context.Products
                .Where(p => p.Buyer == null && (p.Price > 500 && p.Price < 1000))
                .Select(p => new
                {
                    Name = p.Name,
                    Price = p.Price,
                    Seller = p.Seller.FirstName + " " + p.Seller.LastName
                })
                .OrderBy(p => p.Price)
                .ToList();
            
            string productsJson = serializer.Serialize(products);
            
            File.WriteAllText(@"../../../Query-1.productsInRange.json", productsJson);
        }


    }
}
