using System;
					
public class Unit1bLab
{
	public Temperature tempInCelcius;
	
	public void Main(string[] args)
	{
		tempInCelcius = new Temperature();
		
		Console.WriteLine("Enter the current temperature in Celcius:"); //Ask for user input
		int temp = Convert.ToInt32(Console.ReadLine()); //Takes user input and defines the temp
		tempInCelcius.CheckTemp(temp); //Runs Temperature Check Operation
    }
}

public class Temperature {
	public void CheckTemp (int temp){
		if(temp > 30) { //If user input temp is greater than 30, it will tell user to stay hydrated
		Console.WriteLine("");
		Console.WriteLine("It's " + temp + "° celcius outside!" + " Make sure to stay hyrdated!");
	} else if(temp >= 20) { //If user input temp is greater than or equal to 20, it will tell user that its nice out
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " Its's very nice out!");
		} else { //If user input temp is anything else, it will tell user to wear a jacket
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " Make sure to wear a jacket!");
		
		}
	}
}