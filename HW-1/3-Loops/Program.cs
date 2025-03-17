using System.Security.Cryptography;

namespace _3_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Random secret number
            Random random = new Random();
            int secretNumber = random.Next(1, 10);
            Console.WriteLine(secretNumber);



            while (true)
            {
                for (int i = 1; i <= 5; i++)
                {


                    Console.WriteLine("Guess a number (1-10) :");
                    string temp1 = Console.ReadLine();
                    int guessed_number = int.Parse(temp1);

                    if (secretNumber == guessed_number)
                    {
                        Console.WriteLine("Congrats! you guessed the number");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Try again. ");

                    }
                }

                Console.WriteLine($"Sorry! you have used all of your attempts. The number is {secretNumber}");
                break;

            }


        }



    }
}
