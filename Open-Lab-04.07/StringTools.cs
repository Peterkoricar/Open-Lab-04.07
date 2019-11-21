using System;

namespace Open_Lab_04._07
{
    public class StringTools
    {
        public string Reverse(string original)
        {
            string i = "";
            for (int a = original.Length - 1; a >= 0; a--)
            {
                i += original[a];
            }
            return i;
        }
    }
}
