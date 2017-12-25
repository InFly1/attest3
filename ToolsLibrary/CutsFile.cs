using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToolsLibrary
{
    public class CutsFile
    {
        public string Path { get; set; }
        public List<Cut> ReadCuts()
        {
            return CutConvert.StrToListCuts(File.ReadAllText(Path));
        }
        public void WriteCuts(List<Cut> lines)
        {
            File.WriteAllText(Path, CutConvert.CutsListToStr(lines));
        }

        public CutsFile(string path)
        {
            Path = path;
        }
    }
}
