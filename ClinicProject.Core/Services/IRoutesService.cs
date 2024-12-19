using ClinicProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Services
{
    public interface IRoutesService
    {


        public IEnumerable<RoutesClass> GetRoutes();

        public RoutesClass AddRoute(RoutesClass route);
        bool IsExist(RoutesClass value);

        public void DeliteRoute(RoutesClass route);

        public RoutesClass GetRouteById(int id);
        public RoutesClass UpdateRoute(RoutesClass route);


    }
}
