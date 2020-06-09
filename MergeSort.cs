using System;
namespace InterviewStudy
{
    public class MergeSort
    {
        public void Merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for(int i = 0; i< n1; i++)
            {
                L[i] = arr[l + i];
            }
            for(int j = 0; j< n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }
            int i1 = 0, j1 = 0;
            int k = l;
            while(i1 < n1 && j1 < n2)
            {
                if(L[i1] <= R[j1])
                {
                    arr[k] = L[i1];
                    i1++;
                    k++;
                }
                else
                {
                    arr[k] = R[j1];
                    j1++;
                    k++;
                }
            }
            while (i1 < n1)
            {
                arr[k] = L[i1];
                i1++;
                k++;
            }
            while (j1 < n2)
            {
                arr[k] = R[j1];
                j1++;
                k++;
            }

        }

        public void Sort(int[] arr, int l, int r)
        {
            if(l < r)
            {
                int m = (l + r) / 2;
                Sort(arr, l, m);
                Sort(arr, m + 1, r);

                Merge(arr, l, m, r);
            }

        }
        public string ArraytoString(int[] array)
        {
            string result = "";
            string prefix = "";
            for (int i = 0; i < array.Length; i++)
            {
                if (i != 0)
                    prefix = ",";

                result = result + prefix + array[i].ToString();
            }
            return result;
        }
    }
}
