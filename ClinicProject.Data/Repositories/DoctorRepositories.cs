using ClinicProject.Core.Entities;
using ClinicProject.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Data.Repositories
{
    public class DoctorRepositories : IDoctorRepositories
    {

        private DataContext _context;
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
        public DoctorRepositories(DataContext context) 
        {
            _context = context;
        }

        public IEnumerable<DoctorClass> GetDoctor()
        {

            return _context.Doctors.Include(d => d.Routes);//    תקיןname לבדוק האם ה

        }

        public DoctorClass AddDoctor(DoctorClass doctor)
        {
            _context.Doctors.Add(doctor);
            _context.SaveChanges();
            return doctor;
        }



        public DoctorClass GetDoctorById(int id)
        {
            return _context.Doctors.SingleOrDefault(e => e.Id == id);
        }


        public DoctorClass UpdateDoctor(DoctorClass doctor)
        {

            var existingDoctor = _context.Doctors.Find(doctor.Id);

            if (existingDoctor == null)
            {
                throw new Exception("Doctor not found."); // טיפול במקרה שהרופא לא נמצא
            }

            existingDoctor.WorkHours = doctor.WorkHours;
                existingDoctor.Name = doctor.Name;
                existingDoctor.Foun = doctor.Foun;
                

            _context.SaveChanges();

            return doctor;
        }


        public void DeleteDoctor(int id)
        {

            var doctor = _context.Doctors.FirstOrDefault(e => e.Id == id);
            if (doctor == null)
            {
                throw new Exception("Doctor not found."); // טיפול במקרה שהרופא לא נמצא
            }

             _context.Doctors.Remove(doctor);
            _context.SaveChanges();

        }
    }//עצרתי פה יום חמישי ד כסלו
}
