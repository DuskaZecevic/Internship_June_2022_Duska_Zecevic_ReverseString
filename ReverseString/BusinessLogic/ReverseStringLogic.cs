using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString.BusinessLogic
{
    public class ReverseStringLogic
    {
       public static string ReverseString(char [] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[length - 1 - i];
                arr[length - 1 - i] = temp;
            }
            return new string(arr);
        }
    }
}
