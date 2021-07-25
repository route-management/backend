using Entities.Models.Entities;
using IRepos.RouteTrain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.RouteTrain
{
    public class RouteTrainRepo : IRouteTrainRepo
    {
        public bool CreateRouteTrain(TblRouteTrain routeTrain)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblRouteTrains.Add(routeTrain);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public bool DeleteRouteTrain(string id)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    var routeTrain = ReadRouteTrainById(id);
                    context.TblRouteTrains.Remove(routeTrain);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public List<TblRouteTrain> ReadAllRouteTrains()
        {
            var list = new List<TblRouteTrain>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.TblRouteTrains.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }

        public TblRouteTrain ReadRouteTrainById(string id)
        {
            var data = new TblRouteTrain();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    data = context.TblRouteTrains.Where((TblRouteTrain routeTrain) => routeTrain.Id == id) as TblRouteTrain;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return data;
        }

        public bool UpdRouteTrain(TblRouteTrain routeTrain)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblRouteTrains.Update(routeTrain);
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
