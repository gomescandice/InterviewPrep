using System;
namespace InterviewStudy
{
    public class Palindrome
    {
        public bool Validate(string inputText)
        {
            bool retVal = true;
            for(int i = 0; i < inputText.Length/2; i++)
            {
                if(inputText[i] != inputText[inputText.Length-i-1])
                {
                    return false;
                }
            }
            return retVal;

        }
    }
}
