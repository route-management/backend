using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Models.Entities;

namespace IRepos.Pilot
{
    public interface IPilotRepo
    {
        bool CreatePilot(TblPilot pilot);

        TblPilot ReadPilotById(string id);

        List<TblPilot> ReadAllPilots();

        bool UpdPilot(TblPilot pilot);

        bool DeletePilot(string id);
    }
}
