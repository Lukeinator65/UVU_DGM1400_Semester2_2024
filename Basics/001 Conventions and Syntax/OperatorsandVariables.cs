using System;

public class OperatorsAndVariables 
{
    public Food hamBurger;
    public Side frenchFry;
    public Employee youngJimmy;
    public Combo foodCombo;

    public void Main()
    {
        hamBurger = new Food();
        frenchFry = new Side();
        youngJimmy = new Employee();
		foodCombo = new Combo();
		
        Console.WriteLine("Hello, welcome to Burger Mart!");
        Console.WriteLine("My name is " + youngJimmy.employeeName + " and I'm " + youngJimmy.employeeAge + " years old!" );
        Console.WriteLine("Would you like one of our " + hamBurger.foodName + "s?" + " It's only $" + hamBurger.burgerPrice + "!");
        Console.WriteLine("Or how about one of our " + frenchFry.foodName + "?" + " They're always fresh and only $" + frenchFry.fryPrice + "!");
		foodCombo.comboFry += hamBurger.burgerPrice;
		Console.WriteLine("You can also get them together for only $" + foodCombo.comboFry + "!");
    }
}

public class Food {
    public int pickleCount = 4;
    public string foodName = "Hamburger";
    public float burgerPrice = 9.99f;
}

public class Side {
    public int fryCount = 25;
    public string foodName = "French Fries";
    public float fryPrice = 2.99f;
}

public class Employee {
    public string employeeName = "Jimmy";
    public int employeeAge = 17;
}

public class Combo {
	public float comboFry = 1.01f;
}