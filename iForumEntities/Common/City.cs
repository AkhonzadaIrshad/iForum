using iInfrastructure.Entities;

namespace iForumEntities.Common
{
    public class City : iEntity
    {
        public         int      Id         { get; set; }
        public         string   Name       { get; set; }
        public         int      Code       { get; set; }
        public         int      ProvinceId { get; set; }
        public virtual Province Province   { get; set; }
    }
}