using System;
namespace InterviewStudy
{
    public class ReverseString
    {
        public bool Validate(string inputText1, string inputText2)
        {
            if (inputText1.Length != inputText2.Length)
                return false;
            char[] reverseString = new char[inputText1.Length];
            for (int j = inputText2.Length - 1; j >= 0; j--)
            {
                reverseString[inputText2.Length - j - 1] = inputText2[j];
            }
            if (inputText1 == new string(reverseString))
                return true;
            else
                return false;
        }

    }
}
