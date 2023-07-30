using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WRAV_Capstone_Assignment
{
	class Program
	{
		static void Main(string[] args)
		{
			int choice;
			int choice2;
			int choice3;
			int choice4;
			BasicSorting CreateTest = new BasicSorting();
			PopulateList FillOut = new PopulateList();
			OptimizedBasicSort OptTestValue = new OptimizedBasicSort();
			AdvancedSorting AdvTestValue = new AdvancedSorting();

			do
			{
				Console.WriteLine("INDICATE WHICH DATA YOU WISH TO TEST ");
				Console.WriteLine("1. RUN TEST DATA");
				Console.WriteLine("2. RUN INPUT DATA");
				Console.WriteLine("9. TERMINATE PROCESSING");
				choice = int.Parse(Console.ReadLine());

				switch (choice)
				{
					case 1:
						do
						{

							Console.WriteLine("INDICATE WHICH SORTING CLASS YOU WISH TO TEST ");
							Console.WriteLine("1. Basic Sorting");
							Console.WriteLine("2. Optimized Sorting");
							Console.WriteLine("3. Advanced Sorting");
							Console.WriteLine("99. TERMINATE PROCESSING");

							choice2 = int.Parse(Console.ReadLine());
							switch (choice2)
							{
								case 1:
									Console.WriteLine("INDICATE WHICH ALGORITHM YOU WISH TO TEST ");
									Console.WriteLine("1. BubbleSort (Iterative)");
									Console.WriteLine("2. Recursive BubbleSort");
									choice3 = int.Parse(Console.ReadLine());
									switch (choice3)
									{
										case 1:
											CreateTest.runIntBubbleSort();
											Console.WriteLine("Press Enter to continue...");
											Console.ReadLine();
											break;
										case 2:
											CreateTest.runRecursivesort();
											Console.WriteLine("Press Enter to continue...");
											Console.ReadLine();
											break;

									}
									break;
								case 2:
									
									Console.WriteLine("INDICATE WHICH ALGORITHM YOU WISH TO TEST ");
									Console.WriteLine("1. ");
									Console.WriteLine("2. Magnetic BubbleSort");
									Console.WriteLine("3. ");
									choice3 = int.Parse(Console.ReadLine());
									switch (choice3)
									{
										case 1:
											Console.WriteLine("Codes Not Available!!");
											break;
										case 2:
											OptTestValue.RunMagneticSort();
											Console.WriteLine("Press Enter to continue...");
											Console.ReadLine();
											break;
										case 3:
											Console.WriteLine("Codes Not Available!!");
											break;

									}
									break;
									
								case 3:
									
									Console.WriteLine("INDICATE WHICH ALGORITHM YOU WISH TO TEST ");
									Console.WriteLine("1. ");
									Console.WriteLine("2. MergeSort");
									Console.WriteLine("3. ");
									choice3 = int.Parse(Console.ReadLine());
									switch (choice3)
									{
										case 1:
											Console.WriteLine("Codes Not Available!!");
											break;
										case 2:
											AdvTestValue.RunMergeSort();
											Console.WriteLine("Press Enter to continue...");
											Console.ReadLine();
											break;
										case 3:
											Console.WriteLine("Codes Not Available!!");
											break;

									}
									break;									
							}
						} while (choice2 != 99);
						break;
					case 2:
						do
						{
							Console.WriteLine("INDICATE WHICH SORTING CLASS YOU WISH TO TEST ");
							Console.WriteLine("1. Basic Sorting");
							Console.WriteLine("2. Optimized Sorting");
							Console.WriteLine("3. Advanced Sorting");
							Console.WriteLine("99. TERMINATE PROCESSING");

							choice4 = int.Parse(Console.ReadLine());
							switch (choice4)
							{
								case 1:
									Console.WriteLine("INDICATE WHICH ALGORITHM YOU WISH TO TEST ");
									Console.WriteLine("1. BubbleSort (Iterative)");
									Console.WriteLine("2. Recursive BubbleSort");
									choice3 = int.Parse(Console.ReadLine());
									switch (choice3)
									{
										case 1:
											int[] holdARR = FillOut.ReadStoreInArray("Data.txt");
											CreateTest.bubbleSortOut(holdARR);
											Char ans;
											int val;
											do
											{
												Console.WriteLine("Would you like to get a value at an index, Y or N");
												ans = char.Parse(Console.ReadLine());
												Console.WriteLine("Enter index");
												val = CreateTest.getInt(holdARR, int.Parse(Console.ReadLine()));
												Console.WriteLine(val);
	
											} while (ans != 'N');
											Console.WriteLine("Press Enter to continue...");
											Console.ReadLine();
											break;
										case 2:
											holdARR = FillOut.ReadStoreInArray("Data.txt");
											CreateTest.REcursiveSortOut(holdARR);
											Char ans1;
											
											do
											{
												Console.WriteLine("Would you like to get a value at an index, Y or N");
												ans1 = char.Parse(Console.ReadLine());
												Console.WriteLine("Enter index");
												val = CreateTest.getInt(holdARR, int.Parse(Console.ReadLine()));
												Console.WriteLine(val);

											} while (ans1 != 'N');
											Console.WriteLine("Press Enter to continue...");
											Console.ReadLine();
											break;

									}
									break;
								case 2:
									Console.WriteLine("Codes Not Available!!");
									break;
								case 3:
									Console.WriteLine("Codes Not Available!!");
									break;
							}
						} while (choice4 != 99);
						break;

				}


				
			} while (choice != 9);
			Console.WriteLine("Press enter to continue...");
			Console.ReadLine();
		
		}
	}
}
