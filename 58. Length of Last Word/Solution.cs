using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _58._Length_of_Last_Word
{
    public class Solution
    {
        public static int LengthOfLastWord(string s)
        {
            var res = s.Trim().Split();
            return res[res.Length -1].Length;
        }
    }
}
