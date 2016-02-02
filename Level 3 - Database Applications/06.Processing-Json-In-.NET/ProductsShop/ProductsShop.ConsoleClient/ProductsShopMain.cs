namespace ProductsShop.ConsoleClient
{
    using Data;
    using System;
    using System.IO;
    using System.Linq;
    using System.Web.Script.Serialization;
    using System.Xml.Linq;
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
            // CategoriesByProductsCount(context, serializer);

            // Query 4
            UsersAndProducts(context);
        }

        private static void UsersAndProducts(ProductsShopContext context)
        {
            var users = context.Users
                .Where(u => u.ProductsSold.Count > 0)
                .OrderByDescending(u => u.ProductsSold.Count)
                .ThenBy(u => u.LastName)
                .Select(u => new
                {
                    firstName = u.FirstName,
                    lastName = u.LastName,
                    age = u.Age,
                    products = u.ProductsSold
                    .Select(ps => new
                    {
                        name = ps.Name,
                        price = ps.Price
                    })
                });
            
            XElement usersElement = new XElement("users", new XAttribute("count", users.Count()));

            foreach (var user in users)
            {
                XElement userElement = new XElement("user");
                
                if (user.firstName != null)
                {
                    userElement.Add(new XAttribute("first-name", user.firstName));
                }

                userElement.Add(new XAttribute("last-name", user.lastName));

                if (user.age != null)
                {
                    userElement.Add(new XAttribute("age", user.age));
                }

                XElement soldProductsElement = new XElement("sold-products", new XAttribute("count", user.products.Count()));

                foreach (var product in user.products)
                {
                    XElement productElement = new XElement("product", 
                        new XAttribute("name", product.name),
                        new XAttribute("price", product.price));

                    soldProductsElement.Add(productElement);
                }

                userElement.Add(soldProductsElement);
                usersElement.Add(userElement);
            }

            usersElement.Save("../../../users-and-products.xml");
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
