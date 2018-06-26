using iForumEntities.Answers;
using iForumEntities.Common;
using iForumEntities.Posts;
using iForumEntities.Questions;
using iForumEntities.Users;
using Microsoft.EntityFrameworkCore;

namespace iForumAccess
{
    public class ForumContext : DbContext
    {
        public ForumContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfileImage> ProfileImages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
