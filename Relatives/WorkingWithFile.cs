using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Relatives
{
    class WorkingWithFile
    {
        private string Path = $@"C:\Users\ateru\Desktop\Лабы\relatives\Relatives\file.txt";

        public void EnteringAPath(string z)
        {
            Path = z;
        }

        public string RequestPath()
        {
            return Path;
        }
        
        private string[] ReadFile()
        {
            /*int Length = File.ReadAllLines(path: Path).Length;
            string[] FileText;
            FileText = new string[Length];
            return FileText;*/
            var arStr = File.ReadAllLines(Path);
            return arStr;
        }

        public string[] ReadFileP()
        {
            return ReadFile();
        }
    }
}
