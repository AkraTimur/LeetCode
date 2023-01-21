namespace _69._Sqrt_x_
{
    public static class Solution
    {
        public static int MySqrt(int x)
        {
            double approx = (double)x / 2;
            double error = double.Epsilon;

            while (Math.Abs(approx * approx - x) > error)
            {
                approx = (approx + (double)x / approx) / 2;
            }
            return (int)approx;
        }
    }
}
