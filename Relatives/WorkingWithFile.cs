using System;
using System.IO;

namespace Relatives
{
    class WorkingWithFile
    {
        private string Path { get; set; } = Environment.CurrentDirectory + @"\test.txt";

        public string[] PublicReadFile()
        {
            var res = ReadFile();
            return res;
        }
        private string[] ReadFile()
        {
            var ArStr = File.ReadAllLines(Path);
            return ArStr;
        }
    }
}
