using System;
using System.Collections.Generic;

#nullable disable

namespace Entities.Models.Entities
{
    public partial class VwTrainStopsForRoute
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string EstimateArrivalTime { get; set; }
    }
}
