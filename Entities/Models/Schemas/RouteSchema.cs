using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Schemas
{
    public class RouteSchema
    {
        public Guid Id { get; set; }

        public string StartPoint { get; set; }

        public string EndPoint { get; set; }

        public string Data { get; set; }

        public bool? Disabled { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime? ModifyDate { get; set; }
    }
}
