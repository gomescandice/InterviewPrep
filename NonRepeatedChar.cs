using System;
using System.Collections.Generic;

namespace InterviewStudy
{
    public class NonRepeatedChar
    {
        public string FindFirstChar(string inputText)
        {
            List<char> listInputText = new List<char>(inputText.ToCharArray());
            foreach (char c in inputText)
            {
                listInputText.Remove(c);
                if (listInputText.Contains(c))
                {
                    int location = listInputText.IndexOf(c) + 2;
                    return "Character " + c.ToString() + " was found at location " + location.ToString() + "."; 
                } 
            }
            return "No matching repeating characters.";
        }
    }
}
