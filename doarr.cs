using System;
class demo
{
	public static void Main(string[] args)
	{
		int i=0;
		int [] a = new int[5]{2,4,5,3,4};
		do
		{
			Console.WriteLine(a[i]);
			i++;
		}while(i<5);
	}
}