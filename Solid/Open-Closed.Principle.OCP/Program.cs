using Open_Closed.Principle.OCP.Utils;

VehicleType type = VehicleType.Car;



if (type == VehicleType.Car)
{
    Car car = new("Azul","Fusca","zzz6789",1969,1.0,3,4);
    car.CarStart();
}
else
{
    Motorcycle motorcycle = new("Preta", "Kawasaki Ninja H2R", "zzz6789", 2015, 1000);
    motorcycle.MotorcycleStart();
}
