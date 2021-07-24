using Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepos.RouteTrainStop
{
    public interface IRouteTrainStopRepo
    {
        bool CreateRouteTrainStop(TblRouteTrainStop routeTrainStop);

        TblRouteTrainStop ReadRouteTrainStopById(string id);

        List<TblRouteTrainStop> ReadAllRouteTrainStops();

        bool UpdRouteTrainStop(TblRouteTrainStop routeTrainStop);

        bool DeleteRouteTrainStop(Guid id);
    }
}
