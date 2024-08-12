using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARCLibrary
{
    public class HashCalculator
    {
        /// <summary>
        /// Calculate FileName Hash
        /// </summary>
        /// <param name="Name">FileName (char[])</param>
        /// <param name="FileNameHashMultiplier"></param>
        /// <returns>FileNameHash</returns>
        public static int Calculate(char[] Name, int FileNameHashMultiplier = 0x65)
        {
            int hash = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                hash = Name[i] + (hash * FileNameHashMultiplier);
            }

            return hash;
        }

        public static char[] HashAnalyze(int InputHash, int StringLength, int FileNameHashMultiplier = 0x65)
        {
            char[] chars = new char[StringLength];

            for (int i = 0; i < StringLength; i++)
            {
                chars[i] = Convert.ToChar(InputHash - (InputHash / FileNameHashMultiplier));
            }

            return chars;
        }
    }
}
