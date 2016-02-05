namespace BookShop.Services.Models
{
    using System;

    public class PurshaseViewModel
    {   
        public decimal Price { get; set; }
        
        public DateTime DateOfPurshase { get; set; }

        public bool isRecalled { get; set; }
        
        public string User { get; set; }
    
        public string Book { get; set; }
    }
}