using System;
class demo
{
	static void Main()
	{
		xyz obj1 = new xyz();
		xyz obj2 = new xyz();
		Console.ReadLine();
		Console.WriteLine("Main");
	}
}
public class xyz
{
	public xyz()
	{
		Console.WriteLine("hello normal");
	}
	~xyz()
	{
		Console.WriteLine("hi");
	}
}