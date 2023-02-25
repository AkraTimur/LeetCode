namespace _20._Valid_Parentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("()"));
        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    char top = stack.Peek();
                    if ((c == ')' && top != '(') || (c == '}' && top != '{') || (c == ']' && top != '['))
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
    }
}
