using Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepos.Route
{
    public interface IRouteRepo
    {
        bool CreateRoute(TblRoute route);

        TblRoute ReadRouteById(string id);

        List<TblRoute> ReadAllRoutes();

        bool UpdRoute(TblRoute route);

        bool DeleteRoute(string id);
    }
}
