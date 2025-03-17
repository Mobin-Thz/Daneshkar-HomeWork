namespace _4_GuessTheWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "csharp";

            //--------------------------------------------------------------------------------------------

            // using for loop
            //for (int i = 0;i >= 0; i++)
            //{
            //    Console.WriteLine("Guess the word: ");
            //    string guessedWord = Console.ReadLine();

            //    if (guessedWord == secretWord)
            //    {
            //        Console.Clear();
            //        Console.WriteLine($"You guessed the word in {i} attempts. \n");
            //        break;
            //    }

            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Wrong! try again. \n");
            //    }


            //}
            //Console.ReadKey();

            //--------------------------------------------------------------------------------------------


            //using while loop

            int count = 0;

            while (true)
            {
                count++;

                Console.WriteLine("Guess the word: ");
                string guessedWord = Console.ReadLine();

                if (guessedWord == secretWord)
                {
                    Console.Clear();
                    Console.WriteLine($"You guessed the word in {count} attempts. \n");
                    break;
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong! try again. \n");
                }


            }
            Console.ReadKey();


        }
    }
}
