namespace BullsAndCows.Data.Models
{
    using System.Security.Claims;
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;

    public class User : IdentityUser
    {
        private ICollection<Guess> guesses;

        public User()
        {
            this.guesses = new HashSet<Guess>();
        }

        public int Rank { get; set; }

        public virtual ICollection<Guess> Guesses
        {
            get { return this.guesses; }
            set { this.guesses = value; }
        }


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager, string authenticationType)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, authenticationType);

            return userIdentity;
        }
    }
}
