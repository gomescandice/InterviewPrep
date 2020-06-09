using System;
using System.Collections.Generic;
namespace InterviewStudy
{
    public class Anagram
    {
        public bool Validate(string inputString1 , string inputString2)
        {
            if (inputString1.Length != inputString2.Length)
                return false;

            List<char> inputList1 = new List<char>(inputString1.ToCharArray());
            List<char> inputList2 = new List<char>(inputString2.ToCharArray());
            foreach(char c in inputList1)
            {
                if(inputList2.Contains(c))
                {
                    inputList2.Remove(c);
                }
            }
            if (inputList2.Count != 0)
                return false;
            return true;
        }
    }
}
