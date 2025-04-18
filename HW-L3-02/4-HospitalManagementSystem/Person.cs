namespace _4_HospitalManagementSystem
{
    internal partial class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int NationalID { get; set; }

            public Person(string name, int age, int nationid)
            {
                this.Name = name;
                this.Age = age;
                this.NationalID = nationid;
                
            }

            public void GetDetails()
            {
                Console.WriteLine("----Person Details---" +
                    $"Name: {Name}" +
                    $"Age: {Age}" +
                    $"NationID:: {NationalID}");
            }
        }
    }
}
