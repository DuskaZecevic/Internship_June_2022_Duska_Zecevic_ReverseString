using ReverseString.BusinessLogic;
using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Write a function that reverses a string.The input string is given as an array of characters s. You must do this by modifying the input
            //array in-place with O(1) extra memory. Example 1: Input: s = ["h", "e", "l", "l", "o"] - Output: ["o","l","l","e","h"]
            char[] arr = { 'h', 'e', 'l', 'l', 'o'};

            Console.WriteLine("The reverse string is: " + ReverseStringLogic.ReverseString(arr));
            
        }
    }
}
