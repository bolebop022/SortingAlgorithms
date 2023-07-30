using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace WRAV_Capstone_Assignment
{
	class PopulateList
	{

		Random Rand = new Random();
		ArrayList holdArrays = new ArrayList();
		ArrayList holdArrayList = new ArrayList();

		//This following populates an array with data it reads from a text file
		public int[] ReadStoreInArray(string filename)
		{
			int arraySize = 0;
			StreamReader counter = new StreamReader(filename);
			while(!counter.EndOfStream)
			{
				Console.ReadLine();
				arraySize++;
			}
			counter.Close();
			int[] Array = new int[arraySize];
			StreamReader reader = new StreamReader(filename);
			int storeAt = 0;

			while (!reader.EndOfStream)
			{
				Array[storeAt] = int.Parse(reader.ReadLine());
				storeAt++;
			}
			reader.Close();
			return Array;
		}

		//The following populates ArrayList with data it reads from  a textfile
		public ArrayList ReadStoreInArrayList(string filename)
		{
			ArrayList List = new ArrayList();
			StreamReader reader = new StreamReader(filename);

			while (!reader.EndOfStream)
			{
				List.Add(int.Parse(reader.ReadLine()));
			}
			reader.Close();
			return List;
		}



		public ArrayList createIntArrays()
		{
			//Declaring and populating first array
			int[] FirstArray = new int[100];
			for (int i = 0; i < 100; i++)
			{
				FirstArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(FirstArray);

			// Declaring and populating second array
			int[] SecondArray = new int[500];
			for (int i = 0; i < 500; i++)
			{
				SecondArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(SecondArray);

			//Declaring and populating third array
			int[] ThirdArray = new int[1000];
			for (int i = 0; i < 1000; i++)
			{
				ThirdArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(ThirdArray);


			//Declaring and populating first Array
			int[] FourthArray = new int[5000];
			for (int i = 0; i < 5000; i++)
			{
				FourthArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(FourthArray);

			//Declaring and populating second Array
			int[] FifthArray = new int[10000];
			for (int i = 0; i < 10000; i++)
			{
				FifthArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(FifthArray);

			//Declaring and populating third Array
			int[] SixthArray = new int[50000];
			for (int i = 0; i < 50000; i++)
			{
				SixthArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(SixthArray);

			//Declaring and populating fourth Array
			int[] SeventhArray = new int[100000];
			for (int i = 0; i < 100000; i++)
			{
				SeventhArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(SeventhArray);

			//Declaring and populating fifth Array
			int[] EighthArray = new int[500000];
			for (int i = 0; i < 500000; i++)
			{
				EighthArray[i] = Rand.Next(int.MaxValue);
			}
			holdArrays.Add(EighthArray);

			return holdArrays;
		}


		public ArrayList createArrayLists()
		{
			//Declaring and populating first ArrayList
			ArrayList FirstList = new ArrayList();
			for (int i = 0; i < 100; i++)
			{
				FirstList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(FirstList);

			//Declaring and populating seond arraylist
			ArrayList SecondList = new ArrayList();
			for (int i = 0; i < 500; i++)
			{
				SecondList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(SecondList);

			// declaring and populating third arraylist
			ArrayList ThirdList = new ArrayList();
			for (int i = 0; i < 1000; i++)
			{
				ThirdList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(ThirdList);

			//declaring and populating fourth arraylist
			ArrayList FourthList = new ArrayList();
			for (int i = 0; i < 5000; i++)
			{
				FourthList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(FourthList);


			//Declaring and populating second ArrayList
			ArrayList FifthList = new ArrayList();
			for (int i = 0; i < 10000; i++)
			{
				FifthList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(FifthList);


			//Declaring and populaating third ArrayList
			ArrayList SixthList = new ArrayList();
			for (int i = 0; i < 50000; i++)
			{
				SixthList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(SixthList);


			//Declaring and populating fourth ArrayList
			ArrayList SeventhList = new ArrayList();
			for (int i = 0; i < 100000; i++)
			{
				SeventhList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(SeventhList);

			//Declaring and populating fifth ArrayList
			ArrayList EighthList = new ArrayList();
			for (int i = 0; i < 500000; i++)
			{
				EighthList.Add(Rand.Next(int.MaxValue));
			}
			holdArrayList.Add(EighthList);

			return holdArrayList;
		}
	}
}
