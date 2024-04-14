using System;

public class Unit1AChallenge
{
    public void Main(string[] args)
    {
		Console.WriteLine("Enter your name:");
		string name = Console.ReadLine();
		
        Console.WriteLine("Enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter an amount of money including cents:");
		float money = float.Parse(Console.ReadLine());
       
		Console.WriteLine("Your name is " + name);
		Console.WriteLine("and you are " + age + " years old.");
		Console.WriteLine("You have $" + money + " in your bank account.");
    }
}