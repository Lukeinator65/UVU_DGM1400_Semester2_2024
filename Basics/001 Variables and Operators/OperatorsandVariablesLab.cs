using System;

public class OperatorsAndVariables 
{ //Declares classes and associated variable names
    public Food hamBurger;
    public Side frenchFry;
    public Employee youngJimmy;
    public Combo foodCombo;

    public void Main()
    {
        //Declaration for what class each variable name belongs to
        hamBurger = new Food();
        frenchFry = new Side();
        youngJimmy = new Employee();
		foodCombo = new Combo();
		
        Console.WriteLine("Hello, welcome to Burger Mart!");
        Console.WriteLine("My name is " + youngJimmy.employeeName + " and I'm " + youngJimmy.employeeAge + " years old!" );
        Console.WriteLine("Would you like one of our " + hamBurger.foodName + "s?" + " It's only $" + hamBurger.burgerPrice + " and comes with + hamBurger.pickeCount +
        hamBurger.pickleCount + " delectable pickles!");
        Console.WriteLine("Or how about some of our " + frenchFry.foodName + "?" + " You get " + frenchFry.fryCount + 
        " always fresh and only $" + frenchFry.fryPrice + "!");
		foodCombo.comboFry += hamBurger.burgerPrice; //Variable manipulation to determine price of the combo
		Console.WriteLine("You can also get them together for only $" + foodCombo.comboFry + "!");
    }
}

public class Food { //Declares Pickle Count, Name, and Price Variables for the burger
    public int pickleCount = 4;
    public string foodName = "Hamburger";
    public float burgerPrice = 9.99f;
}

public class Side { //Declares Fry count, Name, and Price Variables for the fries
    public int fryCount = 25;
    public string foodName = "French Fries";
    public float fryPrice = 2.99f;
}

public class Employee { //Declares Name and Age Variables for the employee
    public string employeeName = "Jimmy";
    public int employeeAge = 17;
}

public class Combo { //Declares the combo price variable for the fries
	public float comboFry = 1.01f;
}