namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        public sealed class Hospital
        {
            private static readonly Hospital instance = new Hospital();

            private Hospital()
            {
                Patients = new List<Patient>();
                Doctors = new List<Doctor>();
            }

            public static Hospital Instance
            {
                get
                {
                    return instance;
                }
            }

            public List<Patient> Patients { get;private set; }
            public List<Doctor> Doctors { get; private set; }




            public void AdmitPatient(Patient patient)
            {
                Patients.Add(patient);
            }

            public void DischargePatient(Patient patient)
            {
                Patients.Remove(patient);
            }

        }
    }
}
