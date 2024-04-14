using System;

public class Unit1AChallenge
{
    public Years someDecades;
    public Income someIncome;

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

        someDecades = new Years();
        someIncome = new Income();
    }
}

public class Years {
    public int twoDecades = 20;
    public int fiveDecades = 50;
    public int tenDecades = 100;
}

public class Income{
	public float incomeTwoDecades = 2.0f;
	public float incomeFiveDecades = 5.0f;
	public float incomeTenDecades = 10.0f;
}