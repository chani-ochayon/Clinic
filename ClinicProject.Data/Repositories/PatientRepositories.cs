using ClinicProject.Core.Entities;
using ClinicProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Data.Repositories
{
    //לשנות לאינם 
    public class PatientRepositories : IPatientRepositories
    {
        private DataContext _context;
        public PatientRepositories(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<PatientClass> GetPatients()
        {
            return _context.Patients.Where(p => !string.IsNullOrEmpty(p.Name));
        }

        public PatientClass Addpatient(PatientClass patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
            return patient;
        }

        public PatientClass Updatepatient(PatientClass patient)
        {
            var existToUpdate = _context.Patients.Find(patient.Id);
            if (existToUpdate == null)
            {
                throw new Exception("patient not found");
            }
            _context.Patients.Update(patient);
            _context.SaveChanges();
            return patient;

        }

        public void Deletepatient(int id)
        {
            var existToUpdate = _context.Patients.FirstOrDefault(p=> p.Id==id);
            if (existToUpdate == null)
            {
                throw new Exception("patient to delite not found");
            }
            _context.Patients.Remove(existToUpdate);
            _context.SaveChanges();
           
        }

        public PatientClass GetpatientById(int id)
        {
            return _context.Patients.SingleOrDefault(p => p.Id == id);

        }
    }
}
