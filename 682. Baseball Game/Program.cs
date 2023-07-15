namespace _682._Baseball_Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Solution.CalPoints(new[] { "-60", "D", "-36", "30", "13", "C", "C", "-33", "53", "79" }));
        }
    }

    public class Solution
    {
        public static int CalPoints(string[] operations)
        {
            var listOfRes = new List<int>();

            for (int i = 0; i < operations.Length; i++)
            {
                if (operations[i] == "D")
                {
                    var multi = 2 * listOfRes[listOfRes.Count - 1];
                    listOfRes.Add(multi);
                }
                else if (operations[i] == "+")
                {
                    var sum = listOfRes[listOfRes.Count - 2] + listOfRes[listOfRes.Count - 1];
                    listOfRes.Add(sum);
                }
                else if (operations[i] == "C")
                {
                    listOfRes.RemoveAt(listOfRes.Count - 1);
                } else 
                {
                    listOfRes.Add(int.Parse(operations[i]));
                }
            }
            return listOfRes.Sum();
        }
    }
}
