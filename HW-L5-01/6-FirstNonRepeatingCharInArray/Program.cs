namespace _6_FirstNonRepeatingCharInArray
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a string: ");
            string inputString = Console.ReadLine();

            char firstUniqueChar = FindFirstNonRepeatingCharacter(inputString);

            if (firstUniqueChar == '\0')
                Console.WriteLine("-1");
            else
                Console.WriteLine(firstUniqueChar);
        }

        static char FindFirstNonRepeatingCharacter(string text)
        {
            var characterFrequency = new Dictionary<char, int>();

            // شمارش تکرار هر کاراکتر
            foreach (var character in text)
            {
                if (characterFrequency.ContainsKey(character))
                    characterFrequency[character]++;
                else
                    characterFrequency[character] = 1;
            }

            // پیدا کردن اولین کاراکتر با تکرار 1
            foreach (var character in text)
            {
                if (characterFrequency[character] == 1)
                    return character;
            }

            return '\0'; // وقتی هیچ کاراکتر غیرتکراری وجود نداشت
        }
    }

}

