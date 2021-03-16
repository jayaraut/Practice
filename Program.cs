using System;


public class Program
{
	public static void Main()
	{
		    
		int[] arr = {3,7,1,2,8,4,5 };
		int n = 1;
		int rem = 0;
		Array.Sort(arr);
		
		//Array.ForEach<int>(arr, s => Console.WriteLine(s));
		
		foreach(var a in arr)
		{
			
			if(n == a)
			{
				
				n++;
			}
			else{
				rem = n;
				n=n+2;
			}
		}
		
		Console.WriteLine("The missing number is:"+ rem);
		
	}
}
