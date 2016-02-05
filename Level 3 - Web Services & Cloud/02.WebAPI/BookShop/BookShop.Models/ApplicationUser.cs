namespace BookShop.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class ApplicationUser : IdentityUser
    {
        private ICollection<Purshase> purshases;

        public ApplicationUser()
        {
            this.purshases = new HashSet<Purshase>();
        }

        public virtual ICollection<Purshase> Purshases
        {
            get { return this.purshases; }
            set { this.purshases = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(
            UserManager<ApplicationUser> manager,
            string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            return userIdentity;
        }
    }
}
