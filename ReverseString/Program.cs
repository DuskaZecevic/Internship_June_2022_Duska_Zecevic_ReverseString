using ReverseString.BusinessLogic;
using System;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] arr = { 'h', 'e', 'l', 'l', 'o'};

            Console.WriteLine("The reverse string is: " + ReverseStringLogic.ReverseString(arr));
        }
    }
}
