using System;
class Enum
{

	public static void SingleArr()
	{
		int a;
		Console.WriteLine("Enter 1d size");
		a = Convert.ToInt32(Console.ReadLine());
		int[] one = new int[a];
		Console.WriteLine("Enter 1d elements");
		for (int i = 0; i < a; i++)
		{
			one[i] = Convert.ToInt32(Console.ReadLine());
		}
		for (int i = 0; i < a; i++)
		{
			Console.WriteLine(one[i]);
		}
		Console.WriteLine("Want to perform operations on selected array (y/n):");
		char c;
		c = Console.ReadLine()[0];
		if (c == 'y' || c == 'Y')
		{
			Enum.OneOperations(one, a);
		}


	}
	static int OneOperations(int[] one, int a)
	{
		int op;
		Console.WriteLine(" 1. length of Arr \n 2. sort \n 3. reverse of arr");
		op = Convert.ToInt32(Console.ReadLine());
		switch (op)
		{
			case 1:
				Console.WriteLine(one.Length);
				break;
			case 2:
				Array.Sort(one);
				for (int i = 0; i < a; i++)
					Console.Write(one[i] + " ");
				break;
			case 3:
				Array.Reverse(one);
				for (int i = 0; i < a; i++)
					Console.Write(one[i] + " ");
				break;

		}
		return 0;
	}

	public static void twoArr()
	{
		int b, c;
		Console.WriteLine("Enter 2d size");
		b = Convert.ToInt32(Console.ReadLine());
		c = Convert.ToInt32(Console.ReadLine());
		int[,] two = new int[b, c];
		Console.WriteLine("Enter 2d elements");
		for (int i = 0; i < b; i++)
		{
			for (int j = 0; j < c; j++)
			{
				two[i, j] = Convert.ToInt32(Console.ReadLine());
			}
		}
		for (int i = 0; i < b; i++)
		{
			for (int j = 0; j < c; j++)
			{
				Console.Write(two[i, j] + " ");
			}
			Console.WriteLine("\n");
		}

		Console.WriteLine("Want to perform operations on selected array (y/n):");
		char c;
		c = Console.ReadLine()[0];
		if (c == 'y' || c == 'Y')
		{
			Enum.twoOperations(one, a);
		}
	}
	static int twoOperations(int[,] two, int a)
	{
		int op;
		Console.WriteLine(" 1. length of Arr \n 2. sort \n 3. reverse of arr");
		op = Convert.ToInt32(Console.ReadLine());
		switch (op)
		{
			case 1:
				Console.WriteLine(one.Length);
				break;
			case 2:
				Array.Sort(one);
				for (int i = 0; i < a; i++)
					Console.Write(one[i] + " ");
				break;
			case 3:
				Array.Reverse(one);
				for (int i = 0; i < a; i++)
					Console.Write(one[i] + " ");
				break;

		}
		return 0;
	}

	public static void JaggedArr()
	{
		int r;
		Console.WriteLine("Enter row size");
		r = Convert.ToInt32(Console.ReadLine());
		int[][] Jagged = new int[r][];
		for (int i = 0; i < r; i++)
		{
			Console.WriteLine("Enter column size for row " + i + "");
			int co;
			co = Convert.ToInt32(Console.ReadLine());
			Jagged[i] = new int[co];
		}
		Console.WriteLine("Enter jagged elements");
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < Jagged[i].Length; j++)
			{
				Jagged[i][j] = Convert.ToInt32(Console.ReadLine());

			}
		}
		for (int i = 0; i < r; i++)
		{
			for (int j = 0; j < Jagged[i].Length; j++)
			{
				Console.Write(Jagged[i][j]);

			}
			Console.Write("\n");
		}



	}
	public void Switch(int nu)
	{
		switch (nu)
		{
			case 1:
				Enum.SingleArr();
				break;
			case 2:
				Enum.twoArr();
				break;
			case 3:
				Enum.JaggedArr();
				break;
		}
	}

	public static void Main(String[] args)
	{
		int n;
		Console.WriteLine(" 1. single Arr \n 2. 2d Arr \n 3.JaggedArr");
		n = Convert.ToInt32(Console.ReadLine());
		Enum sw = new Enum();
		sw.Switch(n);

	}
}