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
        bool CreatePilot(TblRoute route);

        TblRoute ReadRouteById(string id);

        List<TblPilot> ReadAllPilots();

        bool UpdPilot(TblPilot pilot);

        bool DeletePilot(Guid id);
    }
}
