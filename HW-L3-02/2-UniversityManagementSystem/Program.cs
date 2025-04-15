using System.Xml.Linq;

namespace _2_UniversityManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            Professor martin = new Professor(
                name: "martin",
                age: 45,
                professorID: 4234,
                subject: "ComputerSience"
                );

            persons.Add(martin);


            Student jacob = new Student(
                name: "jacob",
                age: 24,
                studentID: 3453,
                major: "ComputerSience"
                );
            persons.Add(jacob);


            foreach(var person in persons)
            {
                person.GetDetail();
                Console.WriteLine();
            }

        }

        class Person
        {
            public int Age { get; set; }
            public string Name { get; set; }

            public virtual void GetDetail()
            {
                Console.WriteLine(
                    $"Name: {Name}\n" +
                    $" Age: {Age}");
            }

        }

        class Student : Person
        {
            public int StudentID { get; set; }
            public string Major { get; set; }

            public override void GetDetail()
            {
                Console.WriteLine(
                    $"\"Name: {Name} \n" +
                    $" Age: {Age} \n" +
                    $" Student ID: {StudentID} \n" +
                    $" Major{Major}:");
            }

            public Student(string name, int age, int studentID, string major)
            {
                this.Name = name;
                this.Age = age;
                this.StudentID = studentID;
                this.Major = major;
            }
        }

        class Professor : Person
        {
            public int ProfessorID { get; set; }
            public string Subject { get; set; }


            public Professor(string name, int age, int professorID, string subject)
            {
                this.Name = name;
                this.Age = age;
                this.ProfessorID = professorID;
                this.Subject = subject;
            }

            public override void GetDetail()
            {
                Console.WriteLine(
                    $"\"Name: {Name} \n" +
                    $" Age: {Age} \n" +
                    $" Professor ID: {ProfessorID} \n" +
                    $" Subject: {Subject}");
            }
        }

    }
}
