using System;
					
public class Program
{
	public Operations myOperators;
	
	public void Main()
	{
		myOperators = new Operations();
		
		myOperators.Compare(50, 10);
		myOperators.Compare(32, 56);
	}
}

public class Operations {
	public void Compare(int x, int y){
		if(x > y) {
			Console.WriteLine("");
			Console.WriteLine("Hello World!");
		} else {
			Console.WriteLine("");
			Console.WriteLine("Goodbye World...");
		}
	}
}