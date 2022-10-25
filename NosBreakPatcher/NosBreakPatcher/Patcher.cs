using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NosBreakPatcher
{
    class Patcher
    {
        public string version;
        public string filename;

        public static int GetVersion(string filename) => int.Parse(File.ReadAllText(filename, System.Text.Encoding.UTF8));

    }
}
