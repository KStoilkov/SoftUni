namespace ProductsShop.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        private ICollection<Product> productsBuyed;
        private ICollection<Product> productsSold;
        private ICollection<User> friends;

        public User()
        {
            this.productsBuyed = new HashSet<Product>();
            this.productsSold = new HashSet<Product>();
        }

        [Key]
        public int Id { get; set; }
        
        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        public string LastName { get; set; }

        public int? Age { get; set; }

        public virtual ICollection<Product> ProductsBuyed
        {
            get { return this.productsBuyed; }
            set { this.productsBuyed = value; }
        }

        public virtual ICollection<Product> ProductsSold
        {
            get { return this.productsSold; }
            set { this.productsSold = value; }
        }

        public virtual ICollection<User> Friends
        {
            get { return this.friends; }
            set { this.friends = value; }
        }

    }
}
