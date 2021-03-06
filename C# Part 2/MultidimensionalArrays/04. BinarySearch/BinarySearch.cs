﻿//Problem 4. Binary search
//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
        static void Main()
        {
            Console.Write("Enter a number N (size of array): ");
		int n = int.Parse(Console.ReadLine());

		Console.Write("Enter a number K: ");
		int k = int.Parse(Console.ReadLine());

		int[] numbers = new int[n];
		Console.WriteLine("\nEnter {0} number(s) to array: ", n);
		for (int i = 0; i < numbers.Length; i++)
		{
			Console.Write("   {0}: ", i + 1);
			numbers[i] = int.Parse(Console.ReadLine());
		}

		PrintLargestNumber(numbers, k);
	}

	
	static void PrintLargestNumber(int[] numbers, int k)
	{
		Array.Sort(numbers);

		int index = Array.BinarySearch(numbers, k);
		index = index >= 0 ? index : (index == -1 ? -1 : Math.Abs(index + 2));

		if (index != -1)
		{
			Console.WriteLine("\nFound smaller or equal number to K = {0}", k);
			Console.WriteLine("Result number: {0}\n", numbers[index]);
		}
		else
		{
			Console.WriteLine("\n- There is no smaller or equal to K = {0} number in array!\n", k);
		}
	}
}

