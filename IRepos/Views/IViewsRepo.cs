using Entities.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRepos.Views
{
    public interface IViewsRepo
    {
        List<VwTrainsNotAssignedToRoute> GetTrainsNotAssignedToRoutes();
    }
}
