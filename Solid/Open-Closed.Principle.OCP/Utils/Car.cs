namespace Open_Closed.Principle.OCP.Utils;

public class Car: Vehicle
{
    public double Engine { get; }
    public int Seats { get; }
    public int Doors { get; }

    public Car(string color, string model, string license, int year, double engine, int seats, int doors):base(color, model, license, year, VehicleType.Car)
    {
        Engine = engine;
        Seats = seats;
        Doors = doors;
    }

    public void CarStart()
    {
        Console.WriteLine($"Criando um Carro: Cor:{Color}, Modelo:{Model},  Placa:{License}, Ano:{Year}, Motor:{Engine}, Assento:{Seats},Portas:{Doors}");
        StartVehicle();
    }
}
