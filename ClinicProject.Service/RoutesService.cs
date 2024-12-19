using ClinicProject.Core.Entities;
using ClinicProject.Core.Repositories;
using ClinicProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Service
{
    public class RoutesService : IRoutesService
    {
        private IRoutesRepositories _RoutesRepositories;
        public RoutesService(IRoutesRepositories RoutesRepositories)
        {
            _RoutesRepositories = RoutesRepositories;

        }

        public RoutesClass AddRoute(RoutesClass route)
        {
            _RoutesRepositories.AddRoute(route);
            return route;
        }

        public void DeliteRoute(RoutesClass route)
        {
            throw new NotImplementedException();
        }

        public RoutesClass GetRouteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoutesClass> GetRoutes()
        {
          return _RoutesRepositories.GetRoutes();
        }

        public bool IsExist(RoutesClass value)
        {
           return _RoutesRepositories.GetRoutes().Contains(value);
        }

        public RoutesClass RemoveRoute(RoutesClass route)
        {
            throw new NotImplementedException();
        }

        public RoutesClass UpdateRoute(RoutesClass route)
        {
            throw new NotImplementedException();
        }
    }
}
