using Cinic_Project.Entities;
using ClinicProject.Entities;

namespace ClinicProject
{
    public class DataContext
    {


       public List<DoctorClass> Doctors { get; set; }
        public List<PatientClass> Patients { get; set; }
        public List<RoutesClass> routes { get; set; }


        public DataContext()
        {
            Doctors = new List<DoctorClass> {
             new DoctorClass { Name="ARIEL",Id=1,Foun="0588888888",WorkHours=0},
              new DoctorClass { Name="efraim",Id=2,Foun="058222288",WorkHours=0}
            };



            Patients = new List<PatientClass> {

                  new PatientClass{ Id=1,Name="Elisheva" ,Age=5,Mail="elish@gmail.com"},
                  new PatientClass{Id=2,Name="aviva" ,Age=10,Mail="aviva@gmail.com" }
            };



            routes = new List<RoutesClass> {
             new RoutesClass{TimeStart = "07:10",TimeEnd="16:30",PatientId=1,DoctorId=1 },
             new RoutesClass{TimeStart = "16:30",TimeEnd="20:30",PatientId=2,DoctorId=2 }

             };


        }
    }
}


     
          
        
       
     


    
