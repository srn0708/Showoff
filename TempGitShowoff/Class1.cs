using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempGitShowoff
{
    internal static class Class1
    {
        public static void Print(this string text) { Console.WriteLine(text); }

        public static void PrintUpperCase(this string text) { Console.WriteLine(text.ToUpper());  }
    }
}
