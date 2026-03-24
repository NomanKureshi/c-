//Hierarchical Interface Inheritance
using System;
interface Interface
{ 
    void Parent_fun();
}
class N : Interface 
{
    public void Parent_fun()
	{
        Console.WriteLine("Parent Interface Method Using Class A ");
    }
}
class K : Interface
{
    public void Parent_fun()
	{
        Console.WriteLine("Parent Interface Method Using Class B ");
    }
}
class Hierarchical_Interface
{
    public static void Main()
	{
        N N_obj = new N();
        N_obj.Parent_fun();
        K K_obj = new K();
        K_obj.Parent_fun();
        Console.ReadLine();
    }
}