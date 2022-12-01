using System;

public static class Globals
{
	internal static void Main()
	{
		Console.Write("Introduceti cate numere va contine sirul:");
		Console.Write("\n");
		Console.Write("n= ");


		int n;
		int max = -10000;
		int min = 10000;
		n = Convert.ToInt32(Console.ReadLine());

		Console.Write("\n");

		for (int i = 0; i < n; i++)
		{
			int nr;
			nr = Convert.ToInt32(Console.ReadLine());
			if (nr > max)
				max = nr;
			if (nr < min)
				min = nr;
		}
		Console.Write("\n");
		Console.Write("Maximul este egal cu " +  max);
		Console.Write("\n");
		Console.Write("Minimul este egal cu " +  min);


	}
}