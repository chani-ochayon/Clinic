using ClinicProject.Core.Entities;
using ClinicProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Data.Repositories
{
    public class RoutesRepositories : IRoutesRepositories
    {
        private DataContext _context;

        public RoutesRepositories(DataContext context)
        {
            _context = context;
        }


        public IEnumerable<RoutesClass> GetRoutes()
        {
            return _context.routes.Where(p => p.PatientId != 0);
        }


        public RoutesClass AddRoute(RoutesClass route)
        {
            _context.routes.Add(route);
            _context.SaveChanges();
            return route;
        }

        public void DeliteRoute(RoutesClass route)
        {
            var routToDelite = _context.routes.Find(route);
            if (routToDelite == null)
            {
                throw new Exception("route to delite not found");

            }
            _context.routes.Remove(route);
            _context.SaveChanges();


        }

            public RoutesClass GetRouteById(int id)
            {

            throw new NotImplementedException();
        }
   

            public RoutesClass UpdateRoute(RoutesClass route)
            {
                throw new NotImplementedException();
            }
        }

    }