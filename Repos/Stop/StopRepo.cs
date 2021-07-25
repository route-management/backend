using Entities.Models.Entities;
using IRepos.Stop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Stop
{
    public class StopRepo : IStopRepo
    {
        public bool CreateStop(TblStop stop)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblStops.Add(stop);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public bool DeleteStop(string id)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    var stop = ReadStopById(id);
                    context.TblStops.Remove(stop);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public List<TblStop> ReadAllStops()
        {
            var list = new List<TblStop>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.TblStops.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }

        public TblStop ReadStopById(string id)
        {
            var data = new TblStop();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    data = context.TblStops.Where((TblStop stop) => stop.Id == id) as TblStop;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return data;
        }

        public bool UpdStop(TblStop stop)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblStops.Update(stop);
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
