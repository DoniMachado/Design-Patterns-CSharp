namespace Interface.Segragation.Principle.ISP;

public class Car: IVehicleCar
{
    public string Color { get; }
    public string Model { get; }
    public string License { get; }
    public int Year { get; }
    public double Engine { get; }
    public int Seats { get; }
    public int Doors { get; }
    public VehicleType Type { get; }

    public Car(string color, string model, string license, int year, double engine, int seats, int doors)
    {
        Engine = engine;
        Seats = seats;
        Doors = doors;
        Color = color;
        Model = model;
        License = license;
        Year = year;
        Engine = engine;
        Seats = seats;
        Doors = doors;
        Type = VehicleType.Car;
    }

    public void CarStart()
    {
        Console.WriteLine($"Criando um Carro: Cor:{Color}, Modelo:{Model},  Placa:{License}, Ano:{Year}, Motor:{Engine}, Assento:{Seats},Portas:{Doors}");
        StartVehicle();
    }

    public void StartVehicle()
    {
        Console.WriteLine("Starting vehicle...");
    }
}
