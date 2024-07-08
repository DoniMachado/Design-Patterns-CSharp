namespace Interface.Segragation.Principle.ISP;

public class Motorcycle: IVehicleMotorcycle
{
    public string Color { get; }
    public string Model { get; }
    public string License { get; }
    public int Year { get; }
    public double CC { get; }
    public VehicleType Type { get; }

    public Motorcycle(string color, string model, string license, int year, double cc)
    {
        Color = color;
        Model = model;
        License = license;
        Year = year;
        CC = cc;
        Type = VehicleType.Motorcycle;        
    }
    public void MotorcycleStart()
    {
        Console.WriteLine($"Criando um Moto: Cor:{Color}, Modelo:{Model},  Placa:{License}, Ano:{Year}, Cilindradas:{CC}");
        StartVehicle();
    }

    public void StartVehicle()
    {
        Console.WriteLine("Starting vehicle...");
    }
}
