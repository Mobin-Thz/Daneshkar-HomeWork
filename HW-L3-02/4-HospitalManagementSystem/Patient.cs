namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        public class Patient : Person
        {
            public int PatientID { get; set; }
            public List<string> MedicalHistory { get; set; } 

            public Patient(string name,int age, int nationid, int patientid,List<string>? medicalhistoty= null): base(name, age, nationid) 
            {
                this.Name = name;
                this.Age = age;
                this.NationalID = nationid;
                this.PatientID = patientid;
                this.MedicalHistory = medicalhistoty ?? new List<string>() ;
            }


            public void AddToMedicalHistory(string disease)
            {
                MedicalHistory.Add(disease);
            }

            public void ShowMedicalHistory()
            {
                Console.WriteLine($"---{this.Name}'s Medical History---");
                foreach (string disease in MedicalHistory)
                {
                    Console.WriteLine(disease);
                }
            }
        }
    }
}
