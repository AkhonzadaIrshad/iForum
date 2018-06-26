using System;
using System.Collections.Generic;
using iForumEntities.Questions;
using iForumEntities.Users;
using iInfrastructure.Entities;

namespace iForumEntities.Answers
{
    public class Answer : iEntity
    {
        public         int                  Id          { get; set; }
        public         string               Title       { get; set; }
        public         string               Description { get; set; }
        public         DateTime             AnsweredOn  { get; set; }
        public         int                  QuestionId  { get; set; }
        public virtual Question             Question    { get; set; }
        public         int                  UserId      { get; set; }
        public virtual User                 User        { get; set; }
        public virtual ICollection<Comment> Comments    { get; set; }
    }
}