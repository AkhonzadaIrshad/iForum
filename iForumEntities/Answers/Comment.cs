using System;
using iForumEntities.Posts;
using iForumEntities.Users;
using iInfrastructure.Entities;

namespace iForumEntities.Answers
{
    public class Comment : iEntity
    {
        public         int      Id          { get; set; }
        public         string   Title       { get; set; }
        public         string   Description { get; set; }
        public         DateTime CommentedOn { get; set; }
        public int AnswerId { get; set; }
        public virtual Answer Answer { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
        public         int  UserId { get; set; }
        public virtual User User   { get; set; }
    }
}