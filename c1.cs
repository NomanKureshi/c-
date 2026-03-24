// write only property
using System;
class demo
{
    static void Main()
    {
        abc a = new abc();
        a.nm_pr = 20;
        a.show();
        Console.ReadLine();
    }
}
class abc
{
    int x;
    public int nm_pr
    {
        set
        {
            x = value;
        }
    }
    public void show()
    {
        Console.WriteLine("inside method " + x);
    }
}