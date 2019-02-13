using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source.Length == 0)
            {
                throw new ArgumentException();
            }
            if (source==null)
            {
                throw new ArgumentNullException();
            }
            for(int i = 0; i < source.Length; i++)
            {
                if (source[i] == null)
                {
                    throw new ArgumentNullException();
                }
            }
            for(int i = 0; i < source.Length/2; i++)
            {
                if (source[i] != source[source.Length - 1 - i])
                {
                    return "No";
                }
            }
            return "Yes";
        }
    }
}
