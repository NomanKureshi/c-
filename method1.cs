using System;
class demo
{
	static void Main()
	{
		abc obj1 = new abc();
		xyz obj2 = new xyz();
		
		obj1.disp();
		obj2.show();
		
		obj2.disp();
		Console.WriteLine();
	}
}
public class abc
{
	public void disp()
	{
		Console.WriteLine("This is display");
	}
}
public class xyz : abc 
{
	public void show()
	{
		Console.WriteLine("This is show");
	}
}