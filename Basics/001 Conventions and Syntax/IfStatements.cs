using System;
					
public class Program
{
	public void Main()
	{
		Console.WriteLine("Welcome");
		DoMath(10, 4);
		DoMath(20, 7);
		DoMath(30, 15);
		Compare(4, 3);
		Compare(3, 4);
		CheckPassword("FuNnyM0nkee");
		CheckPassword("OU812");
	}
	
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