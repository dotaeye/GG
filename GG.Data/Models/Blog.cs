using System;
using SQ.Core.Data;
using SQ.Core.DTO;

namespace GG.Data.Models
{
    public partial class Blog : BaseEntity
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime LastTime { get; set; }
        public int BlogTypeId { get; set; }
        public string UserId { get; set; }
        public string Url { get; set; }

        [DTO(false)]
        public bool Deleted { get; set; }

        [DTO("BlogTypeName", "CateName")]
        public virtual BlogType BlogType { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
