namespace module5cw;

public class Report()
{
    public string Header { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public string Footer { get; set; } = string.Empty;

    public void Export()
    {
        Console.WriteLine($"{Header} {Content} {Footer}");
    }
}

public interface IReportBuilder
{
    void SetHeader(string header);
    void SetContent(string content);
    void SetFooter(string footer);
    void AddSection(string sectionName, string sectionContent);
    Report GetReport();
}

public class TextReportBuilder : IReportBuilder
{
    private Report report = new();

    public void AddSection(string sectionName, string sectionContent)
    {
    }

    public Report GetReport()
    {
        return report;
    }

    public void SetContent(string content)
    {
        report.Content = content;
    }

    public void SetFooter(string footer)
    {
        report.Footer = footer;
    }

    public void SetHeader(string header)
    {
        report.Header = header;
    }
}

public static class ReportDirector
{
    public static Report Build(IReportBuilder builder)
    {
        builder.SetContent("content");
        builder.SetFooter("footer");
        builder.SetHeader("header");
        return builder.GetReport();
    }
}
