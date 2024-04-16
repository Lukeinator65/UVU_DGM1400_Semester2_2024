using System;
					
public class Unit1bLab
{
	public Temperature tempInCelcius;
	
	public void Main(string[] args)
	{
		tempInCelcius = new Temperature();
		
		Console.WriteLine("Enter the current temperature in Celcius:");
		int temp = Convert.ToInt32(Console.ReadLine());
		tempInCelcius.CheckTemp(temp);
    }
}

public class Temperature {
	public void CheckTemp (int temp){
		if(temp > 30) {
		Console.WriteLine("");
		Console.WriteLine("It's " + temp + "° celcius outside!" + " Make sure to stay hyrdated!");
	} else if(temp >= 20) {
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " Its's very nice out!");
		} else {
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " Make sure to wear a jacket!");
		
		}
	}
}