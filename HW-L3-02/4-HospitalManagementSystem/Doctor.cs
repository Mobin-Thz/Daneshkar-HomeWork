namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        public class Doctor : Person
        {
            public int DoctorID { get; set; }
            public string Specialization { get; set; }

            public Doctor(string name, int age, int nationid, int doctorid, string specialization ) : base(name, age, nationid)
            {
                this.DoctorID = doctorid;
                this.Specialization = specialization;
                Hospital.AddDoctorToHospital(this);
            }

            public void Diagnose(Patient patient, string disease)
            {
                patient.AddToMedicalHistory(disease);
            }
        }
    }
}
