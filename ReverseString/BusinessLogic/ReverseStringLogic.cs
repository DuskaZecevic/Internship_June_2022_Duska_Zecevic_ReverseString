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
            for (int i = 0; i < arr.Length / 2; i++)
            {
                char temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
            return new string(arr);
        }
    }
}
