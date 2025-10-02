public enum LogLevel
{
    Info,
    Warning,
    Error
}

public class Logger
{
    public void Log(string message, LogLevel level)
    {
        Console.WriteLine($"{level.ToString().ToUpper()}: {message}");
    }
}

public static class Configuration
{
    public static readonly string ConnectionString = "Server=myServer;Database=myDb;User Id=myUser;Password=myPass;";
}

public class DatabaseService
{
    public void Connect()
    {
        string connection = Configuration.ConnectionString;
        // Connection logic...
    }
}

public class LoggingService
{
    public void Log(string message)
    {
        string connection = Configuration.ConnectionString;
        // Logging logic...
    }
}