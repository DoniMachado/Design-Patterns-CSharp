namespace Open_Closed.Principle.OCP.Utils;

public class Motorcycle: Vehicle
{
    public double CC { get; }

    public Motorcycle(string color, string model, string license, int year, double cc) : base(color, model, license, year, VehicleType.Motorcycle)
    {
        CC = cc;    
    }
    public void MotorcycleStart()
    {
        Console.WriteLine($"Criando um Moto: Cor:{Color}, Modelo:{Model},  Placa:{License}, Ano:{Year}, Cilindradas:{CC}");
        StartVehicle();
    }
}
