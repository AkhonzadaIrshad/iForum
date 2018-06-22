using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iForumEntities.Common;
using iInfrastructure.Entities;

namespace iForumEntities.Questions
{
    public class Question : iEntity 
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime AskedOn { get; set; }
        public DateTime ResolvedOn { get; set; }
    }
}
