﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Palindrome current = new Palindrome();
            current.ExecutePalindrome();

            Console.WriteLine("END OF PROGRAM");
            Console.ReadKey();
        }
    }
}
