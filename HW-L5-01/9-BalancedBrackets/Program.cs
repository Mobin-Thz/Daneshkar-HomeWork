namespace _9_BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a string with only (), [], {} characters:");
            string input = Console.ReadLine();

            bool balanced = IsBalanced(input);

            Console.WriteLine(balanced ? "Balanced" : "Not Balanced");
            

        }

        static bool IsBalanced(string s)
        {
            var stack = new Stack<char>();

            foreach (var ch in s)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0) return false;

                    var open = stack.Pop();

                    if (ch == ')' && open != '(') return false;
                    if (ch == ']' && open != '[') return false;
                    if (ch == '}' && open != '{') return false;
                }
                else
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }


    }
}