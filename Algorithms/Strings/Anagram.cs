using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Deep_Dive_C_.Algorithms.Strings
{
    internal class Anagram
    {
        private string str1;
        private string str2;


        public Anagram(string str1, string str2)
        {

            this.str1 = str1;
            this.str2 = str2;
        }

        /*Add values from first string then subtract
        values from second string
        */
        public bool isAnagram()
        {

            var s1 = this.str1.ToLower();
            var s2 = this.str2.ToLower();

            if (s1.Length != s2.Length) return false;

            Dictionary<char, int> map = new Dictionary<char, int>();

            //Begin addition
            foreach (char c in s1)
            {
                if (!map.ContainsKey(c))
                {
                    map[c] = 1;
                }else
                    map[c]++;

            }

            //Begin Subtraction
            foreach (char c in s2)
            {
                if (map.ContainsKey(c))
                {
                    map[c]--;
                }
                if (map[c] == 0)
                {
                    map.Remove(c);

                }

            }

            return map.Count == 0;
        }
    }
}
