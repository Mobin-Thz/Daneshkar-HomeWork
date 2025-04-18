namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Hospital MiladHospital = Hospital.Instance;


            Patient patient1 = new Patient(
                name: "patient1",
                age: 23,
                nationid: 00454596485,
                patientid: 1
                );

            patient1.AddToMedicalHistory("Flu");
            patient1.ShowMedicalHistory();


            Patient patient2 = new Patient(
                 name: "patient2",
                 age: 23,
                 nationid: 0045459564,
                 patientid: 2
                  );          

            Patient patient3 = new Patient(
                name: "patient3",
                age: 23,
                nationid: 00454594234,
                patientid: 3
                );

            Doctor reza = new Doctor(
                name: "reza ",
                age: 57,
                nationid: 0013255243,
                doctorid: 32,
                specialization: "GP"
                );

            Room room34 = new Room(
                roomnuber: 34,
                capacity: 2
                );

            room34.AssignPatient(patient1);
            room34.AssignPatient(patient2);
            room34.AssignPatient(patient3);

            room34.ShowPatients();

        }
    }
}
