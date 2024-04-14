using System;

public class Unit1AChallenge
{
    public Years someDecades;
    public Income multIncome;

    public void Main(string[] args)
    {
		someDecades = new Years();
		multIncome = new Income();
		
		Console.WriteLine("Welcome to Decade Income Multiplier!");
		Console.WriteLine("");
		Console.WriteLine("For each decade, you money will be multiplied by that amount of decades!");
		Console.WriteLine("");
		
		Console.WriteLine("Please enter your name:");
		string name = Console.ReadLine();
		
        Console.WriteLine("Please enter your age:");
        int age = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter an amount of money including cents:");
		float money = float.Parse(Console.ReadLine());
		
		Console.WriteLine("");
		Console.WriteLine("Your name is " + name);
		Console.WriteLine("and you are " + age + " years old.");
		Console.WriteLine("");
		Console.WriteLine("You have $" + money + " in your bank account.");
		
		money *= multIncome.incomeTwoDecades;
		age += someDecades.twoDecades;
		Console.WriteLine("");
		Console.WriteLine("In two decades, you will be " + age + " years old.");
		Console.WriteLine("and your money will multiply up to $" + money); 
		
		money *= multIncome.incomeFiveDecades;
		age += someDecades.fiveDecades;
		Console.WriteLine("");
		Console.WriteLine("In three more decades, you will be " + age + " years old.");
		Console.WriteLine("and your money will multiply up to $" + money); 
		
		money *= multIncome.incomeTenDecades;
		age += someDecades.tenDecades;
		Console.WriteLine("");
		Console.WriteLine("Finally, in five more decades, you will be " + age + " years old.");
		Console.WriteLine("and your money will multiply up to $" + money); 
    }
}

public class Years {
    public int twoDecades = 20;
    public int fiveDecades = 30;
    public int tenDecades = 50;
}

public class Income {
	public float incomeTwoDecades = 2.0f;
	public float incomeFiveDecades = 3.0f;
	public float incomeTenDecades = 5.0f;
}