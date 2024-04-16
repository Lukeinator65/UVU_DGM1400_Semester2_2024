using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4, 3);
		myOperator.Compare(3, 4);
		myOperator.CheckPassword("FuNnyM0nkee");
		myOperator.CheckPassword("OU812");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare(int vaule, int value2) {
		if(vaule > value2) {
			Console.WriteLine("");
			Console.WriteLine("True, the first is greater.");
		} else {
			Console.WriteLine("");
			Console.WriteLine("Fale, the second is NOT greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("");
			Console.WriteLine("Correct Password! Logging in...");
		} else {
			Console.WriteLine("");
			Console.WriteLine("Incorrect Password. Please try again.");
		}
	}
}