using PatDM1P1;

class Program
{
    static void Main(string[] args)
    {
        // Create fleet
        Fleet fleet = new Fleet();

        // Create garages
        Garage garage1 = new Garage("Central Garage");
        Garage garage2 = new Garage("North Garage");

        // Add garages to fleet
        fleet.AddGarage(garage1);
        fleet.AddGarage(garage2);

        // Create vehicles
        Car car1 = new Car("Toyota", "Camry", 2020, 4, "Automatic");
        Car car2 = new Car("BMW", "5 Series", 2022, 4, "Manual");
        Motorcycle moto1 = new Motorcycle("Yamaha", "R1", 2019, "Sport", false);
        Motorcycle moto2 = new Motorcycle("Harley-Davidson", "Street 750", 2021, "Cruiser", true);

        // Add vehicles to garages
        garage1.AddVehicle(car1);
        garage1.AddVehicle(moto1);

        garage2.AddVehicle(car2);
        garage2.AddVehicle(moto2);

        // Display fleet
        Console.WriteLine("\n== Current Fleet ==");
        fleet.DisplayFleet();

        // Search for a vehicle
        Console.WriteLine("\n== Vehicle Search ==");
        fleet.FindVehicle("R1");

        // Remove vehicle
        Console.WriteLine("\n== Removing Vehicle ==");
        garage1.RemoveVehicle(moto1);

        // Remove garage
        Console.WriteLine("\n== Removing Garage ==");
        fleet.RemoveGarage(garage2);

        // Final state
        Console.WriteLine("\n== Final Fleet ==");
        fleet.DisplayFleet();

        Console.ReadLine();
    }
}
