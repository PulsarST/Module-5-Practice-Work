public enum LoggerLevel
{
    INFO = 0, WARNING = 1, ERROR = 2,
}

public class Logger
{
    private static Logger? instance;
    public LoggerLevel Level { get; set; }

    public static Logger GetInstance()
    {
        instance ??= new Logger();
        return instance;
    }

    public void Log(LoggerLevel level, string meesage)
    {
        if (level < Level) return;
        if (level >= Level) Console.WriteLine($"[{level.ToString()}]: {meesage}");
    }
}
