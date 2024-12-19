using ClinicProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Repositories
{
    public interface IRoutesRepositories
    {
        public IEnumerable<RoutesClass> GetRoutes();

        public RoutesClass AddRoute(RoutesClass route);
        public void DeliteRoute(RoutesClass route);
    
        public RoutesClass GetRouteById(int id);
        public RoutesClass UpdateRoute(RoutesClass route);
    }
}
