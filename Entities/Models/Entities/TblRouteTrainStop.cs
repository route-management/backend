using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class TblRouteTrainStop
    {
        public string Id { get; set; }
        public string RouteTrainId { get; set; }
        public string StopId { get; set; }
        public string EstimateArrivalTime { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual TblRouteTrain RouteTrain { get; set; }
        public virtual TblStop Stop { get; set; }
    }
}
