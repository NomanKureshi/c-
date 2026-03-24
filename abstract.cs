using System;
class demo
{
	static void Main()
	{
		xyz x = new xyz();
		x.fun();
		x.abs_method();
		Console.ReadLine();
	}
}
public abstract class abc
{
public void fun()
{
	Console.WriteLine("hi abc ");
}
public abstract void abs_method();
}
public class xyz : abc 
{
	public override void abs_method()
	{
		Console.WriteLine("hello abstract");
	}
}