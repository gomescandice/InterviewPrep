using System;
namespace InterviewStudy
{
    public class FindMax
    {
        public int Find(int[] arr)
        {
            int max = 0;
            foreach(int i in arr)
            {
                if(i > max)
				{
                    max = i;
				}
            }
            return max;
        
        }
    }
}
