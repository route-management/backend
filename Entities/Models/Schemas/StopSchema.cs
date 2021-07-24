using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Schemas
{
    public class StopSchema
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Data { get; set; }
        public bool? Disabled { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
