using iForumEntities.Users;
using Microsoft.EntityFrameworkCore;

namespace iForumAccess
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
