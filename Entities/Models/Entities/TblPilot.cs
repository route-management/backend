using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class TblPilot
    {
        public TblPilot()
        {
            TblTrains = new HashSet<TblTrain>();
        }

        public string Id { get; set; }
        public string FullName { get; set; }
        public string StaffId { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual ICollection<TblTrain> TblTrains { get; set; }
    }
}
