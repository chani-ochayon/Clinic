using ClinicProject.Core.Services;
using ClinicProject.Core.Entities;
using ClinicProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Service
{
    public class DoctorServise : IDoctorService
    {
        private IDoctorRepositories _doctorRepositories;

        public DoctorServise(IDoctorRepositories doctorRepositories)
        {
            _doctorRepositories = doctorRepositories;   
        }



        public IEnumerable<DoctorClass> GetDoctor() //שיננו לIEnumerable
        {

            return _doctorRepositories.GetDoctor();

        }



        public DoctorClass GetDoctorById(int id)// GetDoctorById
        {
            
            var doctor = _doctorRepositories.GetDoctorById(id);


            return doctor == null ? throw new Exception("Doctor not found.") : doctor;
        }



        public bool IsExist(DoctorClass doctor)//IsExist
        {
           
            return _doctorRepositories.GetDoctor().Contains(doctor);

        }

        

        public DoctorClass UpdateDoctor(DoctorClass doctor)//UpdateDoctor
        {
            if (!IsExist(doctor)) {
                throw new Exception("Doctor not found.");
            }
            _doctorRepositories.UpdateDoctor(doctor);
            return doctor;
        }

        public void DeleteDoctor(int id)
        {
           if(_doctorRepositories.GetDoctorById(id)!=null) 
                _doctorRepositories.DeleteDoctor(id);
        }

        public DoctorClass AddDoctor(DoctorClass doctor)
        {
            if (IsExist(doctor))
            {
                throw new Exception("Doctor is alredy exsist.");
            }
            _doctorRepositories.AddDoctor(doctor);
            return doctor;
        }
       

        /// ////////////לבדוק את הפונקציה הזו///////////



    }
}
