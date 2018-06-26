using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using iForumEntities.Answers;
using iForumEntities.Common;
using iForumEntities.Posts;
using iForumEntities.Questions;
using iInfrastructure.Entities;

namespace iForumEntities.Users
{
    public class Profile : iEntity
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }

        public virtual User   User  { get; set; }
        public         string About { get; set; }

        public DateTime DateOfBirth { get; set; }
        public float    Reputation  { get; set; }
        public int      Rank        { get; set; }


        public         int          ProfileImageId { get; set; }
        public virtual ProfileImage ProfileImage   { get; set; }
        public         int          AddressId      { get; set; }
        public virtual Address      Address        { get; set; }

    }
}