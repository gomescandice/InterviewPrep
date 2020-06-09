using System;
namespace InterviewStudy
{
    public class BinarySearch
    {
        public int Search(int[] arr, int key , int low, int high)
        {
            int mid = (low + (high - 1)) / 2;
            if( low < high)
            {
                if (arr[mid] == key)
                {
                    return key;
                }
                else if (arr[mid] > key)
                {
                    Search(arr, key, low, mid - 1);
                }
                else
                {
                    Search(arr, key, mid + 1, high);
                }
            }

            return -1;
        }
    }
}
