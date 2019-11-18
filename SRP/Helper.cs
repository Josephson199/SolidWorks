using System;
using System.IO;
using System.Reflection;

namespace SRP
{
    public static class Helper
    {
        public static string AssemblyDirectory
        {
            get
            {
                string codeBase = Assembly
                    .GetExecutingAssembly()
                    .CodeBase ?? string.Empty;
                UriBuilder uri = new UriBuilder(codeBase);
                string path = Uri.UnescapeDataString(uri.Path);
                return Path.GetDirectoryName(path) ?? string.Empty;
            }
        }
    }
}
