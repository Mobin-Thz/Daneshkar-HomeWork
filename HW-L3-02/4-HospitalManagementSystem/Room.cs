using System.Xml;

namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        public class Room
        {
            public int RoomNumber { get; }
            public int Capacity { get; set; }
            public List<Patient> Patients { get; set; }

            public Room(int roomnumber, int capacity, List<Patient>? patient = null)
            {
                this.RoomNumber = roomnumber;
                this.Capacity = capacity;
                this.Patients = patient ?? new List<Patient>();
                Hospital.AddRoomToHospital(this);
            }

            public bool HasAvailableCapacity()
            {
                return this.Patients.Count < this.Capacity;
            }


            public void ShowPatients()
            {
                Console.WriteLine("Patients List:");
                foreach (var patient in this.Patients)
                {
                    Console.WriteLine(patient.Name);
                }
            }

            public void AssignPatient(Patient patient)
            {
                try
                {
                    if (this.HasAvailableCapacity() == false)
                    {
                        throw new InvalidOperationException($"The room {RoomNumber} is full");
                    }

                    Patients.Add(patient);
                    Console.WriteLine($"Patient {patient.Name} Added to Room number {RoomNumber} succesfully!");
                }

                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }


            }
        }
    }
}
