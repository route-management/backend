using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class TblRouteTrain
    {
        public TblRouteTrain()
        {
            TblRouteTrainStops = new HashSet<TblRouteTrainStop>();
        }

        public string Id { get; set; }
        public string RouteId { get; set; }
        public string TrainId { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual TblRoute Route { get; set; }
        public virtual TblTrain Train { get; set; }
        public virtual ICollection<TblRouteTrainStop> TblRouteTrainStops { get; set; }
    }
}
