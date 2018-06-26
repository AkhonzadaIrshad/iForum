using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iForumEntities.Users
{
    public class ProfileImage
    {
        [Key]
        [ForeignKey("Profile")]
        public int Id { get; set; }

        public virtual Profile Profile { get; set; }

        public string Url     { get; set; }
        public string Caption { get; set; }

    }
}