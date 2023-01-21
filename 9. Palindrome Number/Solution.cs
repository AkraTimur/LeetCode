namespace _9._Palindrome_Number
{
    public static class Solution
    {
        public static bool IsPalindrome(int x)
        {
            int reversNumber = 0;
            int temp = x;

            while (temp > 0)
            {
                int lastDigit = temp % 10;
                reversNumber *= 10;
                reversNumber+= lastDigit;
                temp /= 10;
            }
            return x == reversNumber;  
        }
    }
}
