using System;

namespace Relatives
{
    class WorkingWithTheConsole
    {
        public void Write()
        {
            WorkingWithFile b = new WorkingWithFile();
            string[] str = b.ReadFileP();
            int leng = str.Length;
            for (int i = 0; i < leng; i++)
            {
                if(str[i] != "")
                {
                    Console.WriteLine(str[i]);
                }
            }
        }
    }
}
