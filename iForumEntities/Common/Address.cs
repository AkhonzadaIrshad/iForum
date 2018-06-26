using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using iForumEntities.Users;
using iInfrastructure.Entities;

namespace iForumEntities.Common
{
    public class Address : iEntity
    {
        [Key]
        [ForeignKey("Profile")]
        public int Id { get; set; }

        public virtual Profile Profile { get; set; }

        public string Street      { get; set; }
        public int    HouseNumber { get; set; }

        public         int  CityId { get; set; }
        public virtual City City   { get; set; }
    }
}