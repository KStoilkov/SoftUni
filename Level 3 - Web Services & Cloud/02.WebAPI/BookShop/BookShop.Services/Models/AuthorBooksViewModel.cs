namespace BookShop.Services.Models
{
    using System;
    using System.Collections.Generic;

    public class AuthorBooksViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int? Copies { get; set; }

        public DateTime Edition { get; set; }

        public virtual IEnumerable<string> Categories { get; set; }
    }
}