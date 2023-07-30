using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRAV_Capstone_Assignment
{
    class OptimizedBasicSort
    {
        ArrayList Arrays = new ArrayList();             // Collection of sub arrays. 
        ArrayList Arraylists = new ArrayList();         //An array list used to generate test values.
        PopulateList Generate = new PopulateList();
      
        public void RunMagneticSort()
        {
            Console.WriteLine("Comencing Magnetic BubbleSort Test...");
            Console.WriteLine();

            Arrays = Generate.createIntArrays();

            for (int i = 0; i < Arrays.Count; i++)
            {
                int[] data = (int[])Arrays[i];
                Console.WriteLine("======Now sorting Array with {0} number of items======", data.Length);
                Console.WriteLine();
                MagneticBubbleSort(data);
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
                MagneticBubbleSortList(data);
                Console.WriteLine("Done Sorting.");
                Console.WriteLine("==================================================");
            }
        }
        public void MagneticBubbleSort(int [] B)
        {
            // Create stopwatch to count how long the sorting takes to sort
            var watch = new System.Diagnostics.Stopwatch();  
           

            int i = 0;                                  
            int numOfIterations = B.Length;
            long swaps = 0;
            long comparisons = 0;
            int indiciesLeft;

            watch.Start();

            //Outer while loop used to iterate through array as many times as required to sort it.
            while (i < numOfIterations)
            {
                int start = 0;                          //Pointer indicating start of the block or magnet
                int end = 0;                            //Pointer indicating end of the block or magnet.
                int j = 0;
                //Inner while loop used to determine the indicies of the array.
                while (j < numOfIterations - 1)
                {
                    ++comparisons;
                    //Comparison of the values, swaping in order to sort in descending order.
                    if (B[end] < B[j + 1])
                    {
                        int temp = B[start];
                        B[start] = B[j + 1];
                        B[j + 1] = temp;
                        ++end;
                        ++start;
                        ++swaps;
                    }
                    //If this is true it extends the magnetic block.
                    else if (B[end] == B[j + 1])
                    { end = j + 1; }
                    else
                    {
                        end = j + 1;
                        start = j + 1;
                    }
                    ++j;
                }
                indiciesLeft = (end - start) + 1;
                numOfIterations = numOfIterations - indiciesLeft;
                ++i;
            }

            watch.Stop();
            
            //Display the time take in ticks and the number of swaps and comparisons made.
            Console.WriteLine("Time taken to sort array list: {0} Ticks", watch.Elapsed.Ticks);   
            Console.WriteLine("Number of comparisons to sort array list: {0}", comparisons);     
            Console.WriteLine("Number of swaps to sort array list: {0}", swaps);

        }
        public void MagneticBubbleSortList(ArrayList B)
        {
            // Create stopwatch to count how long the sorting takes to sort
            var watch = new System.Diagnostics.Stopwatch();  
            watch.Start();

            int i = 0;
            int n = B.Count;
            int numOfIterations = n;
            long swaps = 0;
            long comparisons = 0;

            //Outer while loop used to iterate through array as many times as required to sort it.
            while (i < numOfIterations)
            {
                int start = 0;                      //Pointer indicating start of the block or magnet
                int end = 0;                        //Pointer indicating end of the block or magnet
                int j = 0;

                //Inner while loop used to determine the indicies of the array.
                while (j < numOfIterations - 1)
                {
                    ++comparisons;
                    //Comparison of the values, swaping in order to sort in descending order.
                    if ((int)B[end] < (int)B[j + 1])
                    {
                        int temp = (int)B[start];
                        B[start] = (int)B[j + 1];
                        B[j + 1] = temp;
                        ++end;
                        ++start;
                        ++swaps;
                    }
                    //If this is true it extends the magnetic or block.
                    else if ((int)B[end] == (int)B[j + 1])
                    {
                        end = j + 1;
                    }
                    else
                    {
                        end = j + 1;
                        start = j + 1;                       
                    }
                    ++j;                   
                }

                int indiciesLeft = (end - start) + 1;
                numOfIterations = numOfIterations - indiciesLeft;
                ++i;
            }

            watch.Stop();

            //Display the time take in ticks and the number of swaps and comparisons made.
            Console.WriteLine("Time taken to sort array list: {0} Ticks", watch.Elapsed.Ticks);  
            Console.WriteLine("Number of comparisons to sort array list: {0}", comparisons);    
            Console.WriteLine("Number of swaps to sort array list: {0}", swaps);
        }
    }
}
