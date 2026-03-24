using System;
class demo
{
	static void Main()
	{
		pqr p = new pqr();
		p.method();
		Console.ReadLine();
	}
}
public class abc
{
	protected void display()
	{
		Console.WriteLine("This is display");
	}
}
public class xyz : abc
{}
public class pqr : xyz
{
	public void method()
	{
		Console.WriteLine("hello sub child ");
		display();
		Console.WriteLine("back to sub child");
	}
} 