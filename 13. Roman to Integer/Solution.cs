namespace _13._Roman_to_Integer
{
    public static class Solution
    {
        public static int RomanToInt(string s)
        {
            var dictionary = new Dictionary<char, int>
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000},
            };
            int total = 0;
            int prevValue = 0;

            foreach (char c in s)
            {
                int curentValue = dictionary[c];
                if (curentValue > prevValue)
                {
                    total += curentValue - 2 * prevValue; 
                }
                else
                {
                    total+= curentValue;
                }
                prevValue = curentValue;
            }
            return total;
        }
    }
}
