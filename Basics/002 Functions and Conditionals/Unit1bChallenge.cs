using System;
					
public class Unit1bChallenge
{
	public Temperature tempInCelcius;
	public Grader examGrader;
	public SchoolSubject favSubject;
	
	public void Main(string[] args)
	{
		tempInCelcius = new Temperature();
		examGrader = new Grader();
		favSubject = new SchoolSubject();
		
		Console.WriteLine("Enter the current temperature in Celcius:");
		int temp = Convert.ToInt32(Console.ReadLine()); //Takes user input and defines the temp
		Console.WriteLine("Enter an exam grade:");
		int grade = Convert.ToInt32(Console.ReadLine()); //Takes user input and defines the grade
		Console.WriteLine("Enter your favorite subject:");
		string subject = Console.ReadLine();
		tempInCelcius.CheckTemp(temp); //Runs Temperature Check Operation
		examGrader.CheckGrade(grade); //Runs Grade Check Operation
		favSubject.CheckSubject();
    }
}

public class Temperature {
	public void CheckTemp (int temp){
		if(temp > 40) { //If user input temp is greater than 30, it will tell user to stay hydrated
		Console.WriteLine("");
		Console.WriteLine("It's " + temp + "° celcius outside!" + " That's a bit too hot. May sure to stay inside, drink and stay cool!");
		} else if(40 > temp && temp >= 30) { //If user input temp is less than 30 and greater than or equal to 20, it will tell user that its nice out
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty hot, so make sure to wear short clothes and to stay hydrated!");
		} else if(30 > temp && temp >= 18) {
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty warm. You may not need to wear short clothes, but you should still stay hydrated!");
		} else if(18 > temp && temp >= 5) {
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's a bit cool, so you might want to wear a light jacket.");
		} else { //If user input temp is anything else, it will tell user to wear a jacket
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty cold! You might want to wear a heavy jacket!");
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

public class SchoolSubject {
	public enum Subjects {
		English,
		Math,
		History,
		Science,
		Art,
		PE
	}
	
	public Subjects favSubject = Subjects.English;

	public void CheckSubject () {
		switch (favSubject){
			case Subjects.English:
				Console.WriteLine("");
				Console.WriteLine("Your favorite subject is English! Make sure to check your grammar and spelling!");
				break;
			case Subjects.Math:
				Console.WriteLine("");
				Console.WriteLine("Your favorite subject is Math! Make sure to keep practicing your equations!");
				break;
			case Subjects.History:
				Console.WriteLine("");
				Console.WriteLine("Your favorite subject is History! Make sure you know your facts!");
				break;
			case Subjects.Science:
				Console.WriteLine("");
				Console.WriteLine("Your favorite subject is Science! Make sure you know the periodic table!");
				break;
			case Subjects.Art:
				Console.WriteLine("");
				Console.WriteLine("Your favorite subject is Art! Make sure to put your heart into your work!");
				break;
		}

	}
}