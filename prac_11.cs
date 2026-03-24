using System;
class NK
{	
	static void Main()
	{
		int [,] a = new int[2,3];
		a[0,0]=6;
		a[0,1]=6;
		a[0,2]=4;
		a[1,0]=3;
		a[1,1]=2;
		a[1,2]=2;
		Console.WriteLine("total number of element:" + a.Length);
		Console.WriteLine("with massage "+a[0,0]);
		Console.WriteLine("with massage "+a[0,1]);
		Console.WriteLine("with massage "+a[0,2]);
		Console.WriteLine("with massage "+a[1,0]);
		Console.WriteLine("with massage "+a[1,1]);
	    Console.WriteLine("with massage "+a[1,2]);	
	}
}