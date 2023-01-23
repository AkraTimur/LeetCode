namespace _14._Longest_Common_Prefix
{
    public static class Solution
    {
        public static string LongestCommonPrefix(string[] strs)
        {
            string prefix = "";
            if (strs.Length == 0) return prefix; // return empty string if the array is empty
            for (int i = 0; i < strs[0].Length; i++)
            { // iterate over the first string
                char c = strs[0][i];
                for (int j = 1; j < strs.Length; j++)
                { // compare the current character with the rest of the strings
                    if (i >= strs[j].Length || strs[j][i] != c)
                    { // if current index is out of range or the characters do not match
                        return prefix; // return the current prefix
                    }
                }
                prefix += c; // if all the characters match, add it to the prefix
            }
            return prefix;
        }
    }
}
