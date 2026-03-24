//read only property
using System;
class demo
{
	static void Main()
	{
		abc a = new abc();
		a.nm_pr=20;
		//a.x=20;
		Console.WriteLine(a.nm_pr);
	}
}
class abc
{
	int x;
public int nm_pr
{
	set
	{
		x=value;
	} 	
	get
	{
		return x;	
	}
}
}