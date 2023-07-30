using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRAV_Capstone_Assignment
{
    class AdvancedSorting
    {
        ArrayList Arrays = new ArrayList();             // Collection of sub arrays. 
        ArrayList Arraylists = new ArrayList();         //An array list used to generate test values.
        PopulateList Generate = new PopulateList();
        long comparisons, swaps,ticks;
        public void RunMergeSort()
        {
            Console.WriteLine("Comencing MergeSort Test...");
            Console.WriteLine();

            Arrays = Generate.createIntArrays();

            for (int i = 0; i < Arrays.Count; i++)
            {
                int[] data = (int[])Arrays[i];
                Console.WriteLine("======Now sorting Array with {0} number of items======", data.Length);
                Console.WriteLine();
                mergesort(data);               
                Console.WriteLine("Done Sorting.");
                Console.WriteLine("==================================================");
                Console.WriteLine();
            }

            Console.WriteLine("====Now Sorting ArrayLists==========");
            Console.WriteLine();

            Arraylists = Generate.createArrayLists();

            for (int i = 0; i < Arraylists.Count; i++)
            {
                ArrayList data = (ArrayList)Arraylists[i];
                Console.WriteLine("======Now sorting List with {0} number of items======", data.Count);
                Console.WriteLine();
                mergesort(data);
                Console.WriteLine("Done Sorting.");
                Console.WriteLine("==================================================");
            }
        }
        public void mergesort(Object List)       
        {
           
            comparisons = 0;
            swaps = 0;
            ticks = 0;

            //Detetmine if the array passed (List) is an ArrayList or int[]. 
            if (List is ArrayList)
            {

                ArrayList copy = (ArrayList)List;

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                MergeSortList(copy);

                stopWatch.Stop();
                ticks = stopWatch.ElapsedTicks;


            }
            else if (List is int[])
            {
                int[] copy = (int[])List;

                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                MergeSort(copy);

                stopWatch.Stop();
                ticks = stopWatch.ElapsedTicks;

            }

            //Display the time take in ticks and the number of swaps and comparisons made.
            Console.WriteLine("Time taken to sort array list: {0} Ticks", ticks);   
            Console.WriteLine("Number of comparisons to sort array list: {0}", comparisons);     
            Console.WriteLine("Number of swaps to sort array list: {0}", swaps);        

        }

        private void MergeSort(int[] arr)
        {
            
            int n = arr.Length;
            if (n < 2)
                return;
            int divisor = n / 2;
            //Create sub array for the left side and right side.
            int[] left = new int[divisor];
            int[] right = new int[n-divisor];

            //Copy (deep clone) the array(arr) into its left and right sides.
            for (int i = 0; i < divisor; ++i)
            {               
                left[i] = arr[i];
            }
            for (int j = divisor; j < n; ++j)
            {               
                right[j-divisor] = arr[j];
            }
            //Recursively call the MergeSort method to split the array into its left and right sides.
            MergeSort(left);
            MergeSort(right);

            //Merge the respective sub arrays
            Merge(left, right, arr);
        }
        private void Merge(int[] left, int[] right, int[] arr)
        {
            int k = 0;
            int i = 0;              //Index for left subarry.
            int j = 0;              //Index for right subarray.
            int nL = left.Length;
            int nR = right.Length;

            //Determine the order of the elements by comparison of the integer.
            while (i < nL && j < nR)
            {
                int leftTutor = left[i];
                int rightTutor = right[j];
                ++comparisons;
                if (leftTutor >= rightTutor)
                {
                    arr[k] = leftTutor;
                    ++i;

                }
                else
                {
                    arr[k] = rightTutor;
                    ++j;
                    ++swaps;
                }
                ++k;
            }
            //To make sure that all the values are copied accordingly.
            while (i < nL)
            {
                arr[k] = left[i];
                ++i;
                ++k;
            }
            while (j < nR)
            {
                arr[k] = right[j];
                ++j;
                ++k;
            }
        }
        
        private void MergeSortList(ArrayList arr)
        {
            int n = arr.Count;
            if (n < 2)
                return;
            int divisor = n / 2;
            //Create sub array for the left side and right side.
            ArrayList left = new ArrayList();
            ArrayList right = new ArrayList();

            //Copy (deep clone) the array(arr) into its left and right sides.
            for (int i = 0; i < divisor; ++i)
            {
                int temp = (int)arr[i];
                left.Add(temp);
            }
            for (int i = divisor; i < n; ++i)
            {
                int temp = (int)arr[i];
                right.Add(temp);
            }
            //Recursively call the MergeSort method to split the array into its left and right sides.
            MergeSortList(left);
            MergeSortList(right);

            //Merge the respective sub arrays
            MergeList(left, right, arr);
        }
        private void MergeList(ArrayList left, ArrayList right, ArrayList arr)
        {
            int k = 0;
            int i = 0;              //Index for left subarry.
            int j = 0;              //Index for right subarray.
            int nL = left.Count;
            int nR = right.Count;

            //Determine the order of the elements by comparison of the integers.
            while (i < nL && j < nR)
            {
                int leftTutor = (int)left[i];
                int rightTutor = (int)right[j];
                ++comparisons;
                if (leftTutor >= rightTutor)
                {
                    arr[k] = leftTutor;
                    ++i;

                }
                else
                {
                    arr[k] = rightTutor;
                    ++j;
                    ++swaps;
                }
                ++k;
            }
            //To make sure that the left over values are copied accordingly.
            while (i < nL)
            {
                arr[k] = left[i];
                ++i;
                ++k;
            }
            while (j < nR)
            {
                arr[k] = right[j];
                ++j;
                ++k;
            }
        }
    }
}
