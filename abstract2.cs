using System;
class demo
{
	static void Main()
	{
		xyz x = new xyz();
		x.fun();
		Console.ReadLine();
	}
}
public abstract class abc
{
public void fun()
{
	Console.WriteLine("hi abc ");
}
}
public class xyz : abc 
{
}