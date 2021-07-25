using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class VwTrainsNotAssignedToRoute
    {
        public string Id { get; set; }
        public string Code { get; set; }
        public DateTime CreateDate { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string PilotId { get; set; }
    }
}
