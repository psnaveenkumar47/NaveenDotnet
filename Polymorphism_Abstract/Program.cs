using System;
abstract class PlaneDetails
{
	protected string customername, sourceplace, destinationplace;
	protected int customerage;
	public abstract void AirlineDetails();
}
class AirAsia:PlaneDetails
{
	protected int airasiaprice = 1000;
	public AirAsia(string name,int age,string source,string destination)
    {
	  
		this.customername = name;
		this.sourceplace = source;
		this.destinationplace = destination;
		this.customerage = age;
    }
    public override void AirlineDetails()
    {
        Console.WriteLine($"Airasia Details\n Customer Name is :{customername}\n Customer Age is :{customerage}\n Source Place is :{sourceplace}\n Destination Place is :{destinationplace}\n Cost for AirAsia is :{airasiaprice}");
    }
}
class Emirates:PlaneDetails
{
	protected int emiratesprice = 2000;
	public Emirates(string name, int age, string source, string destination)
	{

		this.customername = name;
		this.sourceplace = source;
		this.destinationplace = destination;
		this.customerage = age;
	}
	public override void AirlineDetails()
    {
        Console.WriteLine($"Emirates details\n Customer Name is :{customername}\n Customer Age is :{customerage}\n Source Place is :{sourceplace}\n Destination Place is :{destinationplace}\n Cost for AirAsia is :{emiratesprice}");
    }
}
class Kingfisher:PlaneDetails
{
	protected int kingfisherprice = 3000;
	public Kingfisher(string name, int age, string source, string destination)
	{

		this.customername = name;
		this.sourceplace = source;
		this.destinationplace = destination;
		this.customerage = age;
	}
	public override void AirlineDetails()
    {
       Console.WriteLine($"Kingfisher Details\n Customer Name is :{customername}\n Customer Age is :{customerage}\n Source Place is :{sourceplace}\n Destination Place is :{destinationplace}\n Cost for AirAsia is :{kingfisherprice}");

	}
}
class MainClass
{
	static int option, counter;
	static char choice;
	static string customername, sourcelocation, destinationlocation;
	static int age;
	static PlaneDetails[] Airlinearray = new PlaneDetails[10];
	static void Main()
	{
		Console.Write("Enter Name of a Customer:");
		customername = Console.ReadLine();
		Console.Write("Enter age of a Customer:");
		age = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter source location of customer:");
		sourcelocation = Console.ReadLine();
		Console.Write("Enter destination location of customer:");
		destinationlocation = Console.ReadLine();
		Airlinearray[counter++] = new AirAsia(customername, age, sourcelocation, destinationlocation);
		do
		{
			Console.WriteLine("The Options Are:");
			Console.WriteLine(" 1.Air Asia \n 2.Emirates \n 3.Kingfisher \n 4.Exit ");
			Console.Write("Choose an option to continue:");
			option = Convert.ToInt32(Console.ReadLine());
			Switch(option);
			Console.WriteLine("Do you want to continue (Y/N)");
			choice = Console.ReadLine()[0];
		} while (choice == 'y' || choice == 'Y');
	}
	static void Switch(int number)
	{
		switch (option)
		{
			case 1:
				AirAsia airasiaobject=new AirAsia(customername, age, sourcelocation, destinationlocation);
				airasiaobject.AirlineDetails();				
				break;
			case 2:
				Emirates emiratesobject=new Emirates(customername, age, sourcelocation, destinationlocation);
				emiratesobject.AirlineDetails();
				
				break;
			case 3:
				Kingfisher kingobject=new Kingfisher(customername, age, sourcelocation, destinationlocation);	
				kingobject.AirlineDetails();
				break;
			case 4:
				Console.WriteLine("Program is now Exicited");
				Environment.Exit(0);
				break;

		}
	}
}
