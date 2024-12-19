using ClinicProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.DTOs
{
    public class DoctorDTOs
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Foun { get; set; }
        public double WorkHours { get; set; }

        /// ////////////////
        public List<RoutesClass> Routes { get; set; }

    }
}
