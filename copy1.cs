using System;
public class Employee
{
    public int Age;
    public Employee(int age)
    {
        Age = age;
    }
    public void Display()
	{
		Console.WriteLine("Age: {0}", Age);
	}
}
class Prog
{
    static void Main()
    {
        Employee emp1 = new Employee(30);
        emp1.Display(); //Output: Age: 30
    }
}
