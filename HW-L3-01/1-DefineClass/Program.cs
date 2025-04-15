namespace _1_DefineClass
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Student student1 = new Student("Mobin",23);
            student1.introduce();

            Console.ReadKey();


        }
    }

    public class Student
    {
        private int age; //{ get; set; }
        private string name; //{ get; set; }

        public int Age
        {
            get
            {
                return age; 
            }

            set
            {
                age = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }


        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void introduce()
        {
            Console.WriteLine($"Hello, my name is {name} and i am {age} years old");
        }
    }
}
