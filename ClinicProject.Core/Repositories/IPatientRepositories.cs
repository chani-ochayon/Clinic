using ClinicProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Repositories
{
    public interface IPatientRepositories
    {
        public IEnumerable<PatientClass> GetPatients();

        public PatientClass Addpatient(PatientClass patient);

        public PatientClass Updatepatient(PatientClass patient);
        public void Deletepatient(int id);
        public PatientClass GetpatientById(int id);



    }
}
