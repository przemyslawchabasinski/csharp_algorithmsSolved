using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Numerics;

namespace AlgorithmsSolved
{
    class Program
    {
        static void Main(string[] args)
        {
            string vs = "abbaa";
            var result = superReducedString(vs);
            Console.Write(result);
            Console.ReadKey();
        }      
    }
}