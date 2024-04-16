using System;
					
public class Unit1bLab
{
	public Temperature tempInCelcius;
	public Grader examGrader;
	
	public void Main(string[] args)
	{
		tempInCelcius = new Temperature();
		examGrader = new Grader();
		
		Console.WriteLine("Enter the current temperature in Celcius:");
		int temp = Convert.ToInt32(Console.ReadLine()); //Takes user input and defines the temp
		Console.WriteLine("Enter an exam grade:");
		int grade = Convert.ToInt32(Console.ReadLine()); //Takes user input and defines the grade
		tempInCelcius.CheckTemp(temp); //Runs Temperature Check Operation
		examGrader.CheckGrade(grade); //Runs Grade Check Operation
    }
}

public class Temperature {
	public void CheckTemp (int temp){
		if(temp > 40) { //If user input temp is greater than 30, it will tell user to stay hydrated
		Console.WriteLine("");
		Console.WriteLine("It's " + temp + "° celcius outside!" + " That's a bit too hot. May sure to stay inside, drink and stay cool!");
	} else if(40 > temp && temp >= 30) { //If user input temp is less than 30 and greater than or equal to 20, it will tell user that its nice out
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty hot, so make sure to wear short cloths and to stay hydrated!");
		} else { //If user input temp is anything else, it will tell user to wear a jacket
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " Make sure to wear a jacket!");
		
		}
	}
}

public class Grader {
	public void CheckGrade (int grade){
		if (grade >= 90) { //If user input grade is greater than or equal to 90, it will tell user they have an A
		Console.WriteLine("");
		Console.WriteLine("You got a " + grade + " on your exam!" + " That's an A!");
	} else if(90 > grade && grade >= 80) { //If user input grade is less than 90 and is greater than or equal to 80, it will tell user they have a B
			Console.WriteLine("");
			Console.WriteLine("You got a " + grade + " on your exam!" + " That's a B!");
		} else if(80 > grade && grade >= 70) { //If user input grade is less than 80 and is greater than or equal to 70, it will tell user they have an C
			Console.WriteLine("");
			Console.WriteLine("You got a " + grade + " on your exam." + " That's a C.");
			} else if(70 > grade && grade >= 60) { //If user input grade is less than 70 and is greater than or equal to 60, it will tell user they have an D
				Console.WriteLine("");
				Console.WriteLine("You got a " + grade + " on your exam." + " That's a D.");
				} else { //If user input is less than 60, it will tell user they have an F
					Console.WriteLine("");
					Console.WriteLine("Oh, that's not good. You got a " + grade + " on your exam." + " That's a F.");
		}
	}
}