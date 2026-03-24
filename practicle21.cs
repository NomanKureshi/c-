using System;
class Copy_Constructor
{
	static void Main()
	{
		NK obj1 = new NK(18);
		NK obj2 = new NK(19);
		NK obj3 = new NK(obj1,obj2);
		obj3.show(obj1,obj2);
		Console.ReadLine();
	}
}
class NK
{ 
// The Default Access Specifier For Any Class Is Internal Which Can Be Use From Same File
	int nk;
	public NK(int n)
	{
		nk = n;
		Console.WriteLine("Parameterized Constructor");
	}
	public 	NK(NK n,NK k){ // Copy Constructor
		Console.WriteLine("\nCopy Constructor\n");
		nk = n.nk+k.nk;
	}
	public void show(NK n1,NK n2){
		Console.WriteLine("Value of obj1.nk = "+n1.nk);
		Console.WriteLine("Value of obj2.nk = "+n2.nk);
		Console.WriteLine("\nsum of obj1.nk + obj2.nk = "+nk);
	}
}