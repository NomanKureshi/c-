using System;
class arr
{
	static void Main()
{
		int [][][] a = new int[3][][];
		
		a[0] = new int[5][];
		a[1] = new int[4][];
		a[2] = new int[3][];
		
		a[0][0] = new int[5];
		a[0][1] = new int[5];
		a[0][2] = new int[5];
		
		a[1][0] = new int[3];
		a[1][1] = new int[3];
		a[1][2] = new int[3];		
		Console.WriteLine(a[0].Length);//row-size
		Console.WriteLine(a[1].Length);//row-size		
		Console.WriteLine(a[2].Length);//row-size
		
		Console.WriteLine(a[0][0].Length);//col-size
		Console.WriteLine(a[0][1].Length);//col-size
		
		Console.WriteLine(a[1][0].Length);//col-size
		Console.WriteLine(a[1][1].Length);//col-size
		Console.WriteLine(a[1][2].Length);//col-size		

		Console.WriteLine(a[2][1].Length);//col-size
		Console.WriteLine(a[2][2].Length);//col-size
		Console.WriteLine(a[0][5][0]);//element		
}
}