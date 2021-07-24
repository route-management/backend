using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class TblTrain
    {
        public TblTrain()
        {
            TblRouteTrains = new HashSet<TblRouteTrain>();
        }

        public string Id { get; set; }
        public string Code { get; set; }
        public string PilotId { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual TblPilot Pilot { get; set; }
        public virtual ICollection<TblRouteTrain> TblRouteTrains { get; set; }
    }
}
