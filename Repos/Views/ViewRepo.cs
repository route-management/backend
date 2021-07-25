using Entities.Models.Entities;
using IRepos.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repos.Views
{
    public class ViewRepo : IViewsRepo
    {
        public List<VwTrainsNotAssignedToRoute> GetTrainsNotAssignedToRoutes()
        {
            var list = new List<VwTrainsNotAssignedToRoute>();
            using (var context = new RouteManagementContext())
            {
                try
                {
                    list = context.VwTrainsNotAssignedToRoutes.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message, ex);
                }
            }

            return list;
        }
    }
}
