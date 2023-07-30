using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRAV_Capstone_Assignment
{
	class BasicSorting
	{
		
		ArrayList Arrays = new ArrayList();
		ArrayList Arraylists = new ArrayList();
		long swapsRecursive;                            //counts the number off swaps in each recursive method
		long comparisonsRecursive;                      // counts the number of comparisons the recursive method makes


		public BasicSorting ()
		{

		}

		PopulateList Generate = new PopulateList();

		public int[] sortArray(int[] Arr)
		{
			Console.WriteLine("======Now sorting List with {0} number of items======", Arr.Length);
			var watch = new System.Diagnostics.Stopwatch();  // Create stopwatch to count how long the sorting takes to sort
			watch.Start();      // Start stop

			int hold = 0;     //Hold variables for the swap.
			long swaps = 0;      //To count the number of swaps.
			long comparisons = 0;   // top count the number of comparisons

			for (int i = 0; i <= Arr.Length - 2; i++)   //Traverses the List per iteration
			{
				for (int j = 0; j <= Arr.Length - 2; j++) //performs the swaps. For loop is complete after one iteration.
				{
					comparisons++;                      // counts number of comparisons.
					if (Arr[j + 1] > Arr[j])
					{
						hold = Arr[j];
						Arr[j] = Arr[j + 1];
						Arr[j + 1] = hold;
						swaps++;                     //counts number of swaps.

					}
				}

			}
			watch.Stop();    //Stops the watch.
			Console.WriteLine("Time taken to sort array list: {0} Ticks", watch.Elapsed.Ticks);   // Displays the amount of time taken by the algorithm to sort list.
			Console.WriteLine("Comparisons taken to sort array list: {0}", comparisons);         // Displays comparisons
			Console.WriteLine("Swaps taken to sort array list: {0}", swaps);                //displays swaps.

			return Arr;

		}

		public ArrayList sortArrayList(ArrayList arr)
		{
			Console.WriteLine("======Now sorting List with {0} number of items======",arr.Count);
			var watch = new System.Diagnostics.Stopwatch();  // Create stopwatch to count how long the sorting takes to sort
			watch.Start();      // Start stop

			int var1 = 0;     //Hold variables for the comparison and swap.
			int var2 = 0;
			long swaps = 0;               // To count swaps.
			long comparisons = 0;    // to Count comparisons.

			for (int i = 0; i <= arr.Count - 2; i++)   //Traverses the List per iteration
			{
				for (int j = 0; j <= arr.Count - 2; j++) //performs the swaps. For loop is complete after one iteration.
				{
					var1 = (int)arr[j];
					var2 = (int)arr[j + 1];
					comparisons++;                  // Counts the number of comparisons.
					if (var2 > var1)
					{
						arr[j + 1] = var1;
						arr[j] = var2;
						swaps++;                        // counts the number of swaps.

					}
				}

			}
			watch.Stop();    //Stops the watch.
			Console.WriteLine("Time taken to sort array list: {0} Ticks", watch.Elapsed.Ticks);   // Displays the amount of time taken by the algorithm to sort list.
			Console.WriteLine("Number of comparisons to sort array list: {0}", comparisons);     //Displays the number of comparisons
			Console.WriteLine("Number of swaps to sort array list: {0}", swaps);            // Displays the number of swaps.

			return arr;
		}

		public void runIntBubbleSort()
		{
			Console.WriteLine("Comencing BubbleSort Test...");
			Console.WriteLine();

			Arrays = Generate.createIntArrays();

			for(int i = 0;i<Arrays.Count;i++)
			{
				int[] data = (int[])Arrays[i];
				sortArray(data);
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
				sortArrayList(data);
				Console.WriteLine("Done Sorting.");
				Console.WriteLine("==================================================");
			}
			

		}

		public void runRecursivesort()
		{
			Console.WriteLine("Comencing BubbleSort Recursive Test...");
			Console.WriteLine();

			Arrays = Generate.createIntArrays();

			//for (int i = 0; i < Arrays.Count; i++)
			//{
			//	int[] data = (int[])Arrays[i];
			//	Console.WriteLine("======Now sorting Array with {0} number of items======", data.Length);
			//	Console.WriteLine();
			//	sortArrayRecursive(data);
			//	Console.WriteLine("Done Sorting.");
			//	Console.WriteLine("==================================================");
			//	Console.WriteLine();
			//}
			Console.WriteLine("====Now Sorting ArrayLists==========");
			Console.WriteLine();

			Arraylists = Generate.createArrayLists();

			for (int i = 0; i < Arraylists.Count; i++)
			{
				ArrayList data = (ArrayList)Arraylists[i];
				Console.WriteLine("======Now sorting List with {0} number of items======", data.Count);
				Console.WriteLine();
				sortArrayListRecursive(data);
				Console.WriteLine("Done Sorting.");
				Console.WriteLine("==================================================");
			}
		}
		public void sortArrayListRecursive(ArrayList arr)
		{
			swapsRecursive = 0;
			comparisonsRecursive = 0;
			var watch = new System.Diagnostics.Stopwatch();  // Create stopwatch to count how long the sorting takes to sort
			watch.Start();

			sortList(arr, arr.Count);

			watch.Start();      //Stops the watch.

			Console.WriteLine("Time taken to sort array list: {0} Millseconds", watch.Elapsed.Ticks);
			Console.WriteLine("Number of comparisons to sort array list: {0}", comparisonsRecursive);
			Console.WriteLine("Number of swaps to sort array list: {0}", swapsRecursive);						

		}
		private void sortList(ArrayList arr, int n)
		{						
			//Terminating condition
			if (n == 1)
				return;			//Base call of recursive method

			int var1, var2;
			//Comparison of values and sorting in descending order.
			for (int i = 0; i < n - 1; ++i)
			{
				var1 = (int)arr[i];
				var2 = (int)arr[i + 1];
				++comparisonsRecursive;
				if (var1 < var2)
				{
					arr[i + 1] = var1;
					arr[i] = var2;
					++swapsRecursive;
				}

			}
			//Recursive call.
			sortList(arr, n - 1);			
		}

		public void sortArrayRecursive(int[] Arr)
		{
			swapsRecursive = 0;
			comparisonsRecursive = 0;
			// Create stopwatch to count how long the sorting takes to sort
			var watch = new System.Diagnostics.Stopwatch();  
			watch.Start();

			sort(Arr, Arr.Length);

			watch.Stop();
			//Display the time take in ticks and the number of swaps and comparisons made.
			Console.WriteLine("Time taken to sort array list: {0} Millseconds", watch.Elapsed.Ticks);
			Console.WriteLine("Number of comparisons to sort array list: {0}", comparisonsRecursive);
			Console.WriteLine("Number of swaps to sort array list: {0}", swapsRecursive);						
		}
		void sort(int[] arr, int n)
		{
			//Terminating condition
			if (n == 1)
				return;             //Base call of recursive method

			long var1, var2;
			//Comparison of values and sorting in descending order.
			for (long i = 0; i < n - 1; ++i)
			{
				var1 = arr[i];
				var2 = arr[i + 1];
				++comparisonsRecursive;
				if (var1 < var2)            //swap if var1 is greater than var2
				{
					arr[i + 1] = (int)var1;
					arr[i] = (int)var2;
					++swapsRecursive;
				}
			}
			//Recursive call.
			sort(arr, n - 1);			

		}
		

		public int[] bubbleSortOut(int [] arr)
		{
			
			sortArray(arr);
			return arr;
		}
		public int[] REcursiveSortOut(int[] arr)
		{
			sortArrayRecursive(arr);
			return arr;
		}

		public int getInt(int[] arr, int index)
		{
			return arr[index];
		}





	}
}
