using System;
class Full_Dynamic_Jagged_Array
{
	static void Main()
	{
		Console.Write("Enter the size of Rows for 2d jagged array: ");
		int r = int.Parse(Console.ReadLine());
		int[][] arr = new int[r][];
		Console.WriteLine("\nEnter the size of Columns for each Rows :- \n");
		//Loop for get all Row's Columns size from the User
		
		for(int x=0;x<arr.Length;x++)
		{
			Console.Write("arr["+x+"] row = ");
			arr[x] = new int[int.Parse(Console.ReadLine())];
		}
		Console.WriteLine();	
		//Loop for get all Elements from the User
		
		for(int x=0;x<arr.Length;x++)
		{
			for(int y=0;y<arr[x].Length;y++)
			{
				Console.Write("arr ["+x+"]["+y+"] : ");
				arr[x][y] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine();
		}
		//Loop for Print all Elements
		
		for(int x=0;x<arr.Length;x++)
		{
			for(int y=0;y<arr[x].Length;y++)
			{
				Console.Write("arr ["+x+"]["+y+"] = "+arr[x][y]+"  ");
			}
			Console.WriteLine();
		}
		Console.WriteLine();
	}
}
