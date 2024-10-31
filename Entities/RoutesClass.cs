namespace Cinic_Project.Entities
{
    public class RoutesClass
    {
        public DateTime Date { get; set; }
        public string TimeStart { get; set; }
        public string TimeEnd { get; set; }
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }

        public RoutesClass()
        {

        }


    }
}
