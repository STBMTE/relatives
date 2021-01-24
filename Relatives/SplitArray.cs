using System;
using System.ComponentModel.DataAnnotations;

namespace Relatives
{
    public class SplitArray
    {
        public string[] ExcludingSplits()
        {
            WorkingWithFile b = new WorkingWithFile();
            var str = b.PublicReadFile();
            int j = 0;
            int DeltaLength = 0;
            int Leng = str.Length;
            for (int i = 0; i < Leng; i++)
            {
                if (str[i] == "")
                {
                    DeltaLength++;
                }
            }
            string[] UndividedArray = new string[Leng - DeltaLength];
            for (int i = 0; i < Leng; i++)
            {
                if (str[i] != "")
                {
                    UndividedArray[j] = str[i];
                    j++;
                }
            }
            return UndividedArray;
        }
    }
}