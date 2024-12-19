using ClinicProject.Core.Entities;
using ClinicProject.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicProject.Core.Repositories;


namespace ClinicProject.Service
{
    public class PatientService : IPatientService
    {
       private IPatientRepositories _PatientRepositories;

        public PatientService( IPatientRepositories PatientRepositories)
        {
            _PatientRepositories = PatientRepositories;
        }

        public IEnumerable<PatientClass> GetPatients()
        {
            return _PatientRepositories.GetPatients();
        }

        public PatientClass Addpatient(PatientClass patient)
        {
            _PatientRepositories.Addpatient(patient);
            return patient;
        }

      

        public bool IsExist(PatientClass patient)
        {
            return _PatientRepositories.GetPatients().Contains(patient);
        }




        public PatientClass Updatepatient(PatientClass patient)
        {
            if (patient == null || !IsExist(patient))
            {

                throw new Exception("patient not found");
            }
            _PatientRepositories.Updatepatient(patient);
            return patient;
            
        }

      

        public void Deletepatient(int id)
        {
           if(_PatientRepositories.GetpatientById(id)!= null) 
                _PatientRepositories.Deletepatient(id);
          
        }

        public PatientClass GetpatientById(int id)
        {
            var p = _PatientRepositories.GetpatientById(id);
            return (p == null ? throw new Exception("patient not exists") : p);
        }
    }
}
