using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            if (source.Length % 2 != 0)
            {
                return "No";
            }
            int[] mas = new int[source.Length / 2];
            int a = -1;
            for(int i = source.Length / 2; i < source.Length; i++)
            {
                a++;
                mas[a] = source[i];
            }
            Array.Reverse(mas);
            for (int i = 0; i < source.Length/2; i++)
            {
                if(mas[i] != source[i])
                {
                    return "No";
                }
            }
            return "Yes";
        }
    }
}
