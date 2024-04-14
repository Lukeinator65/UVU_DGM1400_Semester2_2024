public class Variables 
{
    public Food hamBurger;
    public Side 

    public void Main()
    {
        hamBurger = new Food();
        frenchFry = new Side();
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