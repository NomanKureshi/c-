using System;
class NK
{
	static void Main()
	{
		int d,r,c;
		Console.Write("enter number of dimension:");
		d=int.Parse(Console.ReadLine());
		Console.Write("enter number of row:");
		r=int.Parse(Console.ReadLine());
		Console.Write("enter number of column:");
		c=int.Parse(Console.ReadLine());
		int [,,] a = new int[d,r,c];
		Console.WriteLine("total number of element:" + a.Length);
		for(int i=0;i<d;i++)
		{
			 for(int j=0;j<r;j++)
			 {
				 for(int k=0;k<c;k++)
				 {
					Console.Write("a[{0},{1},{2}]:",i,j,k);
					a[i,j,k] = int.Parse(Console.ReadLine());
				 }
				 Console.WriteLine();
			 }
		}
	}
}