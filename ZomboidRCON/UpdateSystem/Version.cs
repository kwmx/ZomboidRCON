using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZomboidRCON.UpdateSystem
{
    public class Version
    {
        string versionString;
        int major, minor, patch;
        public Version(string version)
        {
            versionString = "";
            foreach(char c in version)
            {
                if (char.IsDigit(c) || c == '.') versionString += c;
            }
            BuildData();
        }
        private void BuildData()
        {
            string[] v = versionString.Split('.');
            if (v.Length != 3) throw new Exceptions.InvalidVersionFormatException("Provided an invalid version format '" + versionString + "' Should be 'x.y.z' in Semantic Versioning");
            major = int.Parse(v[0]);
            minor = int.Parse(v[1]);
            patch = int.Parse(v[2]);
        }
        public string VersionString { get { return versionString; } }
        public int Major { get { return major;} }
        public int Minor { get { return minor;} }
        public int Patch { get { return patch;} }
        public static bool operator>(Version v1, Version v2)
        {
            if (v2.major > v1.major) return false;
            else if(v1.major > v2.major) return true;
            if(v2.minor > v1.minor) return false;
            else if (v1.minor > v2.minor) return true;
            if (v2.patch > v1.patch) return false;
            if (v1.patch > v2.patch) return true;
            return false;
        }
        public static bool operator >=(Version v1, Version v2)
        {
            if (v1.major == v2.major && v1.minor == v2.minor && v1.patch == v2.patch) return true;
            return v1 > v2;
        }
        public static bool operator <(Version v1, Version v2)
        {
            return !(v1 > v2);
        }
        public static bool operator <=(Version v1, Version v2)
        {
            if(v1.major == v2.major && v1.minor == v2.minor && v1.patch == v2.patch) return true;
            return v1 < v2;
        }
        public override string ToString()
        {
            return major + "." + minor + "." + patch;
        }
    }
}
