using System;
using System.Linq;
namespace InterviewStudy
{
    public class AddOne
    {
        public int AddOneToArray(int input)
        {
            int j = 0;
            int[] number = new int[input.ToString().Length];
            foreach (char c in input.ToString())
            {
                number[j] = int.Parse(c.ToString());
                j++;
            }
            int carry = 1;
            for(int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] == 9 && carry == 1)
                {
                    number[i] = 0;
                    carry = 1;
                }
                else if (carry == 1)
                {
                    number[i] = number[i] + 1;
                    carry = 0;
                }
            }
            string retVal = "";
            foreach (int x in number)
            {
                retVal += x.ToString();
            }
            if (carry == 1)
            {
                return int.Parse(1.ToString() + retVal) ;
            }
            return int.Parse(retVal);
        }
    }
}
