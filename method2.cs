using System;
class demo
{
	static void Main()
	{
		xyz obj2 = new xyz();
		obj2.show();
		obj2.show();
		obj2.display();
		Console.WriteLine();
	}
}
public class abc
// {
	public void display()
	{
		Console.WriteLine("This is display");
	}
}
public class xyz : abc
{
	public void show()
	{
		Console.WriteLine("This is show");
		hello();
		display();
	}
	public void hello()
	{
		Console.WriteLine("This is hello");
	}
} 