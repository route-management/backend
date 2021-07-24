using Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepos.Stop
{
    public interface IStopRepo
    {
        bool CreateStop(TblStop stop);

        TblStop ReadStopById(string id);

        List<TblStop> ReadAllStops();

        bool UpdStop(TblStop stop);

        bool DeleteStop(Guid id);
    }
}
