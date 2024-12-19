using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Entities
{
    public class DoctorClass
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Foun { get; set; }
        public string Email{ get; set; }
        public double WorkHours { get; set; }
 
        /// ////////////////

        public List<PatientClass> Patient { get; set; }
        public List<RoutesClass> Routes { get; set; }

    }
}
