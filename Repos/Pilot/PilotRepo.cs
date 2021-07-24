using Entities.Models.Entities;
using IRepos.Pilot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Pilot
{
    public class PilotRepo : IPilotRepo
    {
        public bool CreatePilot(TblPilot pilot)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblPilots.Add(pilot);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public bool DeletePilot(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<TblPilot> ReadAllPilots()
        {
            throw new NotImplementedException();
        }

        public TblPilot ReadPilotById(string id)
        {
            throw new NotImplementedException();
        }

        public bool UpdPilot(TblPilot pilot)
        {
            throw new NotImplementedException();
        }
    }
}
