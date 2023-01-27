namespace Hamming_Distance
{
    public static class Solution
    {
        public static int HammingDistance(int x, int y)
        {
            string _x = Convert.ToString(x, 2).PadLeft(100, '0');
            string _y = Convert.ToString(y, 2).PadLeft(100, '0');
            int count = 0;
                
                for (int i = 0; i < _x.Length;)
                {
                    for (int j = 0; j < _y.Length; j++)
                    {
                        if (_x[i] != _y[j]) count++;
                        i++;
                    }
                }

            return count;
        }
    }
}
