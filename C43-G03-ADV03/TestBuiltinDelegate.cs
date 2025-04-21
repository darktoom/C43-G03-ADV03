using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C43_G03_ADV03
{
    internal static class TestBuiltinDelegate
    {
        public static bool checkpostive(int number) { return number >= 0; }
        public static string casting(int number) { return number.ToString(); }
        public static void print() { Console.WriteLine("hello world"); }
        public static void print(string name) { Console.WriteLine($"hello,{name}"); }


    }
}
