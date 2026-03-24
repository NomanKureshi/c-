using System;
class demo
{
	static void Main()
	{
		abc obj1 = new abc();
		abc obj2 = new abc();
		obj1.show();
		obj2.display();
		Console.WriteLine("This is main");
		obj1.show();
	}
}
public class abc
{
	public void show()
	{
		Console.WriteLine("This is show");
		display();
	}
	public void display()
	{
		Console.WriteLine("This is display");
	}
}