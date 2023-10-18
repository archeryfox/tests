using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var filename = "filel.txt"; //Ha3BaHne cbaina, KOTOPb151
            var mgr = new FileManager();
            if (mgr.FindLogFile(filename))
                Console.WriteLine($"Найден {filename}");
            else
                Console.WriteLine($"Не найден {filename}");
        }

    }
}