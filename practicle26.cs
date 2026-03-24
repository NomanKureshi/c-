    using System;
    class Parent
	{
        protected int square(int n)
		{
            return (n*n);
        }
    } 
    class Child : Parent
	{
        public int child(int n)
		{
            return square(n);
        }
    }
    class Sub_Child : Child
	{
        public int sub_child()
		{
            Console.Write("Enter a Value to find it's Square : ");
            return child(int.Parse(Console.ReadLine()));
        }
    }
    class NK
	{
        public static void Main()
		{
            Sub_Child nb = new Sub_Child();
            Console.WriteLine("Square = " + (nb.sub_child()));
            Console.ReadLine();
        }
    }