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

            public Room(int roomnuber, int capacity, List<Patient>? patient = null)
            {
                this.RoomNumber = roomnuber;
                this.Capacity = capacity;
                this.Patients = patient ?? new List<Patient>();
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
                    if (this.Patients.Count >= this.Capacity)
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
