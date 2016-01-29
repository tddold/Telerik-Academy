namespace _02.WebChat.Models
{
    using System.Data.Entity;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class WebChatDbContext : IdentityDbContext<User>
    {
        public WebChatDbContext()
            : base("WebChatConnection", throwIfV1Schema: false)
        {
        }

        public static WebChatDbContext Create()
        {
            return new WebChatDbContext();
        }

        public IDbSet<Message> Messages { get; set; }
    }
}