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
{
	public void print()
	{
		Console.WriteLine("Hello print child of abc");
	}
}
public class pqr : xyz
{
	public void method()
	{
		Console.WriteLine("hello pqr sub child of xyz");
		display();
		Console.WriteLine("back to sub child");
		print();
	}
} 