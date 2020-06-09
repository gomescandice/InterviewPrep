using System;
namespace InterviewStudy
{
    public class QuickSort
    {
        public void Sort(int[] array, int low,int  high)
        {
            if (low < high)
            {
                int p = partition(array, low, high);

                Sort(array, low, p - 1);
                Sort(array, p + 1, high);
            }
            
        }

        public int partition(int[] array, int low, int high)
        {
            int i = low-1;
            int pivot = array[high];
            for(int j = low; j < high; j++)
            {
                if(array[j] < pivot)
                {
                    i++;
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            int temp1 = array[i+1];
            array[i+1] = array[high];
            array[high] = temp1;

            return i+1;

        }

        public string ArraytoString(int [] array)
        {
            string result = "";
            string prefix = "";
            for(int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                    prefix = ",";

                result = result + prefix + array[i].ToString();
            }
            return result;
        }
    }
}
