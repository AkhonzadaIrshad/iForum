using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iForumEntities.Users;
using iInfrastructure.Entities;

namespace iForumEntities.Common
{
    public class Address:iEntity
    {
        [Key]
        [ForeignKey("User")]
        public int Id { get; set; }
        public virtual User User { get; set; }

        public string Street { get; set; }
        public int HouseNumber { get; set; }

        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
