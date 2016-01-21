namespace ProductsShop.Data.Migrations
{
    using Models;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Xml;
    using System.Web.Script.Serialization;
    using System.IO;
    using System;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductsShopContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ProductsShopContext context)
        {
            Random random = new Random();
            
            if (!context.Users.Any())
            {
                addUsers(context);
                addUsersFriends(context, random);
            }
            
            if (!context.Products.Any())
            {
                addProducts(context, random);
            }

            if (!context.Categories.Any())
            {
                addCategories(context, random);
            }
        }

        private void addUsers(ProductsShopContext context)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("../../../users.xml");

            string path = "/users/user";

            XmlNodeList users = doc.SelectNodes(path);

            foreach (XmlNode node in users)
            {
                string firstName = null;
                string lastName = null;
                int? age = null;

                if (node.Attributes["first-name"] != null)
                {
                    firstName = node.Attributes["first-name"].Value;
                }

                lastName = node.Attributes["last-name"].Value;

                if (node.Attributes["age"] != null)
                {
                    age = int.Parse(node.Attributes["age"].Value);
                }

                context.Users.Add(new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                });
            }

            context.SaveChanges();
        }

        private void addUsersFriends(ProductsShopContext context, Random random)
        {
            var users = context.Users.ToList();

            foreach (var user in users)
            {
                int randomUserFriends = random.Next(0, 10);
                for (int i = 0; i < randomUserFriends; i++)
                {
                    int[] usedIndexes = new int[randomUserFriends];
                    int randomUserFriendIndex = random.Next(0, users.Count);

                    if (!usedIndexes.Contains(randomUserFriendIndex))
                    {
                        user.Friends.Add(users[randomUserFriendIndex]);
                    }
                }
            }

            context.SaveChanges();
        }

        private void addProducts(ProductsShopContext context, Random random)
        {
            using (StreamReader sr = new StreamReader("../../../products.json"))
            {
                string productsJson = sr.ReadToEnd();
                var serializer = new JavaScriptSerializer();

                Product[] products = serializer.Deserialize<Product[]>(productsJson);

                var users = context.Users.ToList();

                foreach (var product in products)
                {
                    product.Seller = users[random.Next(0, users.Count)];
                    
                    int randomNumber = random.Next(0, 2);
                    if (randomNumber == 0)
                    {
                        product.Buyer = null;
                    }
                    else
                    {
                        product.Buyer = users[random.Next(0, users.Count)];
                    }

                    context.Products.Add(product);
                }

                context.SaveChanges();
            }
        }

        private void addCategories(ProductsShopContext context, Random random)
        {
            using (StreamReader sr = new StreamReader("../../../categories.json"))
            {
                var categoriesJson = sr.ReadToEnd();

                var serializer = new JavaScriptSerializer();

                Category[] categories = serializer.Deserialize<Category[]>(categoriesJson);

                var products = context.Products.ToList();

                foreach (var category in categories)
                {
                    int randomCategoryProductsCount = random.Next(0, 5);

                    for (int i = 0; i < randomCategoryProductsCount; i++)
                    {
                        category.Products.Add(products[random.Next(0, products.Count)]);
                    }

                    context.Categories.Add(category);
                }

                context.SaveChanges();
            }
        }

    }
}