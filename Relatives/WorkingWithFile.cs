using System;
using System.IO;

namespace Relatives
{
    class WorkingWithFile
    {
        private string Path1 { get; set; } = Environment.CurrentDirectory + @"\test.txt";

        public void EnteringAPath(string z)
        {
            Path1 = z;
        }

        public string RequestPath()
        {
            return Path1;
        }
        
        private string[] ReadFile()
        {
            var ArStr = File.ReadAllLines(Path1);
            return ArStr;
        }

        public string[] ReadFileP()
        {
            return ReadFile();
        }
    }
}
