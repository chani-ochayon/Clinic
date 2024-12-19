using ClinicProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Core.Repositories
{
    public interface IDoctorRepositories
    {

        public IEnumerable<DoctorClass> GetDoctor();

        public DoctorClass AddDoctor(DoctorClass doctor);


        public DoctorClass GetDoctorById(int id); // פונקציה לקבלת רופא על פי מזהה
        public DoctorClass UpdateDoctor(DoctorClass doctor); // פונקציה לעדכון רופא
        public void DeleteDoctor(int id); // פונקציה למחיקת רופא




    }
}
