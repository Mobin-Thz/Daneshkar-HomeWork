namespace _2_Input_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name: ");
            string name = Console.ReadLine();

            Console.Write("Your age: ");
            string temp = Console.ReadLine();
            int age = int.Parse(temp);

            Console.Clear();
            Console.WriteLine($"Hi, {name}. You are {age} years old. ");
            Console.ReadKey();

        }
    }
}
