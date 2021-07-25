using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models.Dtos
{
    public class Response<T>
    {
        public T Data { get; set; }

        public string errMsg { get; set; }
    }
}
