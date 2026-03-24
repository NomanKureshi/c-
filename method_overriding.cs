using System;
class demo
{
	public static void Main()
	{
		pqr p = new pqr();
		p.method(10);
		p.method(20);
		Console.ReadLine();
	}
}
public class abc 
{
	public virtual void method(int a)
	{
		Console.WriteLine("Hi method " + a);
	}
}
public class pqr : abc 
{
	public override void method(int a)
	{
		Console.WriteLine("Hello method " + a);
	}	
}