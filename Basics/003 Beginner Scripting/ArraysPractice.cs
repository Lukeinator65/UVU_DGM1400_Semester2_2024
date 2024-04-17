using System;
					
public class Program
{
	public void Main()
	{
		string[] cars = {"Mustang", "Camaro", "HellCat", "Corvette", "Viper", "Mclaren"};
		Console.WriteLine(cars.Length);
	foreach(var car in cars) {
		Console.WriteLine("I love my " + car + ".");
		}
	}
}