using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    public class FindingMax_ForMoreThanThree
    {
        public int[] inputArray;
        public static int ArrayOfIntegers(params int[] inputArray)
        {
            return inputArray.Max();
        }
        public static double ArrayOfDouble(params double[] doubleArray)
        {
            return doubleArray.Max();
        }
        public static string ArrayOfStrings(params string[] stringArray)
        {
            return stringArray.Max();
        }
    }
}
