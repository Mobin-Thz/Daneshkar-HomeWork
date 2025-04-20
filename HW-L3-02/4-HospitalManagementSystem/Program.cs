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

            Room room10 = new Room(
                roomnumber: 10,
                capacity: 2
                );

            Room room11 = new Room(
            roomnumber: 11,
            capacity: 2
             );
            Room room12 = new Room(
            roomnumber: 12,
            capacity: 2
             );
            Room room13 = new Room(
            roomnumber: 13,
            capacity: 2
            );




            MiladHospital.AdmitPatient(patient3);
            MiladHospital.AdmitPatient(patient2);
            MiladHospital.AdmitPatient(patient1);


            patient1.AddToMedicalHistory("Flu");
            reza.Diagnose(patient1,"Ashtma");
            patient1.ShowMedicalHistory();


            //room10.ShowPatients();

            MiladHospital.ShowRooms();
            MiladHospital.ShowPatients();
            MiladHospital.ShowDoctors();
            

        }
    }
}
