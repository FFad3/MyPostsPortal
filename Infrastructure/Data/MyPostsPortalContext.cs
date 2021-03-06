using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MyPostsPortalContext : DbContext
    {
        public MyPostsPortalContext(DbContextOptions options) : base(options) { }

        //Accounts          
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountDetails> AccountDetails { get; set; }

        //Posts
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostContent> PostContents{ get; set; }

        //Others
        public DbSet<Comment> Comments{ get; set; }
        public DbSet<Opinion> Opinions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
    
}
