using PatDM4Lab;

class Program
{
    static void Main()
    {
        Console.WriteLine("Available transport types: car, motorcycle, plane, bicycle");
        Console.Write("Enter transport type: ");
        string? typeInput = Console.ReadLine();
        string type = typeInput?.ToLower() ?? throw new Exception("Transport type is required.");

        Console.Write("Enter model: ");
        string? modelInput = Console.ReadLine();
        string model = modelInput ?? throw new Exception("Model is required.");

        Console.Write("Enter speed (km/h): ");
        int speed = int.TryParse(Console.ReadLine(), out var s) ? s : 0;

        TransportFactory factory = type switch
        {
            "car" => new CarFactory(),
            "motorcycle" => new MotorcycleFactory(),
            "plane" => new PlaneFactory(),
            "bicycle" => new BicycleFactory(),
            _ => throw new Exception("Unknown transport type.")
        };

        ITransport transport = factory.CreateTransport(model, speed);
        transport.Move();
        transport.FuelUp();
    }
}
