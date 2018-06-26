using System.Collections.Generic;
using iForumEntities.Answers;
using iForumEntities.Posts;
using iForumEntities.Questions;
using iInfrastructure.Entities;

namespace iForumEntities.Users
{
    public class User : iEntity
    {
        public int    Id         { get; set; }
        public string FirstName  { get; set; }
        public string MiddleName { get; set; }
        public string LastName   { get; set; }
        public string Password   { get; set; }

        public         int     ProfileId { get; set; }
        public virtual Profile Profile   { get; set; }

        public virtual ICollection<Post>     Posts     { get; set; }
        public virtual ICollection<Question> Questions { get; set; }
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual ICollection<Comment>  Comments  { get; set; }
    }
}