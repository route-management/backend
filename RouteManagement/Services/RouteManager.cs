using Entities.Models.Dtos;
using Entities.Models.Entities;
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

        public Response<List<RouteSchema>> GetAllRoutes()
        {
            var data = new Response<List<RouteSchema>>();
            try
            {
                var routeRepoList = routeRepo.ReadAllRoutes();
                data.Data = routeRepoList.Select((TblRoute route) => new RouteSchema
                {
                    Id = Guid.Parse(route.Id),
                    CreateDate = route.CreateDate,
                    Data = route.Data,
                    Disabled = route.Disabled,
                    EndPoint = route.EndPoint,
                    ModifyDate = route.ModifyDate,
                    StartPoint = route.StartPoint
                }).ToList();
            }
            catch (Exception ex)
            {
                data.errMsg = ex.Message;
            }

            return data;
        }
    }
}
