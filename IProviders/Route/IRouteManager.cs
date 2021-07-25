using Entities.Models.Dtos;
using Entities.Models.Schemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IProviders.Route
{
    public interface IRouteManager
    {
        Response<List<RouteSchema>> GetRoutes();
    }
}
