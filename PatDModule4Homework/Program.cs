using PatDModule4Homework;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose vehicle type: car, motorcycle, truck, bus");
        string? type = Console.ReadLine()?.ToLower();

        VehicleFactory factory = type switch
        {
            "car" => new CarFactory(
    Prompt("Brand"),
    Prompt("Model"),
    Prompt("Fuel type")),
            "motorcycle" => new MotorcycleFactory(
                Prompt("Motorcycle type"),
                int.Parse(Prompt("Engine volume (cc)"))),
            "truck" => new TruckFactory(
                int.Parse(Prompt("Capacity (tons)")),
                int.Parse(Prompt("Number of axles"))),
            "bus" => new BusFactory(
                int.Parse(Prompt("Passenger capacity"))),
            _ => throw new ArgumentException("Unknown vehicle type.")
        };

        IVehicle vehicle = factory.CreateVehicle();
        vehicle.Drive();
        vehicle.Refuel();
    }

    static string Prompt(string message)
    {
        Console.Write($"{message}: ");
        return Console.ReadLine() ?? string.Empty;
    }
}
