namespace _3_UsingOutRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Statistics statistics = new Statistics();
            Console.WriteLine("Enter number1: ");
            string temp1 = Console.ReadLine();
            int number1 = int.Parse(temp1);
            

            Console.WriteLine("Enter number2: ");
            string temp2 = Console.ReadLine();
            int number2 = int.Parse(temp2);
            

            Console.WriteLine("Enter number3: ");
            string temp3 = Console.ReadLine();
            int number3 = int.Parse(temp3);
            

            statistics.AnalyzeNumbers(number1 ,ref number2,out number3);

            Console.ReadKey();

        }
        public class Statistics
        {

            public void AnalyzeNumbers(int number1, ref int number2, out int number3)
            {
                number3 = number1 + number2;
                number2 = number2*number2;

                Console.WriteLine($"number1: {number1}");
                Console.WriteLine($"number2: {number2}");
                Console.WriteLine($"number3: {number3}");

            }
        }
    }
}
