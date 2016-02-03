namespace BookShop.Services.Controllers
{
    using BookShop.Models;
    using Data;
    using System.Linq;
    using System.Web.Http;
    using System.Web.OData;

    [RoutePrefix("api/categories")]
    public class CategoriesController : ApiController
    {
        private BookShopContext context;

        public CategoriesController()
        {
            this.context = new BookShopContext();
        }

        [HttpGet]
        [EnableQuery]
        public IHttpActionResult GetCategories()
        {
            var categories = context.Categories
                .Select(c => new
                {
                    Id = c.Id,
                    Name = c.Name
                });

            return this.Ok(categories);
        }

        [HttpGet]
        public IHttpActionResult GetCategory(int id)
        {
            var category = context.Categories
                .FirstOrDefault(c => c.Id == id);

            if (category == null)
            {
                return this.BadRequest("Category doesn't exist.");
            }

            return this.Ok(new { Id = category.Id, Name = category.Name });
        }

        [HttpPut]
        [Route("{id}")]
        public IHttpActionResult PutCategory(int id, [FromUri]string name)
        {
            var category = context.Categories.Find(id);
            
            if (category == null)
            {
                return this.BadRequest("Category doesn't exist.");
            }

            var categoryName = context.Categories.FirstOrDefault(c => c.Name == name);

            if (categoryName != null)
            {
                return this.BadRequest("Category " + name + " already exists.");
            }

            category.Name = name;
            context.SaveChanges();

            return this.Ok(new { Id = category.Id, Name = category.Name});
        }

        [HttpDelete]
        [Route("{id}")]
        public IHttpActionResult DeleteCategory(int id)
        {
            var category = context.Categories.Find(id);

            if (category == null)
            {
                return this.BadRequest("Category doesn't exist.");
            }

            context.Categories.Remove(category);
            context.SaveChanges();

            return this.Ok("Category deleted successfully.");
        }

        [HttpPost]
        public IHttpActionResult PostCategory([FromUri]string name)
        {
            bool checkCategory = context.Categories
                .FirstOrDefault(c => c.Name == name) != null;

            if (checkCategory)
            {
                return this.BadRequest("Category " + name + " already exists.");
            }

            var category = new Category()
            {
                Name = name
            };

            context.Categories.Add(category);
            context.SaveChanges();

            var newCategory = context.Categories
                .FirstOrDefault(c => c.Name == name);

            return this.Ok(new { Id = newCategory.Id, Name = newCategory.Name});
        }
    }
}
