using Entities.Models.Dtos;
using Entities.Models.Schemas;
using IProviders.Route;
using IRepos.Route;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteManagement.Services
{
    public class RouteManager : IRouteManager
    {
        private readonly IRouteRepo routeRepo;

        public RouteManager(
            IRouteRepo routeRepo
            )
        {
            this.routeRepo = routeRepo;
        }

        public Response<List<RouteSchema>> GetRoutes()
        {
            var data = new Response<List<RouteSchema>>();
            try
            {
                var routeRepoList = routeRepo.ReadAllRoutes();
                data.Data = new List<RouteSchema>(routeRepoList.Cast<RouteSchema>());
            }
            catch (Exception ex)
            {
                data.errMsg = ex.Message;
            }

            return data;
        }
    }
}
