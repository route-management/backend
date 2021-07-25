using Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepos.RouteTrain
{
    public interface IRouteTrainRepo
    {
        bool CreateRouteTrain(TblRouteTrain routeTrain);

        TblRouteTrain ReadRouteTrainById(string id);

        List<TblRouteTrain> ReadAllRouteTrains();

        bool UpdRouteTrain(TblRouteTrain routeTrain);

        bool DeleteRouteTrain(string id);
    }
}
