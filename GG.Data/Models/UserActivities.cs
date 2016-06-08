using System;
using System.Collections.Generic;
using SQ.Core.Data;
using SQ.Core.DTO;

namespace GG.Data.Models
{

    public partial class UserActivities : BaseEntity
    {
        public System.DateTime Time { get; set; }
        public string UserId { get; set; }

        [DTO(false)]
        public bool Deleted { get; set; }

        public UserActivityType Type { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }
    }
}
