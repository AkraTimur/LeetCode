namespace _657._Robot_Return_to_Origin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.JudgeCircle("RRDD"));
        }
    }

    public class Сoordinate
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    public class Solution
    {
        public static bool JudgeCircle(string moves)
        {
            var сoordinate = new Сoordinate();
            for (int i = 0; i < moves.Length; i++)
            {
                
                switch (moves[i])
                {
                    case 'U':
                        сoordinate.X ++;
                        break;

                    case 'D':
                        сoordinate.X --;
                        break;

                    case 'R':
                        сoordinate.Y ++;
                        break;

                    case 'L':
                        сoordinate.Y--;
                        break;
                    default:
                        break;
                }
            }
            return сoordinate.X == 0 && сoordinate.Y== 0;
        }
    }
}