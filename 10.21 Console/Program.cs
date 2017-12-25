using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolsLibrary;

namespace _10._21_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                List<Cut> Cuts = ConsoleTls.Input();
                List<Cut> CombineCuts = Cut.Combine(Cuts);
                ConsoleTls.Output(CombineCuts);
            }
        }
    }
}
