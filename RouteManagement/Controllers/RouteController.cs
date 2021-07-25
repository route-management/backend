using IProviders.Route;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RouteManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RouteController : Controller
    {
        private readonly IRouteManager routeManager;

        public RouteController(
            IRouteManager routeManager
            )
        {
            this.routeManager = routeManager;
        }

        [HttpGet]
        [Route("[action]")]
        public IActionResult GetRoutes()
        {
            var data = routeManager.GetAllRoutes();
            return Ok(data);
        }
    }
}
