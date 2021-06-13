using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shared_Traveling.Entities
{
    public class Request : BaseEntity
    {
        public int TravelPostId { get; set; }
        public string Content { get; set; }

        [ForeignKey("TravelPostId")]
        public TravelPost ParentPost { get; set; }

    }
}
