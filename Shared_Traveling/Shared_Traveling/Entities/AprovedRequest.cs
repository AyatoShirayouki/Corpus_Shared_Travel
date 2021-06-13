using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.Entities
{
    public class AprovedRequest : BaseEntity
    {
        public int UserId { get; set; }
        public int TravelPostId { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }

        [ForeignKey("TravelPostId")]
        public TravelPost ParentPost { get; set; }
    }
}
