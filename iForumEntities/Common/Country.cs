using System.Collections.Generic;
using iInfrastructure.Entities;

namespace iForumEntities.Common
{
    public class Country : iEntity
    {
        public         int                   Id        { get; set; }
        public         string                Name      { get; set; }
        public virtual ICollection<Province> Provinces { get; set; }
    }
}