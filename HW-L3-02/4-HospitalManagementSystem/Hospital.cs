namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        public sealed class Hospital
        {
            private static readonly Hospital instance = new Hospital();
            

            private Hospital()
            {
                this.patients = new List<Patient>();
                this.doctors = new List<Doctor>();
                this.rooms = new List<Room>();
            }

            public static Hospital Instance
            {
                get
                {
                    return instance;
                }
            }

             List<Patient> patients { get; set; }
             List<Doctor> doctors { get;  set; }
             List<Room> rooms { get;  set; }



            public static void AddRoomToHospital(Room room)
            {
                instance.rooms.Add(room);
            }

            public static void AddDoctorToHospital(Doctor doctor)
            {
                instance.doctors.Add(doctor);
            }

            public static void AddPatientHospital(Patient patient)
            {
                instance.patients.Add(patient);
            }


            public void ShowRooms()
            {
                Console.WriteLine("---Hospitals's Rooms---");
                foreach (var room in rooms)
                {
                    Console.WriteLine($"Room: {room.RoomNumber}");
                }
            }


            public void ShowPatients()
            {
                Console.WriteLine("---Hospitals's Patients---");
                foreach (var patient in patients)
                {
                    Console.WriteLine($"Patient: {patient.Name}");
                }
            }


            public void ShowDoctors()
            {
                Console.WriteLine("---Hospitals's Rooms---");
                foreach (var doctor in doctors)
                {
                    Console.WriteLine($"doctor({doctor.Specialization}): {doctor.Name}");
                }
            }



            public void AdmitPatient(Patient patient)
            {
                patients.Add(patient);
            }

            public void DischargePatient(Patient patient)
            {
                patients.Remove(patient);
            }


        }
    }
}
