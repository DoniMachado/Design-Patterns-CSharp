namespace Open_Closed.Principle.OCP.Utils;

public class Vehicle
{
    public string Color { get; }
    public string Model { get; }
    public string License { get; }
    public int Year { get; }

    public Vehicle(string color, string model, string license,int year, VehicleType type)
	{
        Color = color;
        Model = model;
        License = license;
        Year = year;
    }

    public void StartVehicle()
    {
        Console.WriteLine("Starting vehicle...");
    }
}
