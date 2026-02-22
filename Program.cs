namespace module5cw;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("----part 1 -----");
        Logger logger = Logger.GetInstance();
        logger.Level = LoggerLevel.INFO;
        logger.Log(LoggerLevel.INFO, "test test test");

        Console.WriteLine("----part 2 -----");
        IReportBuilder builder = new TextReportBuilder();
        Report report = ReportDirector.Build(builder);
        report.Export();

        Console.WriteLine("----part 3 -----");

        Character character = new(new Weapon(2), new Armor(3), new Skill(4));
        var newCharacter = character.Clone();
    }
}
