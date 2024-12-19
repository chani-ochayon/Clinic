using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Entities
{
    public class PatientClass
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Adress{ get; set; }

        public string fone { get; set; }
       
        /// ////////////////////
     
        public List<DoctorClass> Doctors { get; set; }
        public List<RoutesClass> Routes { get; set; }
        public PatientClass()
        {
        }

    }
}
