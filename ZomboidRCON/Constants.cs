using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON
{
    internal class Constants
    {
        public const string RepoPath = "kwmx/ZomboidRCON";
        public const string Version = "1.0.3";
        public static string AssemblyVersionToSemver
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString(3);
            }
        }
    }
}
