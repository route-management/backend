using Entities.Models.Entities;
using IRepos.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Route
{
    public class RouteRepo : IRouteRepo
    {
        public bool CreateRoute(TblRoute route)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblRoutes.Add(route);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public bool DeleteRoute(string id)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    var route = ReadRouteById(id);
                    context.TblRoutes.Remove(route);
                    result = context.SaveChanges() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return result;
        }

        public List<TblRoute> ReadAllRoutes()
        {
            var list = new List<TblRoute>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.TblRoutes.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }

        public TblRoute ReadRouteById(string id)
        {
            var data = new TblRoute();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    data = context.TblRoutes.Where((TblRoute route) => route.Id == id) as TblRoute;
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return data;
        }

        public bool UpdRoute(TblRoute route)
        {
            bool result = false;
            using (var context = new RouteManagementContext())
            {
                try
                {
                    context.TblRoutes.Update(route);
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
