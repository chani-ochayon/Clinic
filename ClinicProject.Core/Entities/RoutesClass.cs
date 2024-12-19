using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Entities
{
    public class RoutesClass
    {

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        
     
      /// ////////////////
     
        public DoctorClass doctor { get; set; }
        public PatientClass patient { get; set; }

       

    }
}
