﻿namespace BookShop.Services.Models
{
    using System;
    using System.Collections.Generic;
    
    public class GetBookViewModel
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int? Copies { get; set; }

        public int AuthorId { get; set; }

        public string AuthorName { get; set; }

        public DateTime Edition { get; set; }

        public virtual IEnumerable<string> Categories { get; set; }
    }
}