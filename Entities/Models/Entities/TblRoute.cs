using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class TblRoute
    {
        public TblRoute()
        {
            TblRouteTrains = new HashSet<TblRouteTrain>();
        }

        public string Id { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual ICollection<TblRouteTrain> TblRouteTrains { get; set; }
    }
}
