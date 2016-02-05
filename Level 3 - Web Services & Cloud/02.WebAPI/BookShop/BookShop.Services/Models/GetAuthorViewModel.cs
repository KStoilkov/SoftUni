namespace BookShop.Services.Models
{
    using System.Collections.Generic;
    
    public class GetAuthorViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public IEnumerable<string> Books { get; set; }
    }
}