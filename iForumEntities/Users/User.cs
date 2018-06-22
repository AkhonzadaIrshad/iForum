using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iForumEntities.Common;

namespace iForumEntities.Users
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public float Reputation { get; set; }

        public int ProfileImageId { get; set; }
        public virtual ProfileImage ProfileImage { get; set; }
        public int AddressId { get; set; }
        public virtual Address Address { get; set; }


    }
}
