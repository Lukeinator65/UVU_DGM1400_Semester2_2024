public class Program
{
	public Weapon shotGun;
	public PowerUp weaponPowerUp;
	
	public void Main()
	{
		shotGun = new Weapon();
		weaponPowerUp = new PowerUp();
		
		shotGun.ammoCount ++;
		shotGun.firePower += weaponPowerUp.powerLevel;
		Console.WriteLine("Your " + shotGun.weaponName + " currently has " + shotGun.ammoCount + " shells" + ".");
		Console.WriteLine("Its damage has increased to " + shotGun.firePower + "!");
	
	}
}

public class Weapon {
	public int  ammoCount = 10;
	public string weaponName = "Shotgun";
	public float firePower = 21.5f;
	
}

public class PowerUp {
	public float powerLevel = 2.5f;
}