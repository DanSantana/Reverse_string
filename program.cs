using System;
					
public class Program
{
	public static void Main()
	{	//reverse string
		string reverse = null, input = null;
		Console.WriteLine("Reverse words:");
		Console.Write("Insert the word to be reversed:");
		input = Console.ReadLine();
		
		char[] stArray = input.ToCharArray();
		Array.Reverse(stArray);
		reverse = new String(stArray);
		
		Console.WriteLine("Ther reverse of {0} is {1}.",input,reverse);		
	}
}
