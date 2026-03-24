using System;
class NK
{
	static void Main()
	{
		int r,c,d;
		Console.Write("enter number of dimension:");	
		d=int.Parse(Console.ReadLine());	
		Console.Write("enter number of rows:");		
		r=int.Parse(Console.ReadLine());
		Console.Write("enter number of columns:");		
		c=int.Parse(Console.ReadLine());
		int [,,] a = new int[d,r,c];
		Console.WriteLine("total number of element:" + a.Length);
		
		for(int i=0;i<d;i++)
		{
			 for(int j=0;j<r;j++)
			 {
				 for(int k=0;k<c;k++)
			     {
				 Console.Write("Enter a[" + i + "," + j + "," + k + "]: ");
			 	 a[i, j, k] = Convert.ToInt32(Console.ReadLine()); 
				 }
				 Console.WriteLine("");		
			 }
		}
		Console.WriteLine("\nElements of the 3D Array:");
        
		for(int i=0; i<d; i++)
        {
            Console.WriteLine("--- Dimension ");
            for(int j=0; j<r; j++)
            {
                for(int k=0; k<c; k++)
                {
					
                    Console.Write(a[i, j, k] + " ");
                }
                Console.WriteLine(); // Newline after each row
            }
            Console.WriteLine(); // Newline after each layer
        }
}
}