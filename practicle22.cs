using System;
class Mix_Constructor
{
	static void Main()
	{
		NK obj1 = new NK();
		NK obj2 = new NK(99,199);
		Console.ReadLine();
	}
}
class NK
{
	public NK()
	{// Default Constructor
		Console.WriteLine("Default Constructor");
	}
	public NK(int n,int k)
	{// Parameterized Constructor
		Console.WriteLine("Parameterized Constructor");
	}
	static NK()
	{// Static Constructor
		Console.WriteLine("Static Constructor");
	}
}