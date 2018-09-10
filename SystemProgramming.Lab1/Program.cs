using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SystemProgramming.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            var path1 = @"C:\Users\vladk\Desktop\1.txt";
            var path2 = @"C:\Users\vladk\Desktop\2.txt";

            var result = Api.CopyFile(path1, path2, false);
        }

        public static class Api
        {
            [DllImport("kernel32.dll")]
            public static extern bool CopyFile(string path1, string path2, bool fail);
        }
    }
}