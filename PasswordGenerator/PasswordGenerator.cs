using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public static class Randomizer
    {
        public static readonly Random random = new Random();
    }
    public static class PasswordGenerator
    {
        public static string Generate(int length)
        {
            string iPass = "";
            char[] arr = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '+', '-', '*', '/', '.', ',', ';', ':', ' ' };
            for (int i = 0; i < length; i = i + 1)
            {
                iPass = iPass + arr[Randomizer.random.Next(0, arr.Length)];
            }
            return iPass;
        }
    }
}
