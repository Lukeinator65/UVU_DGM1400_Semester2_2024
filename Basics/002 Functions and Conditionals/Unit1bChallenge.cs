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
		string subject = Console.ReadLine(); //Takes user input and defines subject
		tempInCelcius.CheckTemp(temp); //Runs Temperature Check Operation
		examGrader.CheckGrade(grade); //Runs Grade Check Operation
		favSubject.CheckSubject(subject); //Runs Favorite Subject Operation
	}
}

public class Temperature
{
	public void CheckTemp(int temp)
	{
		if (temp > 40)
		{ //If user input temp is greater than 40, it will tell user to stay inside and to stay cool
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's a bit too hot. May sure to stay inside, drink and stay cool!");
		}
		else if (40 > temp && temp >= 30)
		{ //If user input temp is less than 40 and greater than or equal to 30, it will tell user that its pretty hot out
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty hot, so make sure to wear short clothes and to stay hydrated!");
		}
		else if (30 > temp && temp >= 18)
		{ //If user input temp is less than 30 and greater than or equal to 18, it will tell user that its pretty warm out
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty warm. You may not need to wear short clothes, but you should still stay hydrated!");
		}
		else if (18 > temp && temp >= 5)
		{ //If user input temp is less than 30 and greater than or equal to 18, it will tell user that its a bit cool out
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's a bit cool, so you might want to wear a light jacket.");
		}
		else
		{ //If user input temp is anything else, it will tell user that is cold and to wear a heavy jacket
			Console.WriteLine("");
			Console.WriteLine("It's " + temp + "° celcius outside!" + " That's pretty cold! You might want to wear a heavy jacket!");
		}
	}
}

public class Grader
{
	public void CheckGrade(int grade)
	{
		if (grade >= 90)
		{ //If user input grade is greater than or equal to 90, it will tell user they have an A
			Console.WriteLine("");
			Console.WriteLine("You got a " + grade + " on your exam!" + " That's an A!");
		}
		else if (90 > grade && grade >= 80)
		{ //If user input grade is less than 90 and is greater than or equal to 80, it will tell user they have a B
			Console.WriteLine("");
			Console.WriteLine("You got a " + grade + " on your exam!" + " That's a B!");
		}
		else if (80 > grade && grade >= 70)
		{ //If user input grade is less than 80 and is greater than or equal to 70, it will tell user they have an C
			Console.WriteLine("");
			Console.WriteLine("You got a " + grade + " on your exam." + " That's a C.");
		}
		else if (70 > grade && grade >= 60)
		{ //If user input grade is less than 70 and is greater than or equal to 60, it will tell user they have an D
			Console.WriteLine("");
			Console.WriteLine("You got a " + grade + " on your exam." + " That's a D.");
		}
		else
		{ //If user input is less than 60, it will tell user they have an F
			Console.WriteLine("");
			Console.WriteLine("Oh, that's not good. You got a " + grade + " on your exam." + " That's a F.");
		}
	}
}

public class SchoolSubject
{
	public enum Subjects
	{
		English,
		Math,
		History,
		Science,
		Art,
		PE,
	}

	public Subjects favSubject;
	public void CheckSubject(string subject)
	{
		if (Enum.TryParse(subject, true, out favSubject)) //Checks if the user input is equivalent to one of the subjects in the enum list, and changes value of favSubject to equating subject
		{
			switch (favSubject)
			{
				case Subjects.English: //In case subject is English, tells user to check grammar and spelling
					Console.WriteLine("");
					Console.WriteLine("Your favorite subject is English! Make sure to check your grammar and spelling!");
					break;
				case Subjects.Math: //In case subject is Math, tells user to practice equations
					Console.WriteLine("");
					Console.WriteLine("Your favorite subject is Math! Make sure to keep practicing your equations!");
					break;
				case Subjects.History: //In case subject is History, tells user to know their facts
					Console.WriteLine("");
					Console.WriteLine("Your favorite subject is History! Make sure you know your facts!");
					break;
				case Subjects.Science: //In case subject is Science, tells user to know the periodic table
					Console.WriteLine("");
					Console.WriteLine("Your favorite subject is Science! Make sure you know the periodic table!");
					break;
				case Subjects.Art: //In case subject is Art, tells user to put their heart into their work
					Console.WriteLine("");
					Console.WriteLine("Your favorite subject is Art! Make sure to put your heart into your work!");
					break;
				case Subjects.PE: //In case subject is PE, tells user to stay fit and hydrated
					Console.WriteLine("");
					Console.WriteLine("Your favorite subject is PE! Make sure to stay fit and hydrated!");
					break;
			}
		} else {
			Console.WriteLine("");
			Console.WriteLine("That is not a valid subject input.");
		}
	}
}