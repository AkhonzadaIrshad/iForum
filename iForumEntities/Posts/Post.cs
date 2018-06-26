using System;
using System.Collections.Generic;
using iForumEntities.Answers;
using iForumEntities.Users;
using iInfrastructure.Entities;

namespace iForumEntities.Posts
{
    public class Post : iEntity
    {
        public         int      Id          { get; set; }
        public         string   Title       { get; set; }
        public         string   Description { get; set; }
        public         DateTime PostedOn    { get; set; }
        public         PostType PostType    { get; set; }
        public         int      UserId      { get; set; }
        public virtual User     User        { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}