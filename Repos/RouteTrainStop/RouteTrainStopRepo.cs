using Entities.Models.Entities;
using IRepos.RouteTrainStop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.RouteTrainStop
{
    public class RouteTrainStopRepo : IRouteTrainStopRepo
    {
        public bool CreateRouteTrainStop(TblRouteTrainStop routeTrainStop)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblRouteTrainStops.Add(routeTrainStop);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public bool DeleteRouteTrainStop(string id)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    var routeTrainStop = ReadRouteTrainStopById(id);
                    context.TblRouteTrainStops.Remove(routeTrainStop);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public List<TblRouteTrainStop> ReadAllRouteTrainStops()
        {
            var list = new List<TblRouteTrainStop>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.TblRouteTrainStops.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }

        public TblRouteTrainStop ReadRouteTrainStopById(string id)
        {
            var data = new TblRouteTrainStop();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    data = context.TblRouteTrainStops.Where((TblRouteTrainStop routeTrainStop) => routeTrainStop.Id == id) as TblRouteTrainStop;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return data;
        }

        public bool UpdRouteTrainStop(TblRouteTrainStop routeTrainStop)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblRouteTrainStops.Update(routeTrainStop);
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
