using ClinicProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Services
{
   public interface IDoctorService
    {
        public IEnumerable<DoctorClass> GetDoctor();//V

        public DoctorClass AddDoctor(DoctorClass doctor);//V

      

        public  DoctorClass GetDoctorById(int id); // פונקציה לקבלת רופא על פי מזהה

        public DoctorClass UpdateDoctor(DoctorClass doctor); // פונקציה לעדכון רופא

        public void DeleteDoctor(int id); // פונקציה למחיקת רופא

        public bool IsExist(DoctorClass value);//V
       
        // IEnumerable<DoctorClass> SearchDoctors(string searchTerm); // פונקציה לחיפוש רופאים







    }
}
