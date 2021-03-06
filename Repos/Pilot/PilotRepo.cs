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

        public bool DeletePilot(string id)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    var pilot = ReadPilotById(id);
                    context.TblPilots.Remove(pilot);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public List<TblPilot> ReadAllPilots()
        {
            var list = new List<TblPilot>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.TblPilots.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }

        public TblPilot ReadPilotById(string id)
        {
            var data = new TblPilot();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    data = context.TblPilots.Where((TblPilot pilot) => pilot.Id == id) as TblPilot;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return data;
        }

        public bool UpdPilot(TblPilot pilot)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblPilots.Update(pilot);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }
    }
}
