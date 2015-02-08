/*Problem 20.* Variations of set
Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N].
Example:
N	K	result
3	2	{1, 1} 
		{1, 2} 
		{1, 3} 
		{2, 1} 
		{2, 2} 
		{2, 3} 
		{3, 1} 
		{3, 2} 
		{3, 3}
*/

using System;
using System.Globalization;
using System.Threading;

class VariationsOfSet
{
	static int k;
	static int n;
	static int[] array;
	static bool[] used;

	static void Main()
	{
		Console.Title = "Problem 20.* Variations of set";

		Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

		Console.WriteLine("Problem 20.* Variations of set!");
		PrintSeparateLine();

		Console.Write("Enter the size of the array: n = ");
		n = int.Parse(Console.ReadLine());

		Console.Write("Enter the number the elements to calculate to variations: k = ");
		k = int.Parse(Console.ReadLine());

		PrintSeparateLine();

		array = new int[k];
		used = new bool[n];

		Console.WriteLine("All variations is:\n");
		Variations(0);
		PrintSeparateLine();
	}

	static void Variations(int index)
	{
		if (index == k)
		{
			PrintLoops();
		}
		else
		{
			for (int i = 1; i <= n; i++)
			{
				array[index] = i;
				Variations(index + 1);
			}
		}
	}

	static void PrintLoops()
	{
		Console.WriteLine("(" + String.Join(", ", array) + ")");

	}
	static void PrintSeparateLine()
	{
		Console.WriteLine(new string('-', 40));
	}
}