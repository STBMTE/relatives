using System;

namespace Relatives
{
    class WorkingWithTheConsole
    {
        public void Write()
        {
            SplitArray b = new SplitArray();
            var arr = b.ExcludingSplits();
            int leng = arr.Length;
            for (int i = 0; i < leng; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
