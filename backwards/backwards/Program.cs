using System;
using System.Collections.Generic;
using System.Text;

namespace backwards
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sameOrDifferent = BackWards("");
            Console.WriteLine(sameOrDifferent);
        }

        static bool BackWards(string word)

        {
            char[] letters = word.ToCharArray();

            Array.Reverse(letters);

            string opposite = new string(letters);

            if (opposite == word)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
