using System;
class No_Name
{
	public static void Main()
	{
		NK a = new NK();
		Console.Write("Enter Value of N : ");
		a.n = int.Parse(Console.ReadLine());
		Console.WriteLine("Value of N = " + a.n);
		Console.ReadLine();
	}
}
class NK
{
	public int n;
}	